using CatCatalogue.Business;
using CatCatalogue.Common;
using CatCatalogue.Controllers;
using CatCatalogue.Data;
using CatCatalogue.Data.Models.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CatCatalogue.Tests.Controllers
{
    [TestClass]
    public class PetControllerTest
    {
        [TestMethod]
        public void GetCatsByOwnerGender()
        {
            // Arrange
            PetRepository repository = new PetRepository();
            PetManager manager = new PetManager(repository);            
            PetController controller = new PetController(manager);

            // Act
            Task<GetPetsModel> result = controller.GetPetsByOwnerGender(PetType.Cat);
            
            // Assert
            Assert.IsNotNull(result);
           
        }
    }
}
