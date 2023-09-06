using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class Descuento
{
    public int Id { get; set; }

    public int NumeroDeUnidadesMinimas { get; set; }

    public int PorcentajeDeDescuento { get; set; }

    public string TipoDeLogistica { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
