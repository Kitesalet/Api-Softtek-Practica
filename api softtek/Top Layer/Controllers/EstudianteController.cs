using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace api_softtek.Top_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _service;

        public EstudianteController(IEstudianteService service)
        {

            _service = service;

        }

        [HttpPost]

        public IActionResult Post([FromBody] CarreraDto entity)
        {

            if(entity == null)
            {
                return NoContent();
            }

            int result = _service.CreateEstudiante(entity);

            return Ok(result);
        }


        [HttpGet]

        public IActionResult GetAll()
        {

            return Ok(_service.GetAllEstudiantes());

        }


        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
           var x = _service.GetEstudianteById(id);
        
            if(x == null)
            {
                return NotFound();
            }
        
            return Ok(x);
        }

        [HttpPut]

        public IActionResult Update([FromBody] CarreraDto entity)
        {

            var x = _service.GetEstudianteById(entity.Id);

            if (x == null)
            {
                return NotFound();
            }

            _service.UpdateEstudiante(entity);

           

            return Ok(entity);

        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var x =_service.DeleteEstudiante(id);

            if(x == false)
            {
                return NotFound();
            }

            return Ok(x);
        }

    }
}
