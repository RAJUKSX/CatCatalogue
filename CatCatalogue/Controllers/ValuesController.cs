using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CatCatalogue.Controllers
{
    public class ValuesController : ApiController
    {
        /// <summary>
        /// ValuesController
        /// </summary>
        public ValuesController()
        {

        }


        /// <summary>
        /// Gets some very important data from the server.
        /// </summary>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Looks up some data by ID.
        /// </summary>
        /// <param name="id">The ID of the data.</param>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Submit data.
        /// </summary>
        /// <param name="value">The value of the data.</param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Submit data.
        /// </summary>
        /// <param name="id">The ID of the data.</param>
        /// <param name="value">The value of the data.</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Delete data by Id.
        /// </summary>
        /// <param name="id">The ID of the data.</param>        
        public void Delete(int id)
        {
        }
    }
}
