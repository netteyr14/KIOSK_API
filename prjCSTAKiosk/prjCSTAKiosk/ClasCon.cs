using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCSTAKiosk
{
    class ClasCon
    {
        //public OdbcConnection conn;
        //private string conStr = "server=localhost;uid=root;password=PASS_MO;database=dbIPT;Driver={MYSQL ODBC 3.51 Driver};";
        private static HttpClient client = new HttpClient();

        //public ClasCon()
        //{
            //conn = new OdbcConnection(conStr);
        //}

        //public void connection()
        //{
        //    if (conn.State != ConnectionState.Open)
                //conn.Open();
        //}

        //REPLACE TO

        //public DataTable GetDataTable(string sql)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        connection();
        //        using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
        //        {
        //            da.Fill(dt);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error: " + e.ToString(), "Error");
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return dt;
        //}

        public async Task LoadDataAsync(DataGridView dgv_param, string table_route, Dictionary<string, string> queryParams = null)
        {
            try
            {
                string url = $"http://csta.api:8080/{table_route}";

                // Append query parameters if provided
                if (queryParams != null && queryParams.Count > 0)
                {
                    string queryString = string.Join("&", queryParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
                    url += "?" + queryString;
                }

                // debugging url route test
                // MessageBox.Show("Request URL:\n" + url, "Debug URL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var response = await client.GetStringAsync(url);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(response);

                if (dt != null)
                {
                    dgv_param.DataSource = dt;
                    dgv_param.ClearSelection();
                    dgv_param.Tag = 0;
                    dgv_param.BeginInvoke((Action)(() => dgv_param.FindForm().ActiveControl = null));
                }
                else
                {
                    dgv_param.Rows.Clear();
                }
            }
            catch (Exception ex) 
            {
                if (dgv_param.DataSource is DataTable dt)
                    dt.Rows.Clear();
                else
                    dgv_param.Rows.Clear();

                MessageBox.Show("Message: "+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task LoadComboBoxAsync(ComboBox combo, string table_route, string displayMember, string valueMember)
        {
            try
            {
                string url = $"http://csta.api:8080/{table_route}";

                var response = await client.GetStringAsync(url);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(response);

                if (dt != null)
                {
                    combo.DataSource = dt;
                    combo.DisplayMember = displayMember;
                    combo.ValueMember = valueMember;
                }
                else
                {
                    combo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                combo.DataSource = null;
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
