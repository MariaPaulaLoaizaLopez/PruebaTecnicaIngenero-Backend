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
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        private readonly GestionLogisticaContext _context;
        public ProductoRepository(GestionLogisticaContext context) : base(context)
        {
                _context = context;
        }
        public Producto GetProductoByName(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
