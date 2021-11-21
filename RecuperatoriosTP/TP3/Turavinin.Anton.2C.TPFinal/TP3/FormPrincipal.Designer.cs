
namespace TP3
{
    partial class FormPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCargaPersona = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(118, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(426, 84);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ENCUESTA PROGRAMACION\r\n2021";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCargaPersona
            // 
            this.btnCargaPersona.Location = new System.Drawing.Point(118, 279);
            this.btnCargaPersona.Name = "btnCargaPersona";
            this.btnCargaPersona.Size = new System.Drawing.Size(213, 48);
            this.btnCargaPersona.TabIndex = 1;
            this.btnCargaPersona.Text = "PERSONAS";
            this.btnCargaPersona.UseVisualStyleBackColor = true;
            this.btnCargaPersona.Click += new System.EventHandler(this.btnCargaPersona_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.Color.Honeydew;
            this.btnResultados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResultados.ForeColor = System.Drawing.Color.Black;
            this.btnResultados.Location = new System.Drawing.Point(228, 212);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(213, 61);
            this.btnResultados.TabIndex = 2;
            this.btnResultados.Text = "RESULTADOS";
            this.btnResultados.UseVisualStyleBackColor = false;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(337, 279);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(213, 48);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Text = "CONFIGURACION";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(681, 365);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnCargaPersona);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sueldos Programacion";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCargaPersona;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Button btnConfiguracion;
    }
}