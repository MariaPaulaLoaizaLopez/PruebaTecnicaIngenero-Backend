using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public int Dni { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public virtual ICollection<PlanDeEntrega> PlanDeEntregas { get; set; } = new List<PlanDeEntrega>();
}
