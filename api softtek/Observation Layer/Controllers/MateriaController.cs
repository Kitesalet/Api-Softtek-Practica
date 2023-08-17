using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Top_Layer.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_softtek.Observation_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {

        private readonly IMateriaService _service;

        public MateriaController(IMateriaService service)
        {

            _service = service;

        }

        [HttpPost]

        public IActionResult Post([FromBody] MateriaDto entity)
        {

            if (entity == null)
            {
                return NoContent();
            }

            int result = _service.CreateMateria(entity);

            return Ok(result);
        }


        [HttpGet]

        public IActionResult GetAll()
        {

            return Ok(_service.GetAllMaterias());

        }


        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var x = _service.GetMateriaById(id);

            if (x == null)
            {
                return NotFound();
            }

            return Ok(x);
        }

        [HttpPut]

        public IActionResult Update([FromBody] MateriaDto entity)
        {

            var x = _service.GetMateriaById(entity.Id);

            if (x == null)
            {
                return NotFound();
            }

            _service.UpdateMateria(entity);



            return Ok(entity);

        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var x = _service.DeleteMateria(id);

            if (x == false)
            {
                return NotFound();
            }

            return Ok(x);
        }



    }
}
