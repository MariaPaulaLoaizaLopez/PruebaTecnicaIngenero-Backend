using AutoMapper;
using GestionLogistica.Database.Models;
using GestionLogistica.Database.Repositories.Interfaces;
using GestionLogistica.Interface;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Business.Services
{
    public class PlanDeEntregaService : IPlanDeEntregaService
    {
        private readonly IMapper _mapper;

        private IPlanDeEntregaRepository _planDeEntregaRepository;
        public PlanDeEntregaService(IPlanDeEntregaRepository planDeEntregaRepository, IMapper mapper)
        {
            _planDeEntregaRepository = planDeEntregaRepository;
            this._mapper = mapper;
        }
        public async Task AddPlanDeEntrega(PlanDeEntregaDTO planDeEntrega)
        {
            var planDb = _mapper.Map<PlanDeEntrega>(planDeEntrega);
            await _planDeEntregaRepository.Insert(planDb);
        }

        public async Task DeletePlanDeEntrega(int id)
        {
            await _planDeEntregaRepository.Delete(id);
        }

        public async Task<PlanDeEntrega> GetPlanDeEntrega(int id)
        {
            return await _planDeEntregaRepository.GetByID(id);
        }

        public async Task<IEnumerable<PlanDeEntrega>> GetPlanesDeEntrega()
        {
            return await _planDeEntregaRepository.GetAll();
        }

        public async Task UpdatePlanDeEntrega(PlanDeEntregaDTO planDeEntrega)
        {
            var planDb = _mapper.Map<PlanDeEntrega>(planDeEntrega);
            await _planDeEntregaRepository.Update(planDb);
        }
    }
}
