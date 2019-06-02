using CatCatalogue.Common;
using CatCatalogue.Data.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatCatalogue.Business
{
    public interface IPetManager
    {
        Task<GetPetsModel> GetPetDetails(PetType petType);
    }
}
