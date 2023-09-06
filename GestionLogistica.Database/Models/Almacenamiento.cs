using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class Almacenamiento
{
    public int Id { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string Representante { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int IdTipo { get; set; }

    public string Pais { get; set; } = null!;

    public virtual TipoDeAlmacenamiento IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<PlanDeEntrega> PlanDeEntregas { get; set; } = new List<PlanDeEntrega>();
}
