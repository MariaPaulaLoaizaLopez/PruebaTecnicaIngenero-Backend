using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class TipoDeMedioDeTransporte
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<MedioDeTransporte> MedioDeTransportes { get; set; } = new List<MedioDeTransporte>();
}
