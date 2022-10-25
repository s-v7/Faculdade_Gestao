using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Faculdade_Gestao.Models;
using Faculdade_Gestao.Services;

namespace Faculdade_Gestao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Faculdade_GestaoControllers : ControllerBase
    {


        [HttpGet(Name = "")]
        public ActionResult<List<Cursos>> GetAll => Faculdade_GestaoServices.GetAll();



        [HttpGet]
        public IEnumerable<Cursos> Get()
        {
            var curso = new Cursos();
            if (curso is null)
                return null;
            

        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

        }

        [HttpPost]
        public ActionResult Create(Cursos cursos)
        {
	    
	
            
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Cursos cursos)
        {
            if (id != cursos.idCursoHash)
                return BadRequest();

            var existingCursos = Faculdade_GestaoServices.Get(id);
            if (existingCursos is null)
                return NotFound();

            Faculdade_GestaoServices.Updade(cursos);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cursos = Faculdade_GestaoServices.Get(id);

            if (cursos is null)
                return NotFound();

            Faculdade_GestaoServices.Delete(id);

        }


    }
    
}