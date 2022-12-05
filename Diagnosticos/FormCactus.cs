using Diagnosticos.Models;


namespace Diagnosticos
{
    public partial class FormCactus : Form
    {
        public FormCactus()
        {
            InitializeComponent();
            this.setSiguientePregunta();
            this.darDiagnostico();
        }

        private void Respuesta_Click(object sender, EventArgs e)
        {
            if (!Program.diagnosticocac.terminado)
            {
                string respuesta = ((Button)sender).Text;
                switch (respuesta)
                {
                    case "SI":
                        this.setRespuesta(true);
                        break;
                    case "NO":
                        this.setRespuesta(false);
                        break;
                }

                this.setSiguientePregunta();
            }

            this.darDiagnostico();
        }

        private void darDiagnostico()
        {
            if (Program.diagnosticocac.terminado)
            {
                lblPregunta.Text = "Ya no hay mas preguntas...";
                lblDescripcionPregunta.Text = string.Empty;
                lblDiagnostico.Text = Program.diagnosticocac.getDiagnosticoCactus();
            }
            else
            {
                lblDiagnostico.Text = "";
            }
        }

        private void setRespuesta(bool respuesta)
        {
            if (Program.diagnosticocac.esGrupo)
            {
                Program.diagnosticocac.addRespuestaGrupoCac(Program.diagnosticocac.grupoActual, respuesta);
                Program.diagnosticocac.esGrupo = !respuesta;
            }
            else
            {
                Program.diagnosticocac.addRespuestaSintomaCac(Program.diagnosticocac.preguntaActual, respuesta);
                Program.diagnosticocac.esGrupo = false;
            }
        }

        private void setSiguientePregunta()
        {
            if (!Program.diagnosticocac.terminado)
            {
                if (Program.diagnosticocac.esGrupo)
                {
                    List<Grupo> grupos = Program.database.Grupos.ToList();
                    this.setPreguntaGrupo(grupos.FirstOrDefault(g => !Program.diagnosticocac.respuestasGrupos.ContainsKey(g.GrupoId)));
                }
                else
                {
                    List<Sintomascac> sintomas = Program.database.Sintomascacs.ToList();
                    bool valido = this.setPreguntaSintoma(sintomas.FirstOrDefault(
                        s => !Program.diagnosticocac.respuestasSintomas.ContainsKey(s.SintomaCacId) &&
                        s.GrupoId.Equals(Program.diagnosticocac.grupoActual)));

                    if (!valido)
                    {
                        Program.diagnosticocac.esGrupo = true;
                        this.setSiguientePregunta();
                    }
                }
            }
        }

        private void setPreguntaGrupo(Grupo pregunta)
        {
            if (pregunta == null)
            {
                // TODO: Terminar y dar diagnostico final...
                lblPregunta.Text = "Ya no hay mas preguntas...";
                lblDescripcionPregunta.Text = string.Empty;
                Program.diagnosticocac.terminado = true;
                return;
            }

            Program.diagnosticocac.grupoActual = pregunta.GrupoId;
            Program.diagnosticocac.esGrupo = true;

            lblPregunta.Text = $"¿Tu planta tiene problemas de {pregunta.Nombre}? (Grupo)";
            lblDescripcionPregunta.Text = $"Descripcion {pregunta.Nombre}: {pregunta.Descripcion}";
        }

        private bool setPreguntaSintoma(Sintomascac pregunta)
        {
            if (pregunta == null)
            {
                return false;
            }
            else
            {
                Program.diagnosticocac.preguntaActual = pregunta.SintomaCacId;
                Program.diagnosticocac.esGrupo = false;

                lblPregunta.Text = $"¿Tu planta tiene {pregunta.Nombre}? (Síntoma)";
                lblDescripcionPregunta.Text = $"Descripcion {pregunta.Nombre}: {pregunta.Descripcion}";
                return true;
            }
        }
    }
}
