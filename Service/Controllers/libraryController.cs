using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Implement;
using Test.Entity;
namespace Service.Controllers
{
    public class libraryController : ApiController
    {
        IMP_Library imp = new IMP_Library();

        [HttpGet]
        public List<library> listar_Biblioteca()
        {
            return imp.libraries();
        }

        [HttpGet]
        public List<library> listar_Biblioteca(int id)
        {
            var libreries = imp.libraries();
            var libreries1 = libreries.Where(x => x.Id == id).ToList();
            return libreries1;
        }
    }
}
