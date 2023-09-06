using System;
using System.Collections.Generic;

namespace GestionLogistica.Database.Models;

public partial class TipoDeAlmacenamiento
{
    public int Id { get; set; }

    public string NombreDelTipo { get; set; } = null!;

    public virtual ICollection<Almacenamiento> Almacenamientos { get; set; } = new List<Almacenamiento>();
}
