using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.Models
{
    public class ProductoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public int Stock { get; set; }

        public decimal PrecioUnidad { get; set; }
    }
}
