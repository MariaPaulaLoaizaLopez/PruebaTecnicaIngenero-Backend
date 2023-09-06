using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface
{
    public interface IAlmacenamientoService
    {
        Task<IEnumerable<Almacenamiento>> GetAlmacenamientos();
        Task<Almacenamiento> GetAlmacenamiento(int id);
        Task AddAlmacenamiento(AlmacenamientoDTO almacenamiento);
        Task UpdateAlmacenamiento(AlmacenamientoDTO almacenamiento);
        Task DeleteAlmacenamiento(int id);
        Almacenamiento GetAlmacenamientoByRazonSocial(string razonSocial);
    }
}
