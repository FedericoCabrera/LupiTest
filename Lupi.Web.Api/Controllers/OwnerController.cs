using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lupi.Data.DataAccess;
using Lupi.Data.Entities;
using Lupi.BusinessLogic;

namespace Lupi.Web.Api.Controllers
{
    public class OwnerController : ApiController
    {
        // GET: api/Owner
        public IEnumerable<Owner> Get()
        {
            List<Owner> owners;
            using (LupiDbContext db = new LupiDbContext())
            {
                owners = db.Owners.ToList<Owner>();
            }

            return owners;
        }

        // GET: api/Owner/5
        public string Get(int id)
        {
            return "value";
        }

        //// POST: api/Owner
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/Owner/5
        public void Post([FromBody]Owner owner)
        {
            //using (LupiDbContext db = new LupiDbContext())
            //{
            //    owner.Id = Guid.NewGuid();
            //    db.Owners.Add(owner);
            //    db.SaveChanges();
            //}
            owner.Id = Guid.NewGuid();

            BusinessLogic.AdmOwner admOwner = new AdmOwner();
            admOwner.CreateOwner(owner);


        }

        // DELETE: api/Owner/5
        public void Delete(int id)
        {
        }
    }
}
