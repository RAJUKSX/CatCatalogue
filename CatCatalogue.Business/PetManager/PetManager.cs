using CatCatalogue.Data;
using CatCatalogue.Data.Models.DTO;
using CatCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CatCatalogue.Common;

namespace CatCatalogue.Business
{
    public class PetManager : IPetManager
    {
        #region Private Properties
        private readonly IPetRepository petRepository;
        #endregion

        #region Constructor
        /// <summary>
        /// PetManager
        /// </summary>
        /// <param name="petRepository"></param>
        public PetManager(IPetRepository petRepository)
        {
            this.petRepository = petRepository;
        }
        #endregion

        #region Public Methods
        public async Task<GetPetsModel> GetPetDetails(PetType petType)
        {
            GetPetsModel response = new GetPetsModel();
            var peopleInfo = await petRepository.GetPetDetails();

            if(peopleInfo != null)
            {
                //Read all the pets based on owner's gender and based on the pet type in alphabetical order

                response.MaleOwnedCats = peopleInfo
                            .Where(person => person.Gender == Gender.Male && person.Pets != null && person.Pets.Any(pet => pet.Type == petType))
                            .SelectMany(owner => owner.Pets.Where(pet => pet.Type == petType))
                            .OrderBy(pet => pet.Name);

                response.FemaleOwnedCats = peopleInfo
                            .Where(person => person.Gender == Gender.Female && person.Pets != null && person.Pets.Any(pet => pet.Type == petType))
                            .SelectMany(owner => owner.Pets.Where(pet => pet.Type == petType))
                            .OrderBy(pet => pet.Name);
                
            }

            return response;
            
        }

        #endregion
    }
}
