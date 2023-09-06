using GestionLogistica.Database.Models;
using GestionLogistica.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface
{
    public interface IMedioDeTransporteService
    {
        Task<IEnumerable<MedioDeTransporte>> GetMediosDeTransporte();
        Task<MedioDeTransporte> GetMedioDeTransporte(int id);
        Task AddMedioDeTransporte(MedioDeTransporteDTO medioDeTransporte);
        Task UpdateMedioDeTransporte(MedioDeTransporteDTO medioDeTransporte);
        Task DeleteMedioDeTransporte(int id);
        MedioDeTransporte GetMedioDeTransporteByName(string nombre);
    }
}
