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
    public class PlanDeEntregaRepository : GenericRepository<PlanDeEntrega>, IPlanDeEntregaRepository
    {
        private readonly GestionLogisticaContext _context;
        public PlanDeEntregaRepository(GestionLogisticaContext context) : base(context)
        {
            _context = context;
        }
        public PlanDeEntrega GetPlanDeEntregaByCliente(int dni)
        {
            throw new NotImplementedException();
        }

        public PlanDeEntrega GetPlanDeEntregaByNumeroDeGuia(int numeroDeGuia)
        {
            throw new NotImplementedException();
        }
    }
}
