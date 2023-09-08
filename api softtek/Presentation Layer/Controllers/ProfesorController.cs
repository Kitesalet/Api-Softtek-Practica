using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_softtek.Presentation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _service;

        public ProfesorController(IProfesorService service)
        {
            _service = service;
        }


        [HttpPost]
        public IActionResult Post([FromBody] ProfesorDto entity)
        {

            var x = _service.CreateProfesor(entity);

            return Ok(x);

        }

        [HttpGet]

        public IActionResult GetAll()
        {

            var x = _service.GetAllProfesores();


            return Ok(x);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {

            var x = _service.GetProfesorById(id);

            if (x == null)
            {
                return NotFound();
            }

            return Ok(x);


        }


        [HttpPut]

        public IActionResult Update([FromBody] ProfesorDto entity)
        {

            var x = _service.GetProfesorById(entity.Id);

            if (x == null)
            {
                return NotFound();
            }

            var y = _service.UpdateProfesor(entity);

            return Ok(y);

        }


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {

            var x = _service.GetProfesorById(id);

            if (x == null)
            {
                return NotFound();
            }

            return Ok(_service.DeleteProfesor(id));


        }


    }
}
