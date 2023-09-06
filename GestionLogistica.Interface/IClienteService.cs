using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDTO>> GetClientes();
        Task<ClienteDTO> GetCliente(int id);
        Task AddCliente(ClienteDTO cliente);
        Task UpdateCliente(int id, ClienteDTO cliente);
        Task DeleteCliente(int id);
        Cliente GetClienteByDNI(int dni);
        Cliente GetClienteByName(string nombre);
    }
}
