using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace ReleaseIt.Web.Client.Controllers
{
    public class DemoController : ApiController
    {
        public string GetLayout(int id)
        {
            return "value";
        }
    }
}
