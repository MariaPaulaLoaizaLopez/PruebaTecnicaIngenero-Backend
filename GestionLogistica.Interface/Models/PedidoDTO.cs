using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.Models
{
    public class PedidoDTO
    {
        public int Id { get; set; }

        public int IdProducto { get; set; }

        public int CantidadDeProducto { get; set; }

        public decimal PrecioTotal { get; set; }

        public int IdDescuento { get; set; }

        public decimal? PrecioConDescuento { get; set; }

    }
}
