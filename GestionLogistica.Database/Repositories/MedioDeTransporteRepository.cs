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
    public class MedioDeTransporteRepository : GenericRepository<MedioDeTransporte>, IMedioDeTransporteRepository
    {
        private readonly GestionLogisticaContext _context;
        public MedioDeTransporteRepository(GestionLogisticaContext context) : base(context)
        {
                _context = context;
        }
        public MedioDeTransporte GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
