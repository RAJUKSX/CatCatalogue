using CatCatalogue.Data.Models.DTO;
using CatCatalogue.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatCatalogue.Data
{
    public class PetRepository : IPetRepository
    {
        #region Public Methods
        public async Task<IEnumerable<Person>> GetPetDetails()
        {
            IEnumerable<Person> petList = null;
            using (HttpClient client = new HttpClient())
            {
                //Read the JSON data from the service and deserialize it
                HttpResponseMessage response = await client.GetAsync(ConfigurationManager.AppSettings["DataSourceServiceURL"]);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody != null)
                {
                    petList = JsonConvert.DeserializeObject<IEnumerable<Person>>(responseBody);                   
                };
            }

             return petList;

        }
        #endregion

    }
}
