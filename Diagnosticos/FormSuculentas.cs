using Diagnosticos.Models;

namespace Diagnosticos
{
    public partial class FormSuculentas : Form
    {
        public FormSuculentas()
        {
            InitializeComponent();
            this.setSiguientePregunta();
            this.darDiagnostico();
        }

        private void Respuesta_Click(object sender, EventArgs e)
        {
            if (!Program.diagnostico.terminado)
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
            if (Program.diagnostico.terminado)
            {
                lblPregunta.Text = "Ya no hay mas preguntas...";
                lblDescripcionPregunta.Text = string.Empty;
                lblDiagnostico.Text = Program.diagnostico.getDiagnosticoSuculenta();
            }
            else
            {
                lblDiagnostico.Text = "";
            }
        }

        private void setRespuesta(bool respuesta)
        {
            if (Program.diagnostico.esGrupo)
            {
                Program.diagnostico.addRespuestaGrupo(Program.diagnostico.grupoActual, respuesta);
                Program.diagnostico.esGrupo = !respuesta;
            }
            else
            {
                Program.diagnostico.addRespuestaSintoma(Program.diagnostico.preguntaActual, respuesta);
                Program.diagnostico.esGrupo = false;
            }
        }

        private void setSiguientePregunta()
        {
            if (!Program.diagnostico.terminado)
            {
                if (Program.diagnostico.esGrupo)
                {
                    List<Grupo> grupos = Program.database.Grupos.ToList();
                    this.setPreguntaGrupo(grupos.FirstOrDefault(g => !Program.diagnostico.respuestasGrupos.ContainsKey(g.GrupoId)));
                }
                else
                {
                    List<Sintomassucu> sintomas = Program.database.Sintomassucus.ToList();
                    bool valido = this.setPreguntaSintoma(sintomas.FirstOrDefault(
                        s => !Program.diagnostico.respuestasSintomas.ContainsKey(s.SintomaSucuId) &&
                        s.GrupoId.Equals(Program.diagnostico.grupoActual)));

                    if (!valido)
                    {
                        Program.diagnostico.esGrupo = true;
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
                Program.diagnostico.terminado = true;
                return;
            }

            Program.diagnostico.grupoActual = pregunta.GrupoId;
            Program.diagnostico.esGrupo = true;

            lblPregunta.Text = $"¿Tu planta tiene problemas de {pregunta.Nombre}? (Grupo)";
            lblDescripcionPregunta.Text = $"Descripcion {pregunta.Nombre}: {pregunta.Descripcion}";
        }

        private bool setPreguntaSintoma(Sintomassucu pregunta)
        {
            if (pregunta == null)
            {
                return false;
            }
            else
            {
                Program.diagnostico.preguntaActual = pregunta.SintomaSucuId;
                Program.diagnostico.esGrupo = false;

                lblPregunta.Text = $"¿Tu planta tiene {pregunta.Nombre}? (Síntoma)";
                lblDescripcionPregunta.Text = $"Descripcion {pregunta.Nombre}: {pregunta.Descripcion}";
                return true;
            }
        }
    }
}
