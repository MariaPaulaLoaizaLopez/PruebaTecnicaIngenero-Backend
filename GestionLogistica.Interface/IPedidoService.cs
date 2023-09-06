using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetPedidos();
        Task<Pedido> GetPedido(int id);
        Task AddPedido(PedidoDTO pedido);
        Task UpdatePedido(PedidoDTO pedido);
        Task DeletePedido(int id);
        Pedido GetPedidoByProducto(string NombreProducto);
    }
}
