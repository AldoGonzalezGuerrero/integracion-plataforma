using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppLibreria.Controllers
{
    public class LibrosController : ApiController
    {
        libreriaEntities con = new libreriaEntities();
        // GET: api/Libros

        public IEnumerable<libro> Get()
        {
            return con.libro.ToList();

        }

        // GET: api/Libros/5
        public libro Get(int id_libro)
        {
            return con.libro.Find(id_libro);
        }

        // POST: api/Libros
        public IHttpActionResult Post([FromBody]libro lbo)
        {
            libro temp = con.libro.Where(s => s.id_libro == lbo.id_libro).FirstOrDefault();
            if (temp == null)
            {
                con.libro.Add(lbo);
                con.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT: api/Libros/5
        public IHttpActionResult Put(int id_libro, [FromBody] libro lbo)
        {
            libro tmp = con.libro.Find(lbo.id_libro);
            if (tmp != null)
            {
                tmp.titulo = lbo.titulo;
                con.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/Libros/5
        public IHttpActionResult DELETE([FromBody] libro lbo)
        {
            libro tmp = con.libro.Find(lbo.id_libro);
            if (tmp != null)
            {
                con.libro.Remove(tmp);
                con.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
