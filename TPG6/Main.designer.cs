using System.Windows.Forms;

namespace TPG6
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuUsuario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubCliente = new System.Windows.Forms.Button();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.panelSubMenuMedioPago = new System.Windows.Forms.Panel();
            this.btnSubMedioPago = new System.Windows.Forms.Button();
            this.btnSubTarjeta = new System.Windows.Forms.Button();
            this.btnMenuMedioPago = new System.Windows.Forms.Button();
            this.panelSubMenuTicket = new System.Windows.Forms.Panel();
            this.btnSubTicket = new System.Windows.Forms.Button();
            this.btnMenuTicket = new System.Windows.Forms.Button();
            this.panelSubMenuFuncion = new System.Windows.Forms.Panel();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.btnMenuFuncion = new System.Windows.Forms.Button();
            this.panelSubMenuEntrada = new System.Windows.Forms.Panel();
            this.btnEntradasVendidas = new System.Windows.Forms.Button();
            this.btnSubPromocion = new System.Windows.Forms.Button();
            this.btnMenuEntrada = new System.Windows.Forms.Button();
            this.panelSubMenuCombo = new System.Windows.Forms.Panel();
            this.btnSubCombo = new System.Windows.Forms.Button();
            this.btnSubProducto = new System.Windows.Forms.Button();
            this.btnMenuCombo = new System.Windows.Forms.Button();
            this.panelSubMenuPelicula = new System.Windows.Forms.Panel();
            this.btnSubPelicula = new System.Windows.Forms.Button();
            this.btnSubParticipantes = new System.Windows.Forms.Button();
            this.btnMenuPelicula = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuUsuario.SuspendLayout();
            this.panelSubMenuMedioPago.SuspendLayout();
            this.panelSubMenuTicket.SuspendLayout();
            this.panelSubMenuFuncion.SuspendLayout();
            this.panelSubMenuEntrada.SuspendLayout();
            this.panelSubMenuCombo.SuspendLayout();
            this.panelSubMenuPelicula.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenuLateral.Controls.Add(this.panelSubMenuUsuario);
            this.panelMenuLateral.Controls.Add(this.btnMenuUsuario);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuMedioPago);
            this.panelMenuLateral.Controls.Add(this.btnMenuMedioPago);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuTicket);
            this.panelMenuLateral.Controls.Add(this.btnMenuTicket);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuFuncion);
            this.panelMenuLateral.Controls.Add(this.btnMenuFuncion);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuEntrada);
            this.panelMenuLateral.Controls.Add(this.btnMenuEntrada);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuCombo);
            this.panelMenuLateral.Controls.Add(this.btnMenuCombo);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuPelicula);
            this.panelMenuLateral.Controls.Add(this.btnMenuPelicula);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 749);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelSubMenuUsuario
            // 
            this.panelSubMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuUsuario.Controls.Add(this.button1);
            this.panelSubMenuUsuario.Controls.Add(this.btnSubCliente);
            this.panelSubMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuUsuario.Location = new System.Drawing.Point(0, 930);
            this.panelSubMenuUsuario.Name = "panelSubMenuUsuario";
            this.panelSubMenuUsuario.Size = new System.Drawing.Size(233, 90);
            this.panelSubMenuUsuario.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 45);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reportes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubCliente
            // 
            this.btnSubCliente.BackColor = System.Drawing.Color.Black;
            this.btnSubCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCliente.FlatAppearance.BorderSize = 0;
            this.btnSubCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubCliente.ForeColor = System.Drawing.Color.White;
            this.btnSubCliente.Location = new System.Drawing.Point(0, 0);
            this.btnSubCliente.Name = "btnSubCliente";
            this.btnSubCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubCliente.Size = new System.Drawing.Size(233, 45);
            this.btnSubCliente.TabIndex = 1;
            this.btnSubCliente.Text = "Cliente";
            this.btnSubCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCliente.UseVisualStyleBackColor = false;
            this.btnSubCliente.Click += new System.EventHandler(this.btnSubCliente_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 885);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuUsuario.Size = new System.Drawing.Size(233, 45);
            this.btnMenuUsuario.TabIndex = 14;
            this.btnMenuUsuario.Text = "Usuario";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.UseVisualStyleBackColor = false;
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // panelSubMenuMedioPago
            // 
            this.panelSubMenuMedioPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuMedioPago.Controls.Add(this.btnSubMedioPago);
            this.panelSubMenuMedioPago.Controls.Add(this.btnSubTarjeta);
            this.panelSubMenuMedioPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuMedioPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelSubMenuMedioPago.ForeColor = System.Drawing.Color.White;
            this.panelSubMenuMedioPago.Location = new System.Drawing.Point(0, 796);
            this.panelSubMenuMedioPago.Name = "panelSubMenuMedioPago";
            this.panelSubMenuMedioPago.Size = new System.Drawing.Size(233, 89);
            this.panelSubMenuMedioPago.TabIndex = 13;
            // 
            // btnSubMedioPago
            // 
            this.btnSubMedioPago.BackColor = System.Drawing.Color.Black;
            this.btnSubMedioPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMedioPago.FlatAppearance.BorderSize = 0;
            this.btnSubMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMedioPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubMedioPago.ForeColor = System.Drawing.Color.White;
            this.btnSubMedioPago.Location = new System.Drawing.Point(0, 45);
            this.btnSubMedioPago.Name = "btnSubMedioPago";
            this.btnSubMedioPago.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubMedioPago.Size = new System.Drawing.Size(233, 39);
            this.btnSubMedioPago.TabIndex = 2;
            this.btnSubMedioPago.Text = "Medio Pago";
            this.btnSubMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMedioPago.UseVisualStyleBackColor = false;
            this.btnSubMedioPago.Click += new System.EventHandler(this.btnSubMedioPago_Click);
            // 
            // btnSubTarjeta
            // 
            this.btnSubTarjeta.BackColor = System.Drawing.Color.Black;
            this.btnSubTarjeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTarjeta.FlatAppearance.BorderSize = 0;
            this.btnSubTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnSubTarjeta.Location = new System.Drawing.Point(0, 0);
            this.btnSubTarjeta.Name = "btnSubTarjeta";
            this.btnSubTarjeta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubTarjeta.Size = new System.Drawing.Size(233, 45);
            this.btnSubTarjeta.TabIndex = 0;
            this.btnSubTarjeta.Text = "Tarjeta";
            this.btnSubTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTarjeta.UseVisualStyleBackColor = false;
            this.btnSubTarjeta.Click += new System.EventHandler(this.btnSubTarjeta_Click_1);
            // 
            // btnMenuMedioPago
            // 
            this.btnMenuMedioPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuMedioPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMedioPago.FlatAppearance.BorderSize = 0;
            this.btnMenuMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMedioPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuMedioPago.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuMedioPago.Location = new System.Drawing.Point(0, 751);
            this.btnMenuMedioPago.Name = "btnMenuMedioPago";
            this.btnMenuMedioPago.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuMedioPago.Size = new System.Drawing.Size(233, 45);
            this.btnMenuMedioPago.TabIndex = 12;
            this.btnMenuMedioPago.Text = "Medio Pago";
            this.btnMenuMedioPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMedioPago.UseVisualStyleBackColor = false;
            this.btnMenuMedioPago.Click += new System.EventHandler(this.btnMenuMedioPago_Click);
            // 
            // panelSubMenuTicket
            // 
            this.panelSubMenuTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuTicket.Controls.Add(this.btnSubTicket);
            this.panelSubMenuTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.panelSubMenuTicket.ForeColor = System.Drawing.Color.White;
            this.panelSubMenuTicket.Location = new System.Drawing.Point(0, 703);
            this.panelSubMenuTicket.Name = "panelSubMenuTicket";
            this.panelSubMenuTicket.Size = new System.Drawing.Size(233, 48);
            this.panelSubMenuTicket.TabIndex = 11;
            // 
            // btnSubTicket
            // 
            this.btnSubTicket.BackColor = System.Drawing.Color.Black;
            this.btnSubTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTicket.FlatAppearance.BorderSize = 0;
            this.btnSubTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubTicket.ForeColor = System.Drawing.Color.White;
            this.btnSubTicket.Location = new System.Drawing.Point(0, 0);
            this.btnSubTicket.Name = "btnSubTicket";
            this.btnSubTicket.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubTicket.Size = new System.Drawing.Size(233, 45);
            this.btnSubTicket.TabIndex = 1;
            this.btnSubTicket.Text = "Ticket";
            this.btnSubTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTicket.UseVisualStyleBackColor = false;
            this.btnSubTicket.Click += new System.EventHandler(this.btnSubTicket_Click);
            // 
            // btnMenuTicket
            // 
            this.btnMenuTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuTicket.FlatAppearance.BorderSize = 0;
            this.btnMenuTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuTicket.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuTicket.Location = new System.Drawing.Point(0, 658);
            this.btnMenuTicket.Name = "btnMenuTicket";
            this.btnMenuTicket.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuTicket.Size = new System.Drawing.Size(233, 45);
            this.btnMenuTicket.TabIndex = 10;
            this.btnMenuTicket.Text = "Ticket";
            this.btnMenuTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuTicket.UseVisualStyleBackColor = false;
            this.btnMenuTicket.Click += new System.EventHandler(this.btnMenuTicket_Click);
            // 
            // panelSubMenuFuncion
            // 
            this.panelSubMenuFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuFuncion.Controls.Add(this.btnFuncion);
            this.panelSubMenuFuncion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFuncion.Location = new System.Drawing.Point(0, 616);
            this.panelSubMenuFuncion.Name = "panelSubMenuFuncion";
            this.panelSubMenuFuncion.Size = new System.Drawing.Size(233, 42);
            this.panelSubMenuFuncion.TabIndex = 9;
            // 
            // btnFuncion
            // 
            this.btnFuncion.BackColor = System.Drawing.Color.Black;
            this.btnFuncion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncion.FlatAppearance.BorderSize = 0;
            this.btnFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFuncion.ForeColor = System.Drawing.Color.White;
            this.btnFuncion.Location = new System.Drawing.Point(0, 0);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFuncion.Size = new System.Drawing.Size(233, 39);
            this.btnFuncion.TabIndex = 4;
            this.btnFuncion.Text = "Función";
            this.btnFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncion.UseVisualStyleBackColor = false;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // btnMenuFuncion
            // 
            this.btnMenuFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuFuncion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuFuncion.FlatAppearance.BorderSize = 0;
            this.btnMenuFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFuncion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuFuncion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuFuncion.Location = new System.Drawing.Point(0, 571);
            this.btnMenuFuncion.Name = "btnMenuFuncion";
            this.btnMenuFuncion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuFuncion.Size = new System.Drawing.Size(233, 45);
            this.btnMenuFuncion.TabIndex = 8;
            this.btnMenuFuncion.Text = "Función";
            this.btnMenuFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuFuncion.UseVisualStyleBackColor = false;
            this.btnMenuFuncion.Click += new System.EventHandler(this.btnMenuFuncion_Click);
            // 
            // panelSubMenuEntrada
            // 
            this.panelSubMenuEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuEntrada.Controls.Add(this.btnEntradasVendidas);
            this.panelSubMenuEntrada.Controls.Add(this.btnSubPromocion);
            this.panelSubMenuEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEntrada.Location = new System.Drawing.Point(0, 479);
            this.panelSubMenuEntrada.Name = "panelSubMenuEntrada";
            this.panelSubMenuEntrada.Size = new System.Drawing.Size(233, 92);
            this.panelSubMenuEntrada.TabIndex = 7;
            // 
            // btnEntradasVendidas
            // 
            this.btnEntradasVendidas.BackColor = System.Drawing.Color.Black;
            this.btnEntradasVendidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntradasVendidas.FlatAppearance.BorderSize = 0;
            this.btnEntradasVendidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradasVendidas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEntradasVendidas.ForeColor = System.Drawing.Color.White;
            this.btnEntradasVendidas.Location = new System.Drawing.Point(0, 45);
            this.btnEntradasVendidas.Name = "btnEntradasVendidas";
            this.btnEntradasVendidas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEntradasVendidas.Size = new System.Drawing.Size(233, 45);
            this.btnEntradasVendidas.TabIndex = 3;
            this.btnEntradasVendidas.Text = "Entradas Vendidas";
            this.btnEntradasVendidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradasVendidas.UseVisualStyleBackColor = false;
            this.btnEntradasVendidas.Click += new System.EventHandler(this.btnEntradasVendidas_Click);
            // 
            // btnSubPromocion
            // 
            this.btnSubPromocion.BackColor = System.Drawing.Color.Black;
            this.btnSubPromocion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPromocion.FlatAppearance.BorderSize = 0;
            this.btnSubPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPromocion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubPromocion.ForeColor = System.Drawing.Color.White;
            this.btnSubPromocion.Location = new System.Drawing.Point(0, 0);
            this.btnSubPromocion.Name = "btnSubPromocion";
            this.btnSubPromocion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubPromocion.Size = new System.Drawing.Size(233, 45);
            this.btnSubPromocion.TabIndex = 0;
            this.btnSubPromocion.Text = "Promoción";
            this.btnSubPromocion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPromocion.UseVisualStyleBackColor = false;
            this.btnSubPromocion.Click += new System.EventHandler(this.btnSubPromocion_Click);
            // 
            // btnMenuEntrada
            // 
            this.btnMenuEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEntrada.FlatAppearance.BorderSize = 0;
            this.btnMenuEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEntrada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuEntrada.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuEntrada.Location = new System.Drawing.Point(0, 434);
            this.btnMenuEntrada.Name = "btnMenuEntrada";
            this.btnMenuEntrada.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuEntrada.Size = new System.Drawing.Size(233, 45);
            this.btnMenuEntrada.TabIndex = 6;
            this.btnMenuEntrada.Text = "Entrada";
            this.btnMenuEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEntrada.UseVisualStyleBackColor = false;
            this.btnMenuEntrada.Click += new System.EventHandler(this.btnMenuEntrada_Click);
            // 
            // panelSubMenuCombo
            // 
            this.panelSubMenuCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuCombo.Controls.Add(this.btnSubCombo);
            this.panelSubMenuCombo.Controls.Add(this.btnSubProducto);
            this.panelSubMenuCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCombo.Location = new System.Drawing.Point(0, 339);
            this.panelSubMenuCombo.Name = "panelSubMenuCombo";
            this.panelSubMenuCombo.Size = new System.Drawing.Size(233, 95);
            this.panelSubMenuCombo.TabIndex = 5;
            // 
            // btnSubCombo
            // 
            this.btnSubCombo.BackColor = System.Drawing.Color.Black;
            this.btnSubCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCombo.FlatAppearance.BorderSize = 0;
            this.btnSubCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubCombo.ForeColor = System.Drawing.Color.White;
            this.btnSubCombo.Location = new System.Drawing.Point(0, 45);
            this.btnSubCombo.Name = "btnSubCombo";
            this.btnSubCombo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubCombo.Size = new System.Drawing.Size(233, 47);
            this.btnSubCombo.TabIndex = 2;
            this.btnSubCombo.Text = "Combo";
            this.btnSubCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCombo.UseVisualStyleBackColor = false;
            this.btnSubCombo.Click += new System.EventHandler(this.btnSubCombo_Click);
            // 
            // btnSubProducto
            // 
            this.btnSubProducto.BackColor = System.Drawing.Color.Black;
            this.btnSubProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubProducto.FlatAppearance.BorderSize = 0;
            this.btnSubProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubProducto.ForeColor = System.Drawing.Color.White;
            this.btnSubProducto.Location = new System.Drawing.Point(0, 0);
            this.btnSubProducto.Name = "btnSubProducto";
            this.btnSubProducto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubProducto.Size = new System.Drawing.Size(233, 45);
            this.btnSubProducto.TabIndex = 0;
            this.btnSubProducto.Text = "Producto";
            this.btnSubProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProducto.UseVisualStyleBackColor = false;
            this.btnSubProducto.Click += new System.EventHandler(this.btnSubProducto_Click);
            // 
            // btnMenuCombo
            // 
            this.btnMenuCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCombo.FlatAppearance.BorderSize = 0;
            this.btnMenuCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuCombo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuCombo.Location = new System.Drawing.Point(0, 294);
            this.btnMenuCombo.Name = "btnMenuCombo";
            this.btnMenuCombo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuCombo.Size = new System.Drawing.Size(233, 45);
            this.btnMenuCombo.TabIndex = 4;
            this.btnMenuCombo.Text = "Combo";
            this.btnMenuCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCombo.UseVisualStyleBackColor = false;
            this.btnMenuCombo.Click += new System.EventHandler(this.btnMenuCombo_Click_1);
            // 
            // panelSubMenuPelicula
            // 
            this.panelSubMenuPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSubMenuPelicula.Controls.Add(this.btnSubPelicula);
            this.panelSubMenuPelicula.Controls.Add(this.btnSubParticipantes);
            this.panelSubMenuPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPelicula.Location = new System.Drawing.Point(0, 199);
            this.panelSubMenuPelicula.Name = "panelSubMenuPelicula";
            this.panelSubMenuPelicula.Size = new System.Drawing.Size(233, 95);
            this.panelSubMenuPelicula.TabIndex = 3;
            // 
            // btnSubPelicula
            // 
            this.btnSubPelicula.BackColor = System.Drawing.Color.Black;
            this.btnSubPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPelicula.FlatAppearance.BorderSize = 0;
            this.btnSubPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPelicula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubPelicula.ForeColor = System.Drawing.Color.White;
            this.btnSubPelicula.Location = new System.Drawing.Point(0, 45);
            this.btnSubPelicula.Name = "btnSubPelicula";
            this.btnSubPelicula.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubPelicula.Size = new System.Drawing.Size(233, 47);
            this.btnSubPelicula.TabIndex = 8;
            this.btnSubPelicula.Text = "Película";
            this.btnSubPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPelicula.UseVisualStyleBackColor = false;
            this.btnSubPelicula.Click += new System.EventHandler(this.btnSubPelicula_Click);
            // 
            // btnSubParticipantes
            // 
            this.btnSubParticipantes.BackColor = System.Drawing.Color.Black;
            this.btnSubParticipantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubParticipantes.FlatAppearance.BorderSize = 0;
            this.btnSubParticipantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubParticipantes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSubParticipantes.ForeColor = System.Drawing.Color.White;
            this.btnSubParticipantes.Location = new System.Drawing.Point(0, 0);
            this.btnSubParticipantes.Name = "btnSubParticipantes";
            this.btnSubParticipantes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubParticipantes.Size = new System.Drawing.Size(233, 45);
            this.btnSubParticipantes.TabIndex = 6;
            this.btnSubParticipantes.Text = "Actor";
            this.btnSubParticipantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubParticipantes.UseVisualStyleBackColor = false;
            this.btnSubParticipantes.Click += new System.EventHandler(this.btnSubParticipantes_Click);
            // 
            // btnMenuPelicula
            // 
            this.btnMenuPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenuPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuPelicula.FlatAppearance.BorderSize = 0;
            this.btnMenuPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPelicula.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuPelicula.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuPelicula.Location = new System.Drawing.Point(0, 154);
            this.btnMenuPelicula.Name = "btnMenuPelicula";
            this.btnMenuPelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuPelicula.Size = new System.Drawing.Size(233, 45);
            this.btnMenuPelicula.TabIndex = 2;
            this.btnMenuPelicula.Text = "Película";
            this.btnMenuPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPelicula.UseVisualStyleBackColor = false;
            this.btnMenuPelicula.Click += new System.EventHandler(this.btnMenuPelicula_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 154);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1120, 46);
            this.panelTop.TabIndex = 2;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(250, 703);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1120, 46);
            this.panelBot.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(14)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 46);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1120, 657);
            this.panelChildForm.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuUsuario.ResumeLayout(false);
            this.panelSubMenuMedioPago.ResumeLayout(false);
            this.panelSubMenuTicket.ResumeLayout(false);
            this.panelSubMenuFuncion.ResumeLayout(false);
            this.panelSubMenuEntrada.ResumeLayout(false);
            this.panelSubMenuCombo.ResumeLayout(false);
            this.panelSubMenuPelicula.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelSubMenuPelicula;
        private Button btnSubParticipantes;
        private Button btnMenuPelicula;
        private Panel panelTop;
        private Panel panelBot;
        private Panel panelSubMenuFuncion;
        private Button btnFuncion;
        private Button btnMenuFuncion;
        private Panel panelSubMenuEntrada;
        private Button btnSubPromocion;
        private Button btnMenuEntrada;
        private Panel panelSubMenuCombo;
        private Button btnSubCombo;
        private Button btnSubProducto;
        private Button btnMenuCombo;
        private Button btnSubPelicula;
        private Panel panelSubMenuTicket;
        private Button btnSubTicket;
        private Button btnMenuTicket;
        private Panel panelSubMenuMedioPago;
        private Button btnSubMedioPago;
        private Button btnSubTarjeta;
        private Button btnMenuMedioPago;
        private Panel panelSubMenuUsuario;
        private Button btnSubCliente;
        private Button btnMenuUsuario;
        private Panel panelChildForm;
        private Button btnEntradasVendidas;
        private Button button1;
        private Panel panelLogo;
    }
}