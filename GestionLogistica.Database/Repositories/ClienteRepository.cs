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
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly GestionLogisticaContext _context;

        public ClienteRepository(GestionLogisticaContext context) : base(context)
        {
            _context = context;
        }
        public Cliente GetClienteByDNI(int dni)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClienteByName(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
