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
    public class ProductoService : IProductoService
    {
        private readonly IMapper _mapper;

        private IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            this._mapper = mapper;
        }
        public async Task AddProducto(ProductoDTO producto)
        {
            var productoDb = _mapper.Map<Producto>(producto);
            await _productoRepository.Insert(productoDb);
        }

        public async Task DeleteProducto(int id)
        {
            await _productoRepository.Delete(id);
        }

        public async Task<Producto> GetProducto(int id)
        {
            return await _productoRepository.GetByID(id);
        }

        public async Task<IEnumerable<Producto>> GetProductos()
        {
            return await _productoRepository.GetAll();
        }

        public async Task UpdateProducto(ProductoDTO producto)
        {
            var productoDb = _mapper.Map<Producto>(producto);
            await _productoRepository.Update(productoDb);
        }
    }
}
