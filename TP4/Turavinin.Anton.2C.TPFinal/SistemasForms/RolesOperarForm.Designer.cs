
namespace SistemasForms
{
    partial class RolesOperarForm
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
            this.btnCancelarCambioRol = new System.Windows.Forms.Button();
            this.btnAceptarCambioRol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescRol = new System.Windows.Forms.TextBox();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarCambioRol
            // 
            this.btnCancelarCambioRol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCambioRol.Location = new System.Drawing.Point(15, 129);
            this.btnCancelarCambioRol.Name = "btnCancelarCambioRol";
            this.btnCancelarCambioRol.Size = new System.Drawing.Size(370, 29);
            this.btnCancelarCambioRol.TabIndex = 11;
            this.btnCancelarCambioRol.Text = "CANCELAR";
            this.btnCancelarCambioRol.UseVisualStyleBackColor = true;
            this.btnCancelarCambioRol.Click += new System.EventHandler(this.btnCancelarCambioRol_Click);
            // 
            // btnAceptarCambioRol
            // 
            this.btnAceptarCambioRol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarCambioRol.Location = new System.Drawing.Point(15, 94);
            this.btnAceptarCambioRol.Name = "btnAceptarCambioRol";
            this.btnAceptarCambioRol.Size = new System.Drawing.Size(370, 29);
            this.btnAceptarCambioRol.TabIndex = 10;
            this.btnAceptarCambioRol.Text = "ACEPTAR";
            this.btnAceptarCambioRol.UseVisualStyleBackColor = true;
            this.btnAceptarCambioRol.Click += new System.EventHandler(this.btnAceptarCambioRol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(111, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // txtDescRol
            // 
            this.txtDescRol.Location = new System.Drawing.Point(111, 44);
            this.txtDescRol.Name = "txtDescRol";
            this.txtDescRol.Size = new System.Drawing.Size(274, 27);
            this.txtDescRol.TabIndex = 7;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Enabled = false;
            this.txtIdRol.Location = new System.Drawing.Point(15, 44);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.ReadOnly = true;
            this.txtIdRol.Size = new System.Drawing.Size(90, 27);
            this.txtIdRol.TabIndex = 6;
            // 
            // RolesOperarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(400, 186);
            this.Controls.Add(this.btnCancelarCambioRol);
            this.Controls.Add(this.btnAceptarCambioRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescRol);
            this.Controls.Add(this.txtIdRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RolesOperarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesOperarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCambioRol;
        private System.Windows.Forms.Button btnAceptarCambioRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescRol;
        private System.Windows.Forms.TextBox txtIdRol;
    }
}