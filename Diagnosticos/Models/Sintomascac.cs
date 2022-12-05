using System;
using System.Collections.Generic;

namespace Diagnosticos.Models;

public partial class Sintomascac
{
    public Guid SintomaCacId { get; set; }

    public Guid EnfermedadId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public Guid? GrupoId { get; set; }

    public virtual Enfermedade Enfermedad { get; set; } = null!;

    public virtual Grupo? Grupo { get; set; }
}
