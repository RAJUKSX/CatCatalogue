using CatCatalogue.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatCatalogue.DataAccess.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
    }
}