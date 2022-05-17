using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppLibreria.Controllers
{
    public class LibroController : Controller
    {
        // GET: Libro
        public IEnumerable<libro> Get()
        {
            return con.libro.ToList();
        }

        // GET: Libro/Details/5
        public libro Get(int id)
        {
            return con.libro.Find(id);
        }

        // POST: Libro/Create
        public IHttpActionResult Post([FromBody]libro lbo)
        {
            libro temp = con.libro.Where(s => s.id == lbo.id).FirstOfDefault();
            (if temp == null)
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
        //PUT REQUEST
        public IHttpActionResult Put(int id, [FromBody] libro lbo)
        {
            libro tmp = con.libro.Find(std.id);
            if (tmp != null)
            {
                con.autor = std.autor;
                con.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        //DELETE
        public IHttpActionResult DELETE([FromBody] libro lbo)
        {
            libro tmp = con.libro.Find(std.id);
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
}
