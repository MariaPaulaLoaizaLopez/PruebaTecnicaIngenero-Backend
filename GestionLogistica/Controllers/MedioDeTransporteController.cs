using GestionLogistica.Database.Models;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLogistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedioDeTransporteController : Controller
    {
        private readonly IMedioDeTransporteService _medioDeTransporteService;

        public MedioDeTransporteController(IMedioDeTransporteService medioDeTransporteService)
        {
            _medioDeTransporteService = medioDeTransporteService;   
        }

        [HttpGet(Name = "GetMediosDeTransporte")]
        public async Task<IActionResult> GetMediosDeTransporteAsync()
        {
            var mediosDeTransporte = await _medioDeTransporteService.GetMediosDeTransporte();
            return Ok(mediosDeTransporte);
        }

        [HttpGet("{id}", Name = "GetMedioDeTransporteById")]
        public async Task<IActionResult> GetMedioDeTransporteAsync(int id)
        {
            var medioDeTransporte =  await _medioDeTransporteService.GetMedioDeTransporte(id); 
            if (medioDeTransporte == null)
            {
                return NotFound();
            }
            return Ok(medioDeTransporte);
        }

        [HttpPost(Name = "CreateMedioDeTransporte")]
        public async Task<IActionResult> CreateMedioDeTransporte(MedioDeTransporteDTO medioDeTransporte)
        {
            await _medioDeTransporteService.AddMedioDeTransporte(medioDeTransporte);
            return Ok(medioDeTransporte);
        }

        [HttpPut(Name = "UpdateMedioDeTransporte")]
        public async Task<IActionResult> UpdateMedioDeTransporteAsync(MedioDeTransporteDTO medioDeTransporte)
        {
            await _medioDeTransporteService.UpdateMedioDeTransporte(medioDeTransporte);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteMedioDeTransporte")]
        public async Task<IActionResult> DeleteMedioDeTransporte(int id)
        {
            await _medioDeTransporteService.DeleteMedioDeTransporte(id);
            return Ok();
        }


    }
}
