using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Interface.Models
{
    public class PlanDeEntregaDTO
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        public DateTime FechaDeEntrega { get; set; }

        public int IdLugarEntrega { get; set; }

        public decimal PrecioDeEnvio { get; set; }

        public int IdTransporte { get; set; }

        public int NumeroDeGuia { get; set; }

        public int IdCliente { get; set; }

    }
}
