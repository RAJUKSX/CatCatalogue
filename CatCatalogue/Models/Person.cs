using CatCatalogue.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatCatalogue.Models
{
    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }
}