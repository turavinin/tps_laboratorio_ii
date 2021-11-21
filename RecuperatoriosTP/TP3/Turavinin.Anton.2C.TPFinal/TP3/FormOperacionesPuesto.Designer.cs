
namespace TP3
{
    partial class FormOperacionesPuesto
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
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.txtDescPuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarCambioPuesto = new System.Windows.Forms.Button();
            this.btnCancelarCambioPuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Location = new System.Drawing.Point(12, 50);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.ReadOnly = true;
            this.txtIdPuesto.Size = new System.Drawing.Size(90, 27);
            this.txtIdPuesto.TabIndex = 0;
            // 
            // txtDescPuesto
            // 
            this.txtDescPuesto.Location = new System.Drawing.Point(108, 50);
            this.txtDescPuesto.Name = "txtDescPuesto";
            this.txtDescPuesto.Size = new System.Drawing.Size(274, 27);
            this.txtDescPuesto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puesto";
            // 
            // btnAceptarCambioPuesto
            // 
            this.btnAceptarCambioPuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarCambioPuesto.Location = new System.Drawing.Point(12, 100);
            this.btnAceptarCambioPuesto.Name = "btnAceptarCambioPuesto";
            this.btnAceptarCambioPuesto.Size = new System.Drawing.Size(370, 29);
            this.btnAceptarCambioPuesto.TabIndex = 4;
            this.btnAceptarCambioPuesto.Text = "ACEPTAR";
            this.btnAceptarCambioPuesto.UseVisualStyleBackColor = true;
            this.btnAceptarCambioPuesto.Click += new System.EventHandler(this.btnAceptarCambioPuesto_Click);
            // 
            // btnCancelarCambioPuesto
            // 
            this.btnCancelarCambioPuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCambioPuesto.Location = new System.Drawing.Point(12, 135);
            this.btnCancelarCambioPuesto.Name = "btnCancelarCambioPuesto";
            this.btnCancelarCambioPuesto.Size = new System.Drawing.Size(370, 29);
            this.btnCancelarCambioPuesto.TabIndex = 5;
            this.btnCancelarCambioPuesto.Text = "CANCELAR";
            this.btnCancelarCambioPuesto.UseVisualStyleBackColor = true;
            this.btnCancelarCambioPuesto.Click += new System.EventHandler(this.btnCancelarCambioPuesto_Click);
            // 
            // FormOperacionesPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 181);
            this.Controls.Add(this.btnCancelarCambioPuesto);
            this.Controls.Add(this.btnAceptarCambioPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescPuesto);
            this.Controls.Add(this.txtIdPuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOperacionesPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Puesto";
            this.Load += new System.EventHandler(this.FormOperacionesPuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.TextBox txtDescPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarCambioPuesto;
        private System.Windows.Forms.Button btnCancelarCambioPuesto;
    }
}