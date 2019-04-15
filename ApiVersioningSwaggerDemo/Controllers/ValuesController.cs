using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiVersioningSwaggerDemo.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get all values.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a value by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetById(int id)
        {
            return "value";
        }

        /// <summary>
        /// Post a value.
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Update a Value.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Delete a value.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
