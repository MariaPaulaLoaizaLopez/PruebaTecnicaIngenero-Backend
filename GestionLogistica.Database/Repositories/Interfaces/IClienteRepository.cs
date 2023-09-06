using GestionLogistica.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Database.Repositories.Interfaces
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        Cliente GetClienteByDNI(int dni);
        Cliente GetClienteByName(string nombre);
    }
}
