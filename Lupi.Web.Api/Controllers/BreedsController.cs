using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Lupi.Data.DataAccess;
using Lupi.Data.Entities;
using System.Net.Http.Headers;

namespace Lupi.Web.Api.Controllers
{
    public class BreedsController : ApiController
    {
        // GET: api/Breeds
        public HttpResponseMessage Get()
        {
            using (LupiDbContext context = new LupiDbContext())
            {

                IEnumerable<Breed> breeds = context.Breeds.ToList();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, breeds);
                response.Headers.CacheControl = new CacheControlHeaderValue()
                {
                    MaxAge = TimeSpan.FromMinutes(20)
                };
                return response;
            }
        }

        // GET: api/Breeds/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Breeds
        public void Post([FromBody] Breed breed)
        {
            using (LupiDbContext context = new LupiDbContext())
            {
                Guid breedId = Guid.NewGuid();
                breed.Id = breedId;
                context.Breeds.Add(breed);
                context.SaveChanges();
            }
        }

        // PUT: api/Breeds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Breeds/5
        public void Delete(int id)
        {
        }
    }
}
