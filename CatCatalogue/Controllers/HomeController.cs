using CatCatalogue.Business.PetManager;
using CatCatalogue.Common;
using CatCatalogue.DataAccess.Models.Custom;
using CatCatalogue.DataAccess.Services.PetRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CatCatalogue.Controllers
{
/******************************************************************************************
FILE_NAME:  HomeControll.cs
PURPOSE:    This is the default MVC controller which comes as part Asp .Net Web Api project. 
            We are using it consume the Pet Service from the Pet controller and display the output.

******************************************************************/
    public class HomeController : Controller
    {
        #region Private Variables
        private HttpClient client;
        #endregion

        #region Controller
        public HomeController()
        {
            client = new HttpClient();
        }
        #endregion

        #region Public Methods
        public async Task<ActionResult> Index()
        {
            GetPetsModel model = null;

            //Calling Web Api - Pet Service from MVC controller to display the output.
            //Could have directly called PetManager.cs from here but it requires to instantiate PetManager.cs and PetRepository.cs here which will make those classes tightly coupled to HomeController.cs
            //Could not implement Dependency Injection for this MVC controller since this is primarily an Web Api project and Web Api DI implementation is already in place.
            HttpResponseMessage response = await client.GetAsync(ConfigurationManager.AppSettings["WebApiURL"]);
            if (response.IsSuccessStatusCode)
            {
                model = await response.Content.ReadAsAsync<GetPetsModel>();
            }

            return View(model);
        }
        #endregion
    }
}
