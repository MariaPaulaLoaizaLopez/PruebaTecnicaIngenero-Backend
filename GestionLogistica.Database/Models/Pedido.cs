using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public int CantidadDeProducto { get; set; }

    public decimal PrecioTotal { get; set; }

    public int IdDescuento { get; set; }

    public decimal? PrecioConDescuento { get; set; }

    public virtual Descuento IdDescuentoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual ICollection<PlanDeEntrega> PlanDeEntregas { get; set; } = new List<PlanDeEntrega>();
}
