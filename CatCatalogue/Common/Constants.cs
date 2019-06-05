using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatCatalogue.Common
{
    public class Constants
    {
        public const string SERVICE_GetCatDetails = "pet/GetPetsByOwnerGender?PetType=cat";
    }

    public enum Gender
    {
        Female,
        Male
    }

    public enum PetType
    {
        Dog,
        Cat,
        Fish
    }
}