using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AzureCrudExample.Models.Models;

namespace AzureCrudExample.Controllers
{
    public class BuildingController : ApiController
    {       
        private readonly rebpinEntities db = new rebpinEntities();

        public IQueryable<project_description> GetData()
        {
            return db.project_description;
        }

        [ResponseType(typeof(project_description))]
        public IHttpActionResult GetData(int id)
        {
            var d = db.project_description.FirstOrDefault(p=> p.project_id == id);
            if (d != null)
            {
                return Ok(d);
            }
            else
            {
                return BadRequest("Id does not exists");
            }
        }

        [ResponseType(typeof(project_description))]
        public IHttpActionResult PostData(project_description p)
        {
            db.project_description.Add(p);
            int i = db.SaveChanges();
            if (i>0)
            {
                return Ok(p);
            }
            else
            {
                return BadRequest();
            }
        }
    }


}
