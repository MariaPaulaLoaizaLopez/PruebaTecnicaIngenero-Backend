using GestionLogistica.Database.Models;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLogistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanDeEntregaController : Controller
    {
        private readonly IPlanDeEntregaService _planDeEntregaService;
        public PlanDeEntregaController(IPlanDeEntregaService planDeEntregaService)
        {
            _planDeEntregaService = planDeEntregaService;       
        }

        [HttpGet(Name = "GetPlanesDeEntrega")]
        public async Task<IActionResult> GetGetPlanesDeEntregaAsync()
        {
            var planesDeEntrega = await _planDeEntregaService.GetPlanesDeEntrega();
            return Ok(planesDeEntrega);
        }

        [HttpGet("{id}", Name = "GetPlanDeEntregaById")]
        public async Task<IActionResult> GetPlanDeEntregaAsync(int id)
        {
            var planDeEntrega = await _planDeEntregaService.GetPlanDeEntrega(id);
            if (planDeEntrega == null)
            {
                return NotFound();
            }
            return Ok(planDeEntrega);
        }

        [HttpPost(Name = "CreatePlanDeEntrega")]
        public async Task<IActionResult> CreatePlanDeEntrega(PlanDeEntregaDTO planDeEntrega)
        {
            await _planDeEntregaService.AddPlanDeEntrega(planDeEntrega);
            return Ok(planDeEntrega);
        }

        [HttpPut(Name = "UpdatePlanDeEntrega")]
        public async Task<IActionResult> UpdateClienteAsync(PlanDeEntregaDTO planDeEntrega)
        {
            await _planDeEntregaService.UpdatePlanDeEntrega(planDeEntrega);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePlanDeEntrega")]
        public async Task<IActionResult> DeletePlanDeEntrega(int id)
        {
            await _planDeEntregaService.DeletePlanDeEntrega(id);
            return Ok();
        }
    }
}
