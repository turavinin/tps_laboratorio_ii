
namespace SistemasForms
{
    partial class RolesForm
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
            this.lblListaRoles = new System.Windows.Forms.Label();
            this.dgvListaRoles = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaRoles
            // 
            this.lblListaRoles.AutoSize = true;
            this.lblListaRoles.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListaRoles.Location = new System.Drawing.Point(30, 27);
            this.lblListaRoles.Name = "lblListaRoles";
            this.lblListaRoles.Size = new System.Drawing.Size(83, 31);
            this.lblListaRoles.TabIndex = 5;
            this.lblListaRoles.Text = "ROLES";
            // 
            // dgvListaRoles
            // 
            this.dgvListaRoles.AllowUserToAddRows = false;
            this.dgvListaRoles.AllowUserToDeleteRows = false;
            this.dgvListaRoles.AllowUserToResizeColumns = false;
            this.dgvListaRoles.AllowUserToResizeRows = false;
            this.dgvListaRoles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Puesto});
            this.dgvListaRoles.Location = new System.Drawing.Point(30, 61);
            this.dgvListaRoles.MultiSelect = false;
            this.dgvListaRoles.Name = "dgvListaRoles";
            this.dgvListaRoles.ReadOnly = true;
            this.dgvListaRoles.RowHeadersVisible = false;
            this.dgvListaRoles.RowHeadersWidth = 51;
            this.dgvListaRoles.RowTemplate.Height = 29;
            this.dgvListaRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRoles.Size = new System.Drawing.Size(561, 229);
            this.dgvListaRoles.TabIndex = 6;
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
            // btnAgregarRol
            // 
            this.btnAgregarRol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarRol.Location = new System.Drawing.Point(30, 295);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(166, 52);
            this.btnAgregarRol.TabIndex = 7;
            this.btnAgregarRol.Text = "AGREGAR ROL";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarRol.Location = new System.Drawing.Point(228, 296);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(166, 51);
            this.btnEditarRol.TabIndex = 8;
            this.btnEditarRol.Text = "EDITAR ROL";
            this.btnEditarRol.UseVisualStyleBackColor = true;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarRol.Location = new System.Drawing.Point(425, 296);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(166, 51);
            this.btnEliminarRol.TabIndex = 9;
            this.btnEliminarRol.Text = "ELIMINAR ROL";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(623, 374);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.dgvListaRoles);
            this.Controls.Add(this.lblListaRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RolesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaRoles;
        private System.Windows.Forms.DataGridView dgvListaRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnEliminarRol;
    }
}