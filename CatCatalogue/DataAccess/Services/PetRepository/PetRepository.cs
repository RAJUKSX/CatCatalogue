using CatCatalogue.DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatCatalogue.DataAccess.Services.PetRepository
{
    public class PetRepository : IPetRepository
    {
        private HttpClient client;
        public PetRepository()
        {
            client = new HttpClient();
        }
        #region Public Methods
        public async Task<IEnumerable<Person>> GetPetDetails()
        {
            IEnumerable<Person> petList = null;

            //Read the JSON data from the service and deserialize it
            HttpResponseMessage response = await client.GetAsync(ConfigurationManager.AppSettings["DataSourceServiceURL"]);           
            if (response.IsSuccessStatusCode)
            {
                petList = await response.Content.ReadAsAsync<IEnumerable<Person>>();
            }            

            return petList;

        }
        #endregion

    }
}
