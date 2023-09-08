using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Top_Layer.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_softtek.Observation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaService _service;

        public NotaController(INotaService service)
        {
            
            _service = service;

        }

        [HttpPost]
        public IActionResult Post([FromBody] NotaDto entity)
        {

            if (entity == null)
            {
                return NoContent();
            }

            int result = _service.CreateNota(entity);

            return Ok(result);
        }


        [HttpGet]

        public IActionResult GetAll()
        {

            return Ok(_service.GetAllNotas());

        }


        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var x = _service.GetNotaById(id);

            if (x == null)
            {
                return NotFound();
            }

            return Ok(x);
        }

        [HttpPut]

        public IActionResult Update([FromBody] NotaDto entity)
        {

            var x = _service.GetNotaById(entity.Id);

            if (x == null)
            {
                return NotFound();
            }

            _service.UpdateNota(entity);



            return Ok(entity);

        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var x = _service.DeleteNota(id);

            if (x == false)
            {
                return NotFound();
            }

            return Ok(x);
        }

    }
}
