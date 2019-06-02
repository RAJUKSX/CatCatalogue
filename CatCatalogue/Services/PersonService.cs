using CatCatalogue.Common;
using CatCatalogue.Data.Models.DTO;
using CatCatalogue.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CatCatalogue.Services
{
    public class PersonService: IPersonService
    {

        public async Task<GetPetsModel> GetPetsByOwnerGender(PetType petType)
        {
            GetPetsModel model = new GetPetsModel();
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://agl-developer-test.azurewebsites.net/people.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody != null)
                {
                    var personPetInfo = JsonConvert.DeserializeObject<IEnumerable<Person>>(responseBody);

                    model = new GetPetsModel
                    {
                        MaleOwnedCats = personPetInfo
                            .Where(person => person.Gender == Gender.Male && person.Pets != null && person.Pets.Any(pet => pet.Type == petType))
                            .SelectMany(owner => owner.Pets.Where(pet => pet.Type == petType))
                            .OrderBy(pet => pet.Name),

                        FemaleOwnedCats = personPetInfo
                            .Where(person => person.Gender == Gender.Female && person.Pets != null && person.Pets.Any(pet => pet.Type == petType))
                            .SelectMany(owner => owner.Pets.Where(pet => pet.Type == petType))
                            .OrderBy(pet => pet.Name),
                    };
                }

                return model;
            }
        }
    }
}