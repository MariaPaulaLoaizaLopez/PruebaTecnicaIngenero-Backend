using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.Models
{
    public class MedioDeTransporteDTO
    {
        public int Id { get; set; }

        public DateTime FechaDeIngreso { get; set; }

        public string Estado { get; set; } = null!;

        public int IdTipo { get; set; }

        public string MatriculaTransporte { get; set; } = null!;
    }
}
