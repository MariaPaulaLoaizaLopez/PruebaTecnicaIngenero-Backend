using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.Models
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        [Required]
        public int Dni { get; set; }

        public string Nombre { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string Telefono { get; set; } = null!;
    }
}
