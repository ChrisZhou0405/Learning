using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Learn.Controllers
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
        
        public string GetName(int id)
        {
            return "WebApi youga"+id.ToString();
        }
        public string GetName(int  id,string name)
        {
            return "WebApi youga" + id.ToString()+name;
        }
    }
}
