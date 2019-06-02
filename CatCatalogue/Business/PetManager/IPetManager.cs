using CatCatalogue.Common;
using CatCatalogue.DataAccess.Models.Custom;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatCatalogue.Business.PetManager
{
    public interface IPetManager
    {
        Task<GetPetsModel> GetPetDetails(PetType petType);
    }
}
