using System.Windows.Forms;

namespace TPG6.Formularios.EntradasVendidas
{
    partial class DetalleVentaEntradas
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.lblPrecioSinDescuento = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListaTickets = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListaCombo = new System.Windows.Forms.Label();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelFondo.Controls.Add(this.panelDetalle);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(966, 489);
            this.panelFondo.TabIndex = 0;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelDetalle.Controls.Add(this.label2);
            this.panelDetalle.Controls.Add(this.lblPrecioSinDescuento);
            this.panelDetalle.Controls.Add(this.lblDescuento);
            this.panelDetalle.Controls.Add(this.label6);
            this.panelDetalle.Controls.Add(this.lblPrecioFinal);
            this.panelDetalle.Controls.Add(this.label8);
            this.panelDetalle.Controls.Add(this.lblMedio);
            this.panelDetalle.Controls.Add(this.label5);
            this.panelDetalle.Controls.Add(this.lblFechaVenta);
            this.panelDetalle.Controls.Add(this.label4);
            this.panelDetalle.Controls.Add(this.lblEmpleado);
            this.panelDetalle.Controls.Add(this.label3);
            this.panelDetalle.Controls.Add(this.btnListaTickets);
            this.panelDetalle.Controls.Add(this.lblSala);
            this.panelDetalle.Controls.Add(this.label1);
            this.panelDetalle.Controls.Add(this.lblListaCombo);
            this.panelDetalle.Controls.Add(this.dgvEntradas);
            this.panelDetalle.Location = new System.Drawing.Point(39, 10);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(874, 448);
            this.panelDetalle.TabIndex = 0;
            // 
            // lblPrecioSinDescuento
            // 
            this.lblPrecioSinDescuento.AutoSize = true;
            this.lblPrecioSinDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecioSinDescuento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecioSinDescuento.Location = new System.Drawing.Point(769, 340);
            this.lblPrecioSinDescuento.Name = "lblPrecioSinDescuento";
            this.lblPrecioSinDescuento.Size = new System.Drawing.Size(19, 21);
            this.lblPrecioSinDescuento.TabIndex = 30;
            this.lblPrecioSinDescuento.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescuento.Location = new System.Drawing.Point(657, 99);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(19, 21);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(533, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Descuento:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecioFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecioFinal.Location = new System.Drawing.Point(657, 69);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(19, 21);
            this.lblPrecioFinal.TabIndex = 27;
            this.lblPrecioFinal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(533, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio Final:";
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMedio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMedio.Location = new System.Drawing.Point(392, 99);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(19, 21);
            this.lblMedio.TabIndex = 25;
            this.lblMedio.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(268, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Medio de pago:";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaVenta.Location = new System.Drawing.Point(392, 69);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(19, 21);
            this.lblFechaVenta.TabIndex = 23;
            this.lblFechaVenta.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(268, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Venta:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleado.Location = new System.Drawing.Point(142, 99);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(19, 21);
            this.lblEmpleado.TabIndex = 21;
            this.lblEmpleado.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(43, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Empleado:";
            // 
            // btnListaTickets
            // 
            this.btnListaTickets.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnListaTickets.FlatAppearance.BorderSize = 0;
            this.btnListaTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnListaTickets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnListaTickets.Location = new System.Drawing.Point(752, 384);
            this.btnListaTickets.Margin = new System.Windows.Forms.Padding(0);
            this.btnListaTickets.Name = "btnListaTickets";
            this.btnListaTickets.Size = new System.Drawing.Size(91, 39);
            this.btnListaTickets.TabIndex = 19;
            this.btnListaTickets.Text = "Volver";
            this.btnListaTickets.UseVisualStyleBackColor = false;
            this.btnListaTickets.Click += new System.EventHandler(this.btnListaTickets_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSala.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSala.Location = new System.Drawing.Point(98, 69);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(19, 21);
            this.lblSala.TabIndex = 18;
            this.lblSala.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sala:";
            // 
            // lblListaCombo
            // 
            this.lblListaCombo.AutoSize = true;
            this.lblListaCombo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblListaCombo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListaCombo.Location = new System.Drawing.Point(43, 18);
            this.lblListaCombo.Name = "lblListaCombo";
            this.lblListaCombo.Size = new System.Drawing.Size(197, 28);
            this.lblListaCombo.TabIndex = 16;
            this.lblListaCombo.Text = "Listado de Entradas";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orden,
            this.Columna,
            this.Fila,
            this.Tarifa,
            this.Precio});
            this.dgvEntradas.Location = new System.Drawing.Point(42, 140);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowTemplate.Height = 25;
            this.dgvEntradas.Size = new System.Drawing.Size(801, 188);
            this.dgvEntradas.TabIndex = 0;
            // 
            // orden
            // 
            this.orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orden.DataPropertyName = "orden";
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            // 
            // Columna
            // 
            this.Columna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columna.DataPropertyName = "letraColumna";
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            // 
            // Fila
            // 
            this.Fila.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fila.DataPropertyName = "numeroFila";
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            // 
            // Tarifa
            // 
            this.Tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarifa.DataPropertyName = "descripcion";
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(613, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Precio SubTotal:";
            // 
            // DetalleVentaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 489);
            this.Controls.Add(this.panelFondo);
            this.Name = "DetalleVentaEntradas";
            this.Text = "DetalleVentaEntradas";
            this.Load += new System.EventHandler(this.DetalleVentaEntradas_Load);
            this.panelFondo.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFondo;
        private Panel panelDetalle;
        private DataGridView dgvEntradas;
        private Label lblSala;
        private Label label1;
        private Label lblListaCombo;
        private Button btnListaTickets;
        private DataGridViewTextBoxColumn orden;
        private DataGridViewTextBoxColumn Columna;
        private DataGridViewTextBoxColumn Fila;
        private DataGridViewTextBoxColumn Tarifa;
        private DataGridViewTextBoxColumn Precio;
        private Label lblEmpleado;
        private Label label3;
        private Label lblFechaVenta;
        private Label label4;
        private Label lblMedio;
        private Label label5;
        private Label lblPrecioSinDescuento;
        private Label lblDescuento;
        private Label label6;
        private Label lblPrecioFinal;
        private Label label8;
        private Label label2;
    }
}