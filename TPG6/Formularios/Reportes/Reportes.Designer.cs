using System.Windows.Forms;

namespace TPG6.Formularios.Reportes
{
    partial class Reportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAltaTarjeta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnFunciones = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.lblAltaTarjeta);
            this.panelFondo.Controls.Add(this.panel2);
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(686, 424);
            this.panelFondo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estadísticas";
            // 
            // lblAltaTarjeta
            // 
            this.lblAltaTarjeta.AutoSize = true;
            this.lblAltaTarjeta.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.lblAltaTarjeta.ForeColor = System.Drawing.Color.White;
            this.lblAltaTarjeta.Location = new System.Drawing.Point(45, 18);
            this.lblAltaTarjeta.Name = "lblAltaTarjeta";
            this.lblAltaTarjeta.Size = new System.Drawing.Size(94, 28);
            this.lblAltaTarjeta.TabIndex = 2;
            this.lblAltaTarjeta.Text = "Listados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.btnFunciones);
            this.panel2.Controls.Add(this.btnEmpleados);
            this.panel2.Location = new System.Drawing.Point(36, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 155);
            this.panel2.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Location = new System.Drawing.Point(25, 84);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(273, 41);
            this.button10.TabIndex = 28;
            this.button10.Text = "Precio / Descuento";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(310, 84);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(273, 41);
            this.button7.TabIndex = 25;
            this.button7.Text = "Entradas";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // btnFunciones
            // 
            this.btnFunciones.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFunciones.FlatAppearance.BorderSize = 0;
            this.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFunciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFunciones.Location = new System.Drawing.Point(310, 33);
            this.btnFunciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(273, 41);
            this.btnFunciones.TabIndex = 24;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.UseVisualStyleBackColor = false;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpleados.Location = new System.Drawing.Point(25, 33);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(273, 41);
            this.btnEmpleados.TabIndex = 22;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(36, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 135);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(312, 70);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(273, 41);
            this.button8.TabIndex = 26;
            this.button8.Text = "Listado Tarifas";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(29, 70);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(273, 41);
            this.button9.TabIndex = 25;
            this.button9.Text = "Listado Funciones";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(312, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(273, 41);
            this.button4.TabIndex = 24;
            this.button4.Text = "Listado Entradas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 424);
            this.Controls.Add(this.panelFondo);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFondo;
        private Panel panel1;
        private Button button8;
        private Button button9;
        private Button button4;
        private Panel panel2;
        private Button button10;
        private Button button7;
        private Button btnFunciones;
        private Button btnEmpleados;
        private Label lblAltaTarjeta;
        private Label label1;
    }
}