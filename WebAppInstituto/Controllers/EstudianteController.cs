using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppInstituto.Controllers
{
    public class EstudianteController : ApiController
    {
        InstitutoEntities con = new InstitutoEntities();
        // GET: api/Estudiante
        public IEnumerable<estudiante> Get()
        {
            return con.estudiante.ToList();
        }

        // GET: api/Estudiante/5
        public estudiante Get(int id)
        {
            return con.estudiante.Find(id);
        }

        // POST: api/Estudiante
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Estudiante/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Estudiante/5
        public void Delete(int id)
        {
        }
    }
}
