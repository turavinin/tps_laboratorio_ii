
namespace SistemasForms
{
    partial class ConexionForm
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
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnStringAceptar = new System.Windows.Forms.Button();
            this.btnConnStringCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(59, 81);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(325, 27);
            this.txtConnString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el connection string:";
            // 
            // btnConnStringAceptar
            // 
            this.btnConnStringAceptar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnStringAceptar.Location = new System.Drawing.Point(59, 120);
            this.btnConnStringAceptar.Name = "btnConnStringAceptar";
            this.btnConnStringAceptar.Size = new System.Drawing.Size(325, 40);
            this.btnConnStringAceptar.TabIndex = 2;
            this.btnConnStringAceptar.Text = "ACEPTAR";
            this.btnConnStringAceptar.UseVisualStyleBackColor = true;
            this.btnConnStringAceptar.Click += new System.EventHandler(this.btnConnStringAceptar_Click);
            // 
            // btnConnStringCancelar
            // 
            this.btnConnStringCancelar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnStringCancelar.Location = new System.Drawing.Point(59, 166);
            this.btnConnStringCancelar.Name = "btnConnStringCancelar";
            this.btnConnStringCancelar.Size = new System.Drawing.Size(325, 45);
            this.btnConnStringCancelar.TabIndex = 3;
            this.btnConnStringCancelar.Text = "CANCELAR";
            this.btnConnStringCancelar.UseVisualStyleBackColor = true;
            this.btnConnStringCancelar.Click += new System.EventHandler(this.btnConnStringCancelar_Click);
            // 
            // ConexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 267);
            this.ControlBox = false;
            this.Controls.Add(this.btnConnStringCancelar);
            this.Controls.Add(this.btnConnStringAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConexionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnStringAceptar;
        private System.Windows.Forms.Button btnConnStringCancelar;
    }
}