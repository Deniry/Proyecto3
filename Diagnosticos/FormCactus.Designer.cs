namespace Diagnosticos
{
    partial class FormCactus
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
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.lblDescripcionPregunta = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiagnostico.Location = new System.Drawing.Point(25, 236);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(700, 504);
            this.lblDiagnostico.TabIndex = 9;
            this.lblDiagnostico.Text = "label1";
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(25, 191);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(100, 30);
            this.btnNO.TabIndex = 8;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.Respuesta_Click);
            // 
            // btnSI
            // 
            this.btnSI.Location = new System.Drawing.Point(25, 151);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(100, 30);
            this.btnSI.TabIndex = 7;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = true;
            this.btnSI.Click += new System.EventHandler(this.Respuesta_Click);
            // 
            // lblDescripcionPregunta
            // 
            this.lblDescripcionPregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcionPregunta.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionPregunta.Location = new System.Drawing.Point(25, 71);
            this.lblDescripcionPregunta.Name = "lblDescripcionPregunta";
            this.lblDescripcionPregunta.Size = new System.Drawing.Size(700, 60);
            this.lblDescripcionPregunta.TabIndex = 6;
            this.lblDescripcionPregunta.Text = "Descripcion:";
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(25, 11);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(700, 60);
            this.lblPregunta.TabIndex = 5;
            this.lblPregunta.Text = "¿?";
            // 
            // FormCactus
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
            this.Name = "FormCactus";
            this.Text = "FormPlantasDiagnostico";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblDiagnostico;
        private Button btnNO;
        private Button btnSI;
        private Label lblDescripcionPregunta;
        private Label lblPregunta;
    }
}