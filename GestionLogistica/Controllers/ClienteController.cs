
using GestionLogistica.Database.Context;
using GestionLogistica.Database.Models;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLogistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet(Name = "GetClientes")]
        public async Task<IActionResult> GetClientesAsync()
        {
            var clientes = await _clienteService.GetClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}", Name = "GetClienteById")]
        public async Task<IActionResult> GetClienteAsync(int id)
        {
            var cliente = await _clienteService.GetCliente(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost(Name = "CreateCliente")]
        public async Task<IActionResult> CreateCliente(ClienteDTO cliente)
        {
            await _clienteService.AddCliente(cliente);
            return Ok(cliente);
        }

        [HttpPut("{id}", Name = "UpdateCliente")]
        public async Task<IActionResult> UpdateClienteAsync(int id,ClienteDTO cliente)
        {
            await _clienteService.UpdateCliente(id,cliente);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCliente")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            await _clienteService.DeleteCliente(id);
            return Ok();
        }


    }
}
