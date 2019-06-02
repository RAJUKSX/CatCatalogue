using CatCatalogue.Common;
using CatCatalogue.Data.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CatCatalogue.Services
{
    public interface IPersonService
    {
        Task<GetPetsModel> GetPetsByOwnerGender(PetType petType);
    }
}