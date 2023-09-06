using GestionLogistica.Database.Models;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLogistica.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
                _productoService = productoService;
        }

        [HttpGet(Name = "GetProductos")]
        public async Task<IActionResult> GetProductosAsync()
        {
            var productos = await _productoService.GetProductos();
            return Ok(productos);
        }

        [HttpGet("{id}", Name = "GetProductoById")]
        public async Task<IActionResult> GetProductoAsync(int id)
        {
            var producto = await _productoService.GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost(Name = "CreateProducto")]
        public async Task<IActionResult> CreateProducto(ProductoDTO producto)
        {
            await _productoService.AddProducto(producto);
            return Ok(producto);
        }

        [HttpPut(Name = "UpdateProducto")]
        public async Task<IActionResult> UpdateProductoAsync(ProductoDTO producto)
        {
            await _productoService.UpdateProducto(producto);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteProducto")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            await _productoService.DeleteProducto(id);
            return Ok();
        }

    }
}
