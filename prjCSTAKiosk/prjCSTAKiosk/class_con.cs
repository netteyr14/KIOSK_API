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
namespace prjCSTAKiosk
{
    public class class_con
    {
        private static HttpClient client = new HttpClient();
        private string url = "http://192.168.1.7:8080/";

        public async Task<bool> login(string username="", string password="") {
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
                return false;

            var loginData = new
            {
                username = username,
                password = password
            };

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                return false;
            }
            else {
                string json = JsonConvert.SerializeObject(loginData);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                string loginUrl = url + "login_user";

                HttpResponseMessage response = await client.PostAsync(loginUrl, content);

                string result = await response.Content.ReadAsStringAsync();

                var jsonResult = JObject.Parse(result);
                string status = jsonResult["status"].ToString();

                if (status.Equals("success", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
