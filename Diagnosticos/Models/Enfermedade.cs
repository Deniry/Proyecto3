using System;
using System.Collections.Generic;

namespace Diagnosticos.Models;

public partial class Enfermedade
{
    public Guid EnfermedadId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Cuidado> Cuidados { get; } = new List<Cuidado>();

    public virtual ICollection<Sintomascac> Sintomascacs { get; } = new List<Sintomascac>();

    public virtual ICollection<Sintomassucu> Sintomassucus { get; } = new List<Sintomassucu>();
}
