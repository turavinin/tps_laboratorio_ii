
namespace TP3
{
    partial class FormConfiguracion
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
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaPuestos = new System.Windows.Forms.Label();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.btnEditarPuesto = new System.Windows.Forms.Button();
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AllowUserToAddRows = false;
            this.dgvPuestos.AllowUserToDeleteRows = false;
            this.dgvPuestos.AllowUserToResizeColumns = false;
            this.dgvPuestos.AllowUserToResizeRows = false;
            this.dgvPuestos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Puesto});
            this.dgvPuestos.Location = new System.Drawing.Point(34, 61);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.ReadOnly = true;
            this.dgvPuestos.RowHeadersVisible = false;
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.RowTemplate.Height = 29;
            this.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestos.Size = new System.Drawing.Size(561, 229);
            this.dgvPuestos.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Puesto
            // 
            this.Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblListaPuestos
            // 
            this.lblListaPuestos.AutoSize = true;
            this.lblListaPuestos.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaPuestos.Location = new System.Drawing.Point(34, 27);
            this.lblListaPuestos.Name = "lblListaPuestos";
            this.lblListaPuestos.Size = new System.Drawing.Size(212, 31);
            this.lblListaPuestos.TabIndex = 4;
            this.lblListaPuestos.Text = "LISTA DE PUESTOS";
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.Location = new System.Drawing.Point(34, 296);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(166, 41);
            this.btnAgregarPuesto.TabIndex = 5;
            this.btnAgregarPuesto.Text = "AGREGAR PUESTO";
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // btnEditarPuesto
            // 
            this.btnEditarPuesto.Location = new System.Drawing.Point(231, 296);
            this.btnEditarPuesto.Name = "btnEditarPuesto";
            this.btnEditarPuesto.Size = new System.Drawing.Size(166, 40);
            this.btnEditarPuesto.TabIndex = 6;
            this.btnEditarPuesto.Text = "EDITAR PUESTO";
            this.btnEditarPuesto.UseVisualStyleBackColor = true;
            this.btnEditarPuesto.Click += new System.EventHandler(this.btnEditarPuesto_Click);
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.Location = new System.Drawing.Point(429, 296);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(166, 40);
            this.btnEliminarPuesto.TabIndex = 7;
            this.btnEliminarPuesto.Text = "ELIMINAR PUESTO";
            this.btnEliminarPuesto.UseVisualStyleBackColor = true;
            this.btnEliminarPuesto.Click += new System.EventHandler(this.btnEliminarPuesto_Click);
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 375);
            this.Controls.Add(this.btnEliminarPuesto);
            this.Controls.Add(this.btnEditarPuesto);
            this.Controls.Add(this.btnAgregarPuesto);
            this.Controls.Add(this.lblListaPuestos);
            this.Controls.Add(this.dgvPuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.Label lblListaPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.Button btnEditarPuesto;
        private System.Windows.Forms.Button btnEliminarPuesto;
    }
}