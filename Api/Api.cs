using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestTask.Model;


namespace TestTask
{
    public class Api
    {
        private HttpClient Client
        {
            get { return new HttpClient(); }
        }

        public static string urlCoinCap = "https://api.coincap.io/v2/";
        public async Task<T> FetchDataAsync<T>(string url) => await QueryToApiAsync<T>(url);

        private async Task<T> QueryToApiAsync<T>(string url)  
        {
            try
            {
                using (Client)
                {
                    var response = await Client.GetAsync(url);
                    var res = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (res != null)
                    {
                        T data = JsonConvert.DeserializeObject<T>(res["data"].ToString());
                        return data;
                    }
                }
            }
            catch
            {
                Console.WriteLine("exp");
            }
            return default(T);
        }
    }
}