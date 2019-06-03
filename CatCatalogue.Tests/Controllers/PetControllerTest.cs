using CatCatalogue.Business;
using CatCatalogue.Business.PetManager;
using CatCatalogue.Common;
using CatCatalogue.Controllers;
using CatCatalogue.DataAccess.Models.Custom;
using CatCatalogue.DataAccess.Services.PetRepository;
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
        public async Task GetCatsByOwnerGender()
        {
            // Arrange
            PetRepository repository = new PetRepository();
            PetManager manager = new PetManager(repository);            
            PetController controller = new PetController(manager);

            // Act
            GetPetsModel result = await controller.GetPetsByOwnerGender(PetType.Cat);
            
            // Assert
            Assert.IsNotNull(result);
            //
            Assert.AreEqual(4, result.MaleOwnedCats.Count());
            Assert.AreEqual(3, result.FemaleOwnedCats.Count());
            //
            Assert.AreEqual("Garfield", result.MaleOwnedCats.ElementAt(0).Name);
            Assert.AreEqual("Jim", result.MaleOwnedCats.ElementAt(1).Name);
            Assert.AreEqual("Max", result.MaleOwnedCats.ElementAt(2).Name);
            Assert.AreEqual("Tom", result.MaleOwnedCats.ElementAt(3).Name);
            //
            Assert.AreEqual("Garfield", result.FemaleOwnedCats.ElementAt(0).Name);
            Assert.AreEqual("Simba", result.FemaleOwnedCats.ElementAt(1).Name);
            Assert.AreEqual("Tabby", result.FemaleOwnedCats.ElementAt(2).Name);

        }
    }
}
