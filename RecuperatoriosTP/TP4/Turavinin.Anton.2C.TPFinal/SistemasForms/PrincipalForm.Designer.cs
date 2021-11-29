
namespace SistemasForms
{
    partial class PrincipalForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnPrincipalPersona = new System.Windows.Forms.Button();
            this.btnPrincipalResultados = new System.Windows.Forms.Button();
            this.btnPrincipalRoles = new System.Windows.Forms.Button();
            this.btnPrincipalBase = new System.Windows.Forms.Button();
            this.radioConexionBase = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblTituloPrincipal);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPrincipal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(292, 23);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(396, 43);
            this.lblTituloPrincipal.TabIndex = 1;
            this.lblTituloPrincipal.Text = "ENCUESTA SISTEMAS 2021";
            // 
            // btnPrincipalPersona
            // 
            this.btnPrincipalPersona.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrincipalPersona.Location = new System.Drawing.Point(333, 243);
            this.btnPrincipalPersona.Name = "btnPrincipalPersona";
            this.btnPrincipalPersona.Size = new System.Drawing.Size(307, 59);
            this.btnPrincipalPersona.TabIndex = 2;
            this.btnPrincipalPersona.Text = "PERSONAS";
            this.btnPrincipalPersona.UseVisualStyleBackColor = true;
            this.btnPrincipalPersona.Click += new System.EventHandler(this.btnPrincipalPersona_Click);
            // 
            // btnPrincipalResultados
            // 
            this.btnPrincipalResultados.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrincipalResultados.Location = new System.Drawing.Point(268, 148);
            this.btnPrincipalResultados.Name = "btnPrincipalResultados";
            this.btnPrincipalResultados.Size = new System.Drawing.Size(445, 79);
            this.btnPrincipalResultados.TabIndex = 1;
            this.btnPrincipalResultados.Text = "VER RESULTADOS";
            this.btnPrincipalResultados.UseVisualStyleBackColor = true;
            this.btnPrincipalResultados.Click += new System.EventHandler(this.btnPrincipalResultados_Click);
            // 
            // btnPrincipalRoles
            // 
            this.btnPrincipalRoles.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrincipalRoles.Location = new System.Drawing.Point(333, 308);
            this.btnPrincipalRoles.Name = "btnPrincipalRoles";
            this.btnPrincipalRoles.Size = new System.Drawing.Size(307, 62);
            this.btnPrincipalRoles.TabIndex = 3;
            this.btnPrincipalRoles.Text = "ROLES";
            this.btnPrincipalRoles.UseVisualStyleBackColor = true;
            this.btnPrincipalRoles.Click += new System.EventHandler(this.btnPrincipalRoles_Click);
            // 
            // btnPrincipalBase
            // 
            this.btnPrincipalBase.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrincipalBase.Location = new System.Drawing.Point(333, 376);
            this.btnPrincipalBase.Name = "btnPrincipalBase";
            this.btnPrincipalBase.Size = new System.Drawing.Size(307, 62);
            this.btnPrincipalBase.TabIndex = 4;
            this.btnPrincipalBase.Text = "CONECTAR A BASE";
            this.btnPrincipalBase.UseVisualStyleBackColor = true;
            this.btnPrincipalBase.Click += new System.EventHandler(this.btnPrincipalBase_Click);
            // 
            // radioConexionBase
            // 
            this.radioConexionBase.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioConexionBase.AutoSize = true;
            this.radioConexionBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(19)))), ((int)(((byte)(12)))));
            this.radioConexionBase.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioConexionBase.Checked = true;
            this.radioConexionBase.Enabled = false;
            this.radioConexionBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioConexionBase.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioConexionBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioConexionBase.Location = new System.Drawing.Point(813, 447);
            this.radioConexionBase.Name = "radioConexionBase";
            this.radioConexionBase.Size = new System.Drawing.Size(158, 35);
            this.radioConexionBase.TabIndex = 8;
            this.radioConexionBase.TabStop = true;
            this.radioConexionBase.Text = "CONEXION A BASE";
            this.radioConexionBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioConexionBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioConexionBase.UseVisualStyleBackColor = false;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(983, 494);
            this.Controls.Add(this.radioConexionBase);
            this.Controls.Add(this.btnPrincipalBase);
            this.Controls.Add(this.btnPrincipalRoles);
            this.Controls.Add(this.btnPrincipalResultados);
            this.Controls.Add(this.btnPrincipalPersona);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuesta Sistemas 2021";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnPrincipalPersona;
        private System.Windows.Forms.Button btnPrincipalResultados;
        private System.Windows.Forms.Button btnPrincipalRoles;
        private System.Windows.Forms.Button btnPrincipalBase;
        private System.Windows.Forms.RadioButton radioConexionBase;
    }
}