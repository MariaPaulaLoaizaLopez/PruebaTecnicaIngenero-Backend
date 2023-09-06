using GestionLogistica.Database.Context;
using GestionLogistica.Database.Models;
using GestionLogistica.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Database.Repositories
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        private readonly GestionLogisticaContext _context;
        public PedidoRepository(GestionLogisticaContext context) : base(context)
        {
                _context = context;
        }
        public Pedido GetPedidoByProducto(string NombreProducto)
        {
            throw new NotImplementedException();
        }
    }
}
