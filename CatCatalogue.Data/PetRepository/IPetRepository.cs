using CatCatalogue.Data.Models.DTO;
using CatCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatCatalogue.Data
{
    public interface IPetRepository
    {
        Task<IEnumerable<Person>> GetPetDetails();
    }
}
