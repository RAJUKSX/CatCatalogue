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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace CatCatalogue.Tests.Controllers
{
    [TestClass]
    public class PetControllerTest
    {
        [TestMethod]
        public async Task GetCatsByOwnerGender()
        {
            GetPetsModel petDetails = null;
            // Arrange
            PetRepository repository = new PetRepository();
            PetManager manager = new PetManager(repository);            
            PetController controller = new PetController(manager);
            //
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            // Act
            var response = await controller.GetPetsByOwnerGender(PetType.Cat);
            if (response.IsSuccessStatusCode)
            {
                petDetails = await response.Content.ReadAsAsync<GetPetsModel>();
            }
            // Assert
            Assert.IsNotNull(petDetails);
            //
            Assert.AreEqual(4, petDetails.MaleOwnedCats.Count());
            Assert.AreEqual(3, petDetails.FemaleOwnedCats.Count());
            //
            Assert.AreEqual("Garfield", petDetails.MaleOwnedCats.ElementAt(0).Name);
            Assert.AreEqual("Jim", petDetails.MaleOwnedCats.ElementAt(1).Name);
            Assert.AreEqual("Max", petDetails.MaleOwnedCats.ElementAt(2).Name);
            Assert.AreEqual("Tom", petDetails.MaleOwnedCats.ElementAt(3).Name);
            //
            Assert.AreEqual("Garfield", petDetails.FemaleOwnedCats.ElementAt(0).Name);
            Assert.AreEqual("Simba", petDetails.FemaleOwnedCats.ElementAt(1).Name);
            Assert.AreEqual("Tabby", petDetails.FemaleOwnedCats.ElementAt(2).Name);

        }
    }
}
