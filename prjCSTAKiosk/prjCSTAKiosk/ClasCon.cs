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
        public OdbcConnection conn;
        private string conStr = "server=localhost;uid=root;password=Ambin123456123456;database=dbIPT;Driver={MYSQL ODBC 3.51 Driver};";
        private static HttpClient client = new HttpClient();

        public ClasCon()
        {
            conn = new OdbcConnection(conStr);
        }

        public void connection()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                connection();
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public async Task LoadDataAsync(DataGridView dgv_param, string table_route)
        {

            string url = $"http://192.168.1.7:8080/{table_route}";

            try
            {
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
            catch
            {
                if (dgv_param.DataSource is DataTable dt)
                    dt.Rows.Clear();
                else
                    dgv_param.Rows.Clear();

                MessageBox.Show("Message: Cannot connect to the server!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
