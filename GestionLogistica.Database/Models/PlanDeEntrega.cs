using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class PlanDeEntrega
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

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Almacenamiento IdLugarEntregaNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual MedioDeTransporte IdTransporteNavigation { get; set; } = null!;
}
