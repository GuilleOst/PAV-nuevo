using System.Windows.Forms;

namespace TPG6.Formularios.Promocion
{
    partial class ListaPromocion
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
            this.dgvPromocion = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarPromo = new System.Windows.Forms.Button();
            this.btnEditarPromo = new System.Windows.Forms.Button();
            this.btnEliminarPromo = new System.Windows.Forms.Button();
            this.panelBackAltaPromocion = new System.Windows.Forms.Panel();
            this.lblListaCombo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).BeginInit();
            this.panelBackAltaPromocion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPromocion
            // 
            this.dgvPromocion.AllowUserToAddRows = false;
            this.dgvPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromocion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Valor,
            this.FechaInicio,
            this.FechaFin});
            this.dgvPromocion.Location = new System.Drawing.Point(13, 74);
            this.dgvPromocion.Name = "dgvPromocion";
            this.dgvPromocion.RowTemplate.Height = 25;
            this.dgvPromocion.Size = new System.Drawing.Size(595, 158);
            this.dgvPromocion.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicio.DataPropertyName = "fechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaFin.DataPropertyName = "fechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            // 
            // btnCargarPromo
            // 
            this.btnCargarPromo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarPromo.FlatAppearance.BorderSize = 0;
            this.btnCargarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPromo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargarPromo.ForeColor = System.Drawing.Color.White;
            this.btnCargarPromo.Location = new System.Drawing.Point(45, 62);
            this.btnCargarPromo.Name = "btnCargarPromo";
            this.btnCargarPromo.Size = new System.Drawing.Size(147, 41);
            this.btnCargarPromo.TabIndex = 14;
            this.btnCargarPromo.Text = "Cargar Promo";
            this.btnCargarPromo.UseVisualStyleBackColor = false;
            this.btnCargarPromo.Click += new System.EventHandler(this.btnCargarPromo_Click);
            // 
            // btnEditarPromo
            // 
            this.btnEditarPromo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarPromo.FlatAppearance.BorderSize = 0;
            this.btnEditarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPromo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditarPromo.ForeColor = System.Drawing.Color.White;
            this.btnEditarPromo.Location = new System.Drawing.Point(205, 62);
            this.btnEditarPromo.Name = "btnEditarPromo";
            this.btnEditarPromo.Size = new System.Drawing.Size(147, 41);
            this.btnEditarPromo.TabIndex = 15;
            this.btnEditarPromo.Text = "Editar Promo";
            this.btnEditarPromo.UseVisualStyleBackColor = false;
            this.btnEditarPromo.Click += new System.EventHandler(this.btnEditarPromo_Click);
            // 
            // btnEliminarPromo
            // 
            this.btnEliminarPromo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarPromo.FlatAppearance.BorderSize = 0;
            this.btnEliminarPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPromo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPromo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPromo.Location = new System.Drawing.Point(529, 62);
            this.btnEliminarPromo.Name = "btnEliminarPromo";
            this.btnEliminarPromo.Size = new System.Drawing.Size(147, 41);
            this.btnEliminarPromo.TabIndex = 16;
            this.btnEliminarPromo.Text = "Eliminar Promo";
            this.btnEliminarPromo.UseVisualStyleBackColor = false;
            this.btnEliminarPromo.Click += new System.EventHandler(this.btnEliminarPromo_Click);
            // 
            // panelBackAltaPromocion
            // 
            this.panelBackAltaPromocion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaPromocion.Controls.Add(this.lblListaCombo);
            this.panelBackAltaPromocion.Controls.Add(this.txtBuscar);
            this.panelBackAltaPromocion.Controls.Add(this.label1);
            this.panelBackAltaPromocion.Controls.Add(this.dgvPromocion);
            this.panelBackAltaPromocion.Location = new System.Drawing.Point(45, 128);
            this.panelBackAltaPromocion.Name = "panelBackAltaPromocion";
            this.panelBackAltaPromocion.Size = new System.Drawing.Size(631, 255);
            this.panelBackAltaPromocion.TabIndex = 20;
            // 
            // lblListaCombo
            // 
            this.lblListaCombo.AutoSize = true;
            this.lblListaCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblListaCombo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListaCombo.Location = new System.Drawing.Point(405, 10);
            this.lblListaCombo.Name = "lblListaCombo";
            this.lblListaCombo.Size = new System.Drawing.Size(237, 28);
            this.lblListaCombo.TabIndex = 19;
            this.lblListaCombo.Text = "Listado de Promociones";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(138, 20);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // ListaPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(732, 419);
            this.Controls.Add(this.panelBackAltaPromocion);
            this.Controls.Add(this.btnEliminarPromo);
            this.Controls.Add(this.btnEditarPromo);
            this.Controls.Add(this.btnCargarPromo);
            this.Name = "ListaPromocion";
            this.Text = "ListaPromocion";
            this.Load += new System.EventHandler(this.ListaPromocion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromocion)).EndInit();
            this.panelBackAltaPromocion.ResumeLayout(false);
            this.panelBackAltaPromocion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvPromocion;
        private Button btnCargarPromo;
        private Button btnEditarPromo;
        private Button btnEliminarPromo;
        private Panel panelBackAltaPromocion;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private Label lblListaCombo;
    }
}