using AutoMapper;
using GestionLogistica.Database.Models;
using GestionLogistica.Database.Repositories.Interfaces;
using GestionLogistica.Interface;
using GestionLogistica.Interface.AutoMapper;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMapper _mapper;

        private IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository,IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            this._mapper = mapper;
        }

        public async Task AddCliente(ClienteDTO cliente)
        {
            var clienteDb = _mapper.Map<Cliente>(cliente);
            await _clienteRepository.Insert(clienteDb);
        }

        public async Task DeleteCliente(int id)
        {
            await _clienteRepository.Delete(id);
        }

        public async Task<ClienteDTO> GetCliente(int id)
        {
            var cliente = await _clienteRepository.GetByID(id);
            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);
            return clienteDTO;
        }

        public Cliente GetClienteByDNI(int dni)
        {
            var cliente = _clienteRepository.GetClienteByDNI(dni);
            return cliente;
        }

        public Cliente GetClienteByName(string nombre)
        {
            var cliente = _clienteRepository.GetClienteByName(nombre);
            return cliente;
        }

        public async Task<IEnumerable<ClienteDTO>> GetClientes()
        {
            var clientes = await _clienteRepository.GetAll();
            var clientesDTO = clientes.Select(x => _mapper.Map<ClienteDTO>(x));
            return clientesDTO;
        }

        public async Task UpdateCliente(int id, ClienteDTO cliente)
        {
            var clienteDb = _mapper.Map<Cliente>(cliente);
            clienteDb.Id = id;
            await _clienteRepository.Update(clienteDb);
        }
    }
}
