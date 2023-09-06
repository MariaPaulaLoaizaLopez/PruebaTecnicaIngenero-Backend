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
    public class MedioDeTransporteService : IMedioDeTransporteService
    {
        private readonly IMapper _mapper; 
        private IMedioDeTransporteRepository _transporteRepository;

        public MedioDeTransporteService(IMedioDeTransporteRepository medioDeTransporteRepository, IMapper mapper)
        {
            _transporteRepository = medioDeTransporteRepository;
            this._mapper = mapper;
        }
        public async Task AddMedioDeTransporte(MedioDeTransporteDTO medioDeTransporte)
        {
            var medioDb = _mapper.Map<MedioDeTransporte>(medioDeTransporte);
            await _transporteRepository.Insert(medioDb);
        }

        public async Task DeleteMedioDeTransporte(int id)
        {
            await _transporteRepository.Delete(id);
        }

        public async Task<MedioDeTransporte> GetMedioDeTransporte(int id)
        {
            return await _transporteRepository.GetByID(id);
        }

        public MedioDeTransporte GetMedioDeTransporteByName(string nombre)
        {
            return _transporteRepository.GetByName(nombre);
        }

        public async Task<IEnumerable<MedioDeTransporte>> GetMediosDeTransporte()
        {
            return await _transporteRepository.GetAll();
        }

        public async Task UpdateMedioDeTransporte(MedioDeTransporteDTO medioDeTransporte)
        {
            var medioDb = _mapper.Map<MedioDeTransporte>(medioDeTransporte);
            await _transporteRepository.Update(medioDb);
        }
    }
}
