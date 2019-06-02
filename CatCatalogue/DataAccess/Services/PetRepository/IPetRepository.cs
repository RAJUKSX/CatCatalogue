using CatCatalogue.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatCatalogue.DataAccess.Services.PetRepository
{
    public interface IPetRepository
    {
        Task<IEnumerable<Person>> GetPetDetails();
    }
}
