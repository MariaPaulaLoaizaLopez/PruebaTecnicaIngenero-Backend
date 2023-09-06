using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetProductos();
        Task<Producto> GetProducto(int id);
        Task AddProducto(ProductoDTO producto);
        Task UpdateProducto(ProductoDTO producto);
        Task DeleteProducto(int id);
    }
}
