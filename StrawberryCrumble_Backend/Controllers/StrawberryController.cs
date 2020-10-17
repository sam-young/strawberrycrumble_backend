using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace StrawberryCrumble_Backend.Controllers
{
    public class StrawberryController : ApiController
    {
        // GET: api/Strawberry
        public JsonResult<string[]> Get()
        {
            var xml = new string[] { "Crumbleeeeeeeeeeeee", "value2" };
            return Json(xml);
        }

        // GET: api/Strawberry/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Strawberry
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Strawberry/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Strawberry/5
        public void Delete(int id)
        {
        }
    }
}
