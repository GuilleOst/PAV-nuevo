using System.Windows.Forms;

namespace TPG6.Formularios.Funcion
{
    partial class ListaFuncion
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
            this.dgvFuncion = new System.Windows.Forms.DataGridView();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsientos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(29, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 30);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lista de Funciones";
            // 
            // dgvFuncion
            // 
            this.dgvFuncion.AllowUserToAddRows = false;
            this.dgvFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaHora,
            this.pelicula,
            this.Titulo,
            this.Sala,
            this.estado,
            this.FechaInicio,
            this.fechaFin,
            this.semana});
            this.dgvFuncion.Location = new System.Drawing.Point(15, 92);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.RowTemplate.Height = 25;
            this.dgvFuncion.Size = new System.Drawing.Size(627, 172);
            this.dgvFuncion.TabIndex = 3;
            // 
            // fechaHora
            // 
            this.fechaHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaHora.DataPropertyName = "fechaHora";
            this.fechaHora.HeaderText = "Fecha y Hora";
            this.fechaHora.Name = "fechaHora";
            // 
            // pelicula
            // 
            this.pelicula.DataPropertyName = "pelicula";
            this.pelicula.HeaderText = "Pelicula";
            this.pelicula.Name = "pelicula";
            this.pelicula.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "titulo";
            this.Titulo.HeaderText = "Película ";
            this.Titulo.Name = "Titulo";
            // 
            // Sala
            // 
            this.Sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sala.DataPropertyName = "sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicio.DataPropertyName = "fechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // fechaFin
            // 
            this.fechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaFin.DataPropertyName = "fechaFin";
            this.fechaFin.HeaderText = "Fecha Fin";
            this.fechaFin.Name = "fechaFin";
            // 
            // semana
            // 
            this.semana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semana.DataPropertyName = "nroSemana";
            this.semana.HeaderText = "Nro. Semana";
            this.semana.Name = "semana";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btnAsientos);
            this.panel1.Controls.Add(this.dgvFuncion);
            this.panel1.Location = new System.Drawing.Point(29, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 313);
            this.panel1.TabIndex = 14;
            // 
            // btnAsientos
            // 
            this.btnAsientos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAsientos.FlatAppearance.BorderSize = 0;
            this.btnAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsientos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAsientos.ForeColor = System.Drawing.Color.White;
            this.btnAsientos.Location = new System.Drawing.Point(467, 35);
            this.btnAsientos.Name = "btnAsientos";
            this.btnAsientos.Size = new System.Drawing.Size(144, 32);
            this.btnAsientos.TabIndex = 15;
            this.btnAsientos.Text = "Asientos Funcion";
            this.btnAsientos.UseVisualStyleBackColor = false;
            this.btnAsientos.Click += new System.EventHandler(this.btnAsientos_Click);
            // 
            // ListaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(724, 390);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "ListaFuncion";
            this.Text = "ListaFuncion";
            this.Load += new System.EventHandler(this.ListaFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvFuncion;
        private Panel panel1;
        private DataGridViewTextBoxColumn fechaHora;
        private DataGridViewTextBoxColumn pelicula;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn fechaFin;
        private DataGridViewTextBoxColumn semana;
        private Button btnAsientos;
    }
}