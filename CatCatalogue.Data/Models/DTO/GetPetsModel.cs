using CatCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatCatalogue.Data.Models.DTO
{
    public class GetPetsModel
    {
        public IEnumerable<Pet> MaleOwnedCats { get; set; } = new List<Pet>();
        public IEnumerable<Pet> FemaleOwnedCats { get; set; } = new List<Pet>();
    }
}
