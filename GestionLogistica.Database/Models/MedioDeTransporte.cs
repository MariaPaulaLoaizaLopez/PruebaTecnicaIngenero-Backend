using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class MedioDeTransporte
{
    public int Id { get; set; }

    public DateTime FechaDeIngreso { get; set; }

    public string Estado { get; set; } = null!;

    public int IdTipo { get; set; }

    public string MatriculaTransporte { get; set; } = null!;

    public virtual TipoDeMedioDeTransporte IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<PlanDeEntrega> PlanDeEntregas { get; set; } = new List<PlanDeEntrega>();
}
