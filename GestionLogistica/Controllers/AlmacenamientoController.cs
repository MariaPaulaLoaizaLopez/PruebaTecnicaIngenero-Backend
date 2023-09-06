using GestionLogistica.Database.Models;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLogistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmacenamientoController : Controller
    {
        private readonly IAlmacenamientoService _almacenamientoService;
        public AlmacenamientoController(IAlmacenamientoService almacenamientoService)
        {
            _almacenamientoService = almacenamientoService;
        }

        [HttpGet(Name = "GetAlmacenamientos")]
        public async Task<IActionResult> GetAlmacenamientosAsync()
        {
            var almacenamientos = await _almacenamientoService.GetAlmacenamientos();
            return Ok(almacenamientos);
        }

        [HttpGet("{id}", Name = "GetAlmacenamientoById")]
        public async Task<IActionResult> GetAlmacenamientoAsync(int id)
        {
            var almacenamiento = await _almacenamientoService.GetAlmacenamiento(id);
            if (almacenamiento == null)
            {
                return NotFound();
            }
            return Ok(almacenamiento);
        }

        [HttpPost(Name = "CreateAlmacenamiento")]
        public async Task<IActionResult> CreateAlmacenamiento(AlmacenamientoDTO almacenamiento)
        {
            await _almacenamientoService.AddAlmacenamiento(almacenamiento);
            return Ok(almacenamiento);
        }

        [HttpPut(Name = "UpdateAlmacenamiento")]
        public async Task<IActionResult> UpdateAlmacenamientoAsync(AlmacenamientoDTO almacenamiento)
        {
            await _almacenamientoService.UpdateAlmacenamiento(almacenamiento);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteAlmacenamiento")]
        public async Task<IActionResult> DeleteAlmacenamiento(int id)
        {
            await _almacenamientoService.DeleteAlmacenamiento(id);
            return Ok();
        }
    }
}
