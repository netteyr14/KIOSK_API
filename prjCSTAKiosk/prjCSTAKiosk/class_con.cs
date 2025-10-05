using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace prjCSTAKiosk
{
    public class class_con
    {
        private static HttpClient client = new HttpClient();
        private string url = "http://192.168.1.7:8080/";

        public async Task<(bool success, string fullname, string role)> login(string username="", string password="") {

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
            else {
                try {
                    string json = JsonConvert.SerializeObject(loginData);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    string loginUrl = url + "login_user";
                    HttpResponseMessage response = await client.PostAsync(loginUrl, content);
                    string result = await response.Content.ReadAsStringAsync();
                    var jsonResult = JObject.Parse(result);

                    string status = jsonResult["status"].ToString() ?? ""; //left will execute if not null, else gives an empty string. ternary operator to
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
                catch (Exception e) {
                    MessageBox.Show($"Error Message: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false, null, null);
                }
                
            }
            
        }

        public async Task loaddgv(DataGridView dgv, string route, string search="") {
            string fullUrl = url + route;
            if (!string.IsNullOrEmpty(search))
            {
                fullUrl += $"?search={search}";
            }
            try {
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
            catch (Exception e) {
                MessageBox.Show($"Error Message: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
