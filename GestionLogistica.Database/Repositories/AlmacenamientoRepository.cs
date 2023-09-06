using GestionLogistica.Database.Context;
using GestionLogistica.Database.Models;
using GestionLogistica.Database.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Database.Repositories
{
    public class AlmacenamientoRepository : GenericRepository<Almacenamiento>, IAlmacenamientoRepository
    {
        private readonly GestionLogisticaContext _context;

        public AlmacenamientoRepository(GestionLogisticaContext context): base(context)
        {
            _context = context;
        }
        public Almacenamiento GetAlmacenamientoByRazonSocial(string razonSocial)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAlmacenamientoAsync(Almacenamiento almacenamiento)
        {
            var tipo = InsertTipoAlmacenamiento(almacenamiento.IdTipoNavigation.NombreDelTipo);
            almacenamiento.IdTipoNavigation = tipo;
            await Insert(almacenamiento);
        }

        public TipoDeAlmacenamiento InsertTipoAlmacenamiento(string NombreTipo)
        {
            var tipoAlmacenamiento = new TipoDeAlmacenamiento();
            tipoAlmacenamiento.NombreDelTipo = NombreTipo;
            _context.Set<TipoDeAlmacenamiento>().Add(tipoAlmacenamiento);
            _context.SaveChanges();
            return tipoAlmacenamiento;
        }
    }
}
