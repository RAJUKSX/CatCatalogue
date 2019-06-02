using CatCatalogue.Business;
using CatCatalogue.Common;
using CatCatalogue.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CatCatalogue.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPetManager petManager;

        public HomeController()
        {
            PetRepository petRepository = new PetRepository();
            this.petManager = new PetManager(petRepository);
        }

        public HomeController(IPetManager petManager)
        {
            this.petManager = petManager;
        }
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "AGL Developer Test";

            var model = await petManager.GetPetDetails(PetType.Cat);

            return View(model);
        }
    }
}
