using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AzureCrudExample.Controllers
{
    public class BuildingController : ApiController
    {

        public string[] GetBuildingList()
        {
            string[] names = {"Trimurti", "Mona"};
            return names;
        }
    }
}
