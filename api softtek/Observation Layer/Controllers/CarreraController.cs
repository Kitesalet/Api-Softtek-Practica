using api_softtek.Common_Layer.DTOs;
using api_softtek.Common_Layer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_softtek.Top_Layer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private readonly ICarreraService _service;

        public CarreraController(ICarreraService service)
        {

            _service = service;


        }

        [HttpPost]
        public IActionResult Post([FromBody] CarreraDto entity)
        {

            var x = _service.CreateCarrera(entity);

            return Ok(x);

        }

        [HttpGet]

        public IActionResult GetAll()
        {

           var x = _service.GetAllCarreras();


            return Ok(x);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {

            var x = _service.GetCarreraById(id);

            if(x == null)
            {
                return NotFound();
            }

            return Ok(x);


        }


        [HttpPut]

        public IActionResult Update([FromBody] CarreraDto entity)
        {

            var x = _service.GetCarreraById(entity.Id);

            if(x == null)
            {
                return NotFound();
            }

            var y = _service.UpdateCarrera(entity);

            return Ok(y);

        }


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {

            var x = _service.GetCarreraById(id);

            if(x == null)
            {
                return NotFound();
            }

            return Ok(_service.DeleteCarrera(id));


        }

    }
}
