using GestionLogistica.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.Models
{
    public class AlmacenamientoDTO
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; } = null!;

        public string Representante { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public int IdTipo { get; set; }

        public string Pais { get; set; } = null!;
    }
}
