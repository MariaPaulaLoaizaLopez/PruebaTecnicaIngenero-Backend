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
    public class AlmacenamientoService : IAlmacenamientoService
    {
        private readonly IMapper _mapper;

        private IAlmacenamientoRepository _almacenamientoRepository;

        public AlmacenamientoService(IAlmacenamientoRepository almacenamientoRepository, IMapper mapper)
        {
            _almacenamientoRepository = almacenamientoRepository;
            _mapper = mapper;
        }
        public async Task AddAlmacenamiento(AlmacenamientoDTO almacenamiento)
        {
            var almacenamientoDb = _mapper.Map<Almacenamiento>(almacenamiento);
            await _almacenamientoRepository.Insert(almacenamientoDb);
        }


        public async Task DeleteAlmacenamiento(int id)
        {
            await _almacenamientoRepository.Delete(id);
        }

        public async Task<Almacenamiento> GetAlmacenamiento(int id)
        {
            return await _almacenamientoRepository.GetByID(id);
        }

        public Almacenamiento GetAlmacenamientoByRazonSocial(string razonSocial)
        {
            return _almacenamientoRepository.GetAlmacenamientoByRazonSocial(razonSocial);
        }

        public async Task<IEnumerable<Almacenamiento>> GetAlmacenamientos()
        {
            return await _almacenamientoRepository.GetAll();
            
        }

        public async Task UpdateAlmacenamiento(AlmacenamientoDTO almacenamiento)
        {
            var almacenamientoDb = _mapper.Map<Almacenamiento>(almacenamiento);
            await _almacenamientoRepository.Update(almacenamientoDb);
        }


    }
}
