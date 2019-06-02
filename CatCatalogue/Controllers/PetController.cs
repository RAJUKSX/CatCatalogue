using CatCatalogue.Business;
using CatCatalogue.Business.PetManager;
using CatCatalogue.Common;
using CatCatalogue.DataAccess.Models.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;

namespace CatCatalogue.Controllers
{
    /******************************************************************************************
    FILE_NAME:  PetControll.cs
    PURPOSE:    This class is the base page in Web Api for accessing Pet details.               

    ******************************************************************/
    public class PetController : ApiController
    {
        #region Private Properties
        private readonly IPetManager petManager;
        #endregion

        #region Constructor
        /// <summary>
        /// PetController
        /// </summary>
        /// <param name="petManager"></param>
        public PetController(IPetManager petManager)
        {
            this.petManager = petManager;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Get Pets By Owner Gender
        /// </summary>
        /// <param name="petType"></param>
        [HttpGet]
        public async Task<GetPetsModel> GetPetsByOwnerGender(PetType petType)
        {
            GetPetsModel response = await petManager.GetPetDetails(petType);
            return response;
        }
        #endregion
    }
}
