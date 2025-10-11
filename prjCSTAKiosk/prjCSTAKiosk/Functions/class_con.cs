using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCSTAKiosk.Functions
{
    internal class class_con
    {
        public enum HttpMethodType
        {
            POST,
            PUT
        }
        private static HttpClient client = new HttpClient();
        private string url = "http://192.168.1.6:8080/";

        public async Task<(bool success, string fullname, string role)> login(string username = "", string password = "")
        {

            var loginData = new
            {
                username = username,
                password = password
            };

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return (false, null, null);
            }
            else
            {
                try
                {
                    string json = JsonConvert.SerializeObject(loginData);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    string loginUrl = url + "login_user";
                    HttpResponseMessage response = await client.PostAsync(loginUrl, content);
                    string result = await response.Content.ReadAsStringAsync();
                    var jsonResult = JObject.Parse(result);

                    string status = jsonResult["status"].ToString(); //left will execute if not null, else gives an empty string. ternary operator to
                    string fullname = jsonResult["fullname"]?.ToString();
                    string role = jsonResult["role"]?.ToString();
                    string message = jsonResult["message"]?.ToString();

                    if (status.Equals("success", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return (true, fullname, role);
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return (false, null, null);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error Message: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, null, null);
                }

            }

        }

        public async Task loaddgv(DataGridView dgv, string route, string search = "", string cbo_selection = "")
        {
            string fullUrl = url + route;
            if (!string.IsNullOrEmpty(search))
            {
                fullUrl += $"?search={Uri.EscapeDataString(search)}&selection={Uri.EscapeDataString(cbo_selection)}";
            }
            try
            {
                var response = await client.GetStringAsync(fullUrl);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(response);
                if (dt != null)
                {
                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                    dgv.ClearSelection();
                    dgv.BeginInvoke((Action)(() => dgv.FindForm().ActiveControl = null));
                }
                else
                {
                    dgv.Rows.Clear();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error Message: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task loadcbo(ComboBox cbo, string route, string displaymem, string valuemem)
        {
            string finalUrl = url + route;
            var responce = await client.GetStringAsync(finalUrl);
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(responce);
            if (dt != null)
            {
                cbo.DataSource = dt;
                cbo.DisplayMember = displaymem;
                cbo.ValueMember = valuemem;
            }
            else
            {
                cbo.DataSource = null;
            }
        }

        public async Task loadcbo_ts(ToolStripComboBox tscbo, string route, string displaymem, string valuemem)
        {
            string finalUrl = url + route;
            var responce = await client.GetStringAsync(finalUrl);
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(responce);
            if (dt != null)
            {
                tscbo.ComboBox.DataSource = dt;
                tscbo.ComboBox.DisplayMember = displaymem;
                tscbo.ComboBox.ValueMember = valuemem;
            }
            else
            {
                tscbo.ComboBox.DataSource = null;
            }
        }

        public async Task CUD_Operation_Student(student_obj student_info, string route, HttpMethodType methodType) {
            string finalUrl = url + route;
            string json = JsonConvert.SerializeObject(student_info);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response;

            switch (methodType)
            {
                case HttpMethodType.POST:
                    response = await client.PostAsync(finalUrl, content);
                    break;
                case HttpMethodType.PUT:
                    response = await client.PutAsync(finalUrl, content);
                    break;
                default:
                    throw new InvalidOperationException("Invalid HTTP method type");
            }

            string result = await response.Content.ReadAsStringAsync();

            var jsonResult = JObject.Parse(result);
            string status = jsonResult["status"]?.ToString();
            string message = jsonResult["message"]?.ToString();

            if (status.Equals("success"))
            {
                MessageBox.Show("Message: " + status, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Message: " + status, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task<string> get_image_path(string route, string sql, string stud_num)
        {
            string finalUrl = url + route + $"?stud_num={Uri.EscapeDataString(stud_num)}&sql={Uri.EscapeDataString(sql)}";

            try
            {
                var response = await client.GetStringAsync(finalUrl);
                var jsonResult = JObject.Parse(response);
                string status = jsonResult["image_path"]?.ToString();
                return status ?? "No message field found";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

    }
}
