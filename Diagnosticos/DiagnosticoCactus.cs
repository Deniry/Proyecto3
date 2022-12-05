using Diagnosticos.Models;
using Microsoft.EntityFrameworkCore;

namespace Diagnosticos
{
    public class DiagnosticoCactus
    {
        public bool esGrupo;
        public Guid preguntaActual;
        public Guid grupoActual;
        public bool terminado;

        public Dictionary<Guid, bool> respuestasGrupos;
        public Dictionary<Guid, bool> respuestasSintomas;

        public DiagnosticoCactus()
        {
            esGrupo = true;
            terminado = false;
            preguntaActual = Guid.Empty;
            grupoActual = Guid.Empty;

            respuestasGrupos = new Dictionary<Guid, bool>();
            respuestasSintomas = new Dictionary<Guid, bool>();
        }

        public void addRespuestaGrupoCac(Guid grupoId, bool respuesta)
        {
            if (!respuestasGrupos.ContainsKey(grupoId) && grupoId != Guid.Empty)
            {
                respuestasGrupos.Add(grupoId, respuesta);
            }
        }

        public void addRespuestaSintomaCac(Guid sintomaId, bool respuesta)
        {
            if (!respuestasSintomas.ContainsKey(sintomaId) && sintomaId != Guid.Empty)
            {
                respuestasSintomas.Add(sintomaId, respuesta);
            }
        }

        public string getDiagnosticoCactus()
        { 
            List<Guid> sintomas = (from respuestas in respuestasSintomas.Where(s => s.Value) select respuestas.Key).ToList();

            List<Enfermedade> enfermedades = (from enfermedad in Program.database.Enfermedades.Include(e => e.Cuidados)
                                              join sintoma in Program.database.Sintomascacs on enfermedad.EnfermedadId equals sintoma.EnfermedadId
                                              where sintomas.Contains(sintoma.SintomaCacId)
                                              select enfermedad).Distinct().ToList();

            string diagnostico = string.Empty;
            foreach (Enfermedade enfermedad in enfermedades)
            {
                int sintomasEnfermedad = Program.database.Sintomascacs.Where(s => sintomas.Contains(s.SintomaCacId) && s.EnfermedadId.Equals(enfermedad.EnfermedadId)).ToList().Count;
                diagnostico = $"{diagnostico}{Environment.NewLine}Tu planta tiene {enfermedad.Nombre}, caracterizado por {enfermedad.Descripcion}, " +
                    $"{Environment.NewLine}     Este resultado es {(sintomasEnfermedad * 100) / sintomas.Count}% probable" +
                    $"{Environment.NewLine}     Cuidados a tomar:";

                foreach(Cuidado cuidado in enfermedad.Cuidados)
                {
                    diagnostico = $"{diagnostico}{Environment.NewLine}          -{cuidado.Descripcion}";
                }
            }

            return diagnostico;
        }
    }
}
