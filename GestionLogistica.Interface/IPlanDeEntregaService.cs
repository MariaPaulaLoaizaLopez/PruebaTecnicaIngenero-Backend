using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface
{
    public interface IPlanDeEntregaService
    {
        Task<IEnumerable<PlanDeEntrega>> GetPlanesDeEntrega();
        Task<PlanDeEntrega> GetPlanDeEntrega(int id);
        Task AddPlanDeEntrega(PlanDeEntregaDTO planDeEntrega);
        Task UpdatePlanDeEntrega(PlanDeEntregaDTO planDeEntrega);
        Task DeletePlanDeEntrega(int id);

    }
}
