using GestionLogistica.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Database.Repositories.Interfaces
{
    public interface IAlmacenamientoRepository : IGenericRepository<Almacenamiento>
    {
        Almacenamiento GetAlmacenamientoByRazonSocial(string razonSocial);
    }
}
