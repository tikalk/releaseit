using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using ReleaseIt.Repository.Contracts;

namespace ReleaseIt.Web.Client.Controllers.API
{
    public class ReleaseItemController : ApiController
    {
        [ImportingConstructor]
        public ReleaseItemController(IReleaseItemRepository repository)
        {

        }

        // GET /api/releaseitem
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /api/releaseitem/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/releaseitem
        public void Post(string value)
        {
        }

        // PUT /api/releaseitem/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/releaseitem/5
        public void Delete(int id)
        {
        }
    }
}
