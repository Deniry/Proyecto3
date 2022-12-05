using System;
using System.Collections.Generic;

namespace Diagnosticos.Models;

public partial class Cuidado
{
    public Guid CuidadosId { get; set; }

    public Guid EnfermedadId { get; set; }

    public string? Descripcion { get; set; }

    public virtual Enfermedade Enfermedad { get; set; } = null!;
}
