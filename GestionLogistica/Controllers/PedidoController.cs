using GestionLogistica.Database.Models;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLogistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet(Name = "GetPedidos")]
        public async Task<IActionResult> GetPedidosAsync()
        {
            var pedidos = await _pedidoService.GetPedidos();
            return Ok(pedidos);
        }

        [HttpGet("{id}", Name = "GetPedidoById")]
        public async Task<IActionResult> GetPedidoAsync(int id)
        {
            var pedido = await _pedidoService.GetPedido(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        [HttpPost(Name = "CreatePedido")]
        public async Task<IActionResult> CreatePedido(PedidoDTO pedido)
        {
            await _pedidoService.AddPedido(pedido);
            return Ok(pedido);
        }

        [HttpPut(Name = "UpdatePedido")]
        public async Task<IActionResult> UpdatePedidoAsync(PedidoDTO pedido)
        {
            await _pedidoService.UpdatePedido(pedido);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePedido")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            await _pedidoService.DeletePedido(id);
            return Ok();
        }

    }
}
