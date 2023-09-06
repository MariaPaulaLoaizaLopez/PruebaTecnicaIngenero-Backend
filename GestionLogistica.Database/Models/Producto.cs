using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Stock { get; set; }

    public decimal PrecioUnidad { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
