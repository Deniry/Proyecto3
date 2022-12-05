using Diagnosticos.Models;
using System.Runtime.InteropServices;

namespace Diagnosticos
{
    public partial class FormPlantasDiagnostico : Form
    {
        bool suculenta;

        public FormPlantasDiagnostico()
        {
            InitializeComponent();
            suculenta = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panNavegacion.Height = btnSuculentas.Height;
            panNavegacion.Top = btnSuculentas.Top;
            panNavegacion.Left = btnSuculentas.Left;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnSuculentas_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnSuculentas.Height;
            panNavegacion.Top = btnSuculentas.Top;
            panNavegacion.Left = btnSuculentas.Left;
            btnSuculentas.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            suculenta = true;

            FormSuculentas suculentas = new FormSuculentas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(suculentas);
            suculentas.Show();
        }

        private void btnCactus_Click(object sender, EventArgs e)
        {
            panNavegacion.Height = btnCactus.Height;
            panNavegacion.Top = btnCactus.Top;
            panNavegacion.Left = btnCactus.Left;
            btnCactus.BackColor = Color.FromArgb(46, 51, 73);
            this.pnlPantalla.Controls.Clear();

            suculenta = false;

            FormCactus cactus = new FormCactus { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
            this.pnlPantalla.Controls.Add(cactus);
            cactus.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOpcion_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNuevoDiagnostico_Click(object sender, EventArgs e)
        {
            Program.diagnostico = new();
            Program.diagnosticocac = new();

            if (suculenta)
            {
                this.btnSuculentas_Click(sender, e);
            }
            else
            {
                this.btnCactus_Click(sender, e);
            }
        }
    }
}