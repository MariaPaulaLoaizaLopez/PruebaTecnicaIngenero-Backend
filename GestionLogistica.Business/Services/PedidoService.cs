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
    public class PedidoService : IPedidoService
    {
        private readonly IMapper _mapper;

        private IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            this._mapper = mapper;
        }
        public async Task AddPedido(PedidoDTO pedido)
        {
            var pedidoDb = _mapper.Map<Pedido>(pedido);
            await _pedidoRepository.Insert(pedidoDb);
        }

        public async Task DeletePedido(int id)
        {
            await _pedidoRepository.Delete(id);
        }

        public async Task<Pedido> GetPedido(int id)
        {
            return await _pedidoRepository.GetByID(id);
        }

        public Pedido GetPedidoByProducto(string nombreProducto)
        {
            return _pedidoRepository.GetPedidoByProducto(nombreProducto);
        }

        public async Task<IEnumerable<Pedido>> GetPedidos()
        {
            return await _pedidoRepository.GetAll();
        }

        public async Task UpdatePedido(PedidoDTO pedido)
        {
            var pedidoDb = _mapper.Map<Pedido>(pedido);
            await _pedidoRepository.Update(pedidoDb);
        }
    }
}
