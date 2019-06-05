using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace CatCatalogue.Helpers
{
    public static class Utility
    {
        /// <summary>
        /// used to get app setting value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetAppSettingValues(string value)
        {
            return ConfigurationManager.AppSettings[value].ToString();
        }

        /// <summary>
        /// Initilaise the HTTP Client
        /// </summary>
        /// <returns></returns>
        public static HttpClient InitilaizeHttpClient()
        {
            HttpClient client = new HttpClient { };
            client.BaseAddress = new Uri(GetAppSettingValues("WebApiURL"));
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add
                (new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        /// <summary>
        /// Post as Async Method
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static async Task<string> ConsumeExternalAPI(string url, object data)
        {
            // HttpClient client = new HttpClient();
            HttpClient client = InitilaizeHttpClient();
            HttpResponseMessage response = await client.PostAsJsonAsync(url, data);
            if (response.IsSuccessStatusCode)
            {
                var contents = await response.Content.ReadAsStringAsync();
                return contents;

            }
            else
            {
                return string.Empty;
            }
        }
    }
}