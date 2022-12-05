namespace Diagnosticos
{
    partial class FormSuculentas
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblDescripcionPregunta = new System.Windows.Forms.Label();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(20, 20);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(700, 60);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¿?";
            // 
            // lblDescripcionPregunta
            // 
            this.lblDescripcionPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionPregunta.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionPregunta.Location = new System.Drawing.Point(20, 80);
            this.lblDescripcionPregunta.Name = "lblDescripcionPregunta";
            this.lblDescripcionPregunta.Size = new System.Drawing.Size(700, 60);
            this.lblDescripcionPregunta.TabIndex = 1;
            this.lblDescripcionPregunta.Text = "Descripcion:";
            // 
            // btnSI
            // 
            this.btnSI.Location = new System.Drawing.Point(20, 160);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(100, 30);
            this.btnSI.TabIndex = 2;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.Respuesta_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(20, 200);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(100, 30);
            this.btnNO.TabIndex = 3;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.Respuesta_Click);
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiagnostico.Location = new System.Drawing.Point(20, 243);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(700, 498);
            this.lblDiagnostico.TabIndex = 4;
            this.lblDiagnostico.Text = "label1";
            // 
            // FormSuculentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.lblDescripcionPregunta);
            this.Controls.Add(this.lblPregunta);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSuculentas";
            this.Text = "FormPlantas Diagnostico";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblPregunta;
        private Label lblDescripcionPregunta;
        private Button btnSI;
        private Button btnNO;
        private Label lblDiagnostico;
    }
}