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
    public class HomeController : Controller
    {
        #region Public Methods
        public async Task<ActionResult> Index()
        {            
            GetPetsModel model = null;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(ConfigurationManager.AppSettings["WebApiURL"]);
                if (response.IsSuccessStatusCode)
                {
                    model = await response.Content.ReadAsAsync<GetPetsModel>();
                }
            }

            return View(model);
        }
        #endregion
    }
}
