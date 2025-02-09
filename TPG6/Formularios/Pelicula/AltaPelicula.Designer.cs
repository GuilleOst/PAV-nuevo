﻿using System.Windows.Forms;

namespace TPG6.Formularios.Pelicula
{
    partial class AltaPelicula
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
            this.lblRegistroPelicula = new System.Windows.Forms.Label();
            this.codPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leyenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError2 = new System.Windows.Forms.Label();
            this.txtCodPelicula = new System.Windows.Forms.TextBox();
            this.cmbDistribuidora = new System.Windows.Forms.ComboBox();
            this.lblDistribuidora = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cmbCalificacion = new System.Windows.Forms.ComboBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtEstreno = new System.Windows.Forms.TextBox();
            this.lblañoEstreno = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.gdrActualizarPeli = new System.Windows.Forms.DataGridView();
            this.codPeliculaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribuidora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarPeli)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroPelicula
            // 
            this.lblRegistroPelicula.AutoSize = true;
            this.lblRegistroPelicula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblRegistroPelicula.ForeColor = System.Drawing.Color.White;
            this.lblRegistroPelicula.Location = new System.Drawing.Point(15, 20);
            this.lblRegistroPelicula.Name = "lblRegistroPelicula";
            this.lblRegistroPelicula.Size = new System.Drawing.Size(214, 28);
            this.lblRegistroPelicula.TabIndex = 18;
            this.lblRegistroPelicula.Text = "Registro de  Peliculas";
            // 
            // codPelicula
            // 
            this.codPelicula.DataPropertyName = "codPelicula";
            this.codPelicula.HeaderText = "codPelicula";
            this.codPelicula.Name = "codPelicula";
            this.codPelicula.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Leyenda
            // 
            this.Leyenda.DataPropertyName = "leyenda";
            this.Leyenda.HeaderText = "Leyenda";
            this.Leyenda.Name = "Leyenda";
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "duracion";
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            // 
            // Sinopsis
            // 
            this.Sinopsis.DataPropertyName = "sinopsis";
            this.Sinopsis.HeaderText = "Sinopsis";
            this.Sinopsis.Name = "Sinopsis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(553, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Actualizar Película";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblError2);
            this.panel1.Controls.Add(this.txtCodPelicula);
            this.panel1.Controls.Add(this.cmbDistribuidora);
            this.panel1.Controls.Add(this.lblDistribuidora);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.cmbFormato);
            this.panel1.Controls.Add(this.lblFormato);
            this.panel1.Controls.Add(this.cmbCalificacion);
            this.panel1.Controls.Add(this.lblCalificacion);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.lblOrigen);
            this.panel1.Controls.Add(this.txtEstreno);
            this.panel1.Controls.Add(this.lblañoEstreno);
            this.panel1.Controls.Add(this.txtSinopsis);
            this.panel1.Controls.Add(this.lblSinopsis);
            this.panel1.Controls.Add(this.txtDuracion);
            this.panel1.Controls.Add(this.lblDuracion);
            this.panel1.Controls.Add(this.txtLeyenda);
            this.panel1.Controls.Add(this.lblLeyenda);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblIdioma);
            this.panel1.Controls.Add(this.cmbIdioma);
            this.panel1.Location = new System.Drawing.Point(53, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 232);
            this.panel1.TabIndex = 21;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(24, 266);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 13);
            this.lblError2.TabIndex = 35;
            // 
            // txtCodPelicula
            // 
            this.txtCodPelicula.Location = new System.Drawing.Point(28, 188);
            this.txtCodPelicula.Name = "txtCodPelicula";
            this.txtCodPelicula.Size = new System.Drawing.Size(86, 20);
            this.txtCodPelicula.TabIndex = 34;
            this.txtCodPelicula.Visible = false;
            // 
            // cmbDistribuidora
            // 
            this.cmbDistribuidora.FormattingEnabled = true;
            this.cmbDistribuidora.Location = new System.Drawing.Point(308, 143);
            this.cmbDistribuidora.Name = "cmbDistribuidora";
            this.cmbDistribuidora.Size = new System.Drawing.Size(161, 21);
            this.cmbDistribuidora.TabIndex = 33;
            // 
            // lblDistribuidora
            // 
            this.lblDistribuidora.AutoSize = true;
            this.lblDistribuidora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDistribuidora.ForeColor = System.Drawing.Color.White;
            this.lblDistribuidora.Location = new System.Drawing.Point(308, 116);
            this.lblDistribuidora.Name = "lblDistribuidora";
            this.lblDistribuidora.Size = new System.Drawing.Size(117, 19);
            this.lblDistribuidora.TabIndex = 32;
            this.lblDistribuidora.Text = "Distribuidora (*)";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(146, 143);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(141, 21);
            this.cmbGenero.TabIndex = 31;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(146, 117);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(78, 19);
            this.lblGenero.TabIndex = 30;
            this.lblGenero.Text = "Genero (*)";
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(23, 143);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(96, 21);
            this.cmbFormato.TabIndex = 29;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormato.ForeColor = System.Drawing.Color.White;
            this.lblFormato.Location = new System.Drawing.Point(23, 117);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(86, 19);
            this.lblFormato.TabIndex = 28;
            this.lblFormato.Text = "Formato (*)";
            // 
            // cmbCalificacion
            // 
            this.cmbCalificacion.FormattingEnabled = true;
            this.cmbCalificacion.Location = new System.Drawing.Point(382, 87);
            this.cmbCalificacion.Name = "cmbCalificacion";
            this.cmbCalificacion.Size = new System.Drawing.Size(233, 21);
            this.cmbCalificacion.TabIndex = 27;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCalificacion.ForeColor = System.Drawing.Color.White;
            this.lblCalificacion.Location = new System.Drawing.Point(382, 65);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(106, 19);
            this.lblCalificacion.TabIndex = 26;
            this.lblCalificacion.Text = "Calificacion (*)";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(147, 87);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(211, 21);
            this.cmbOrigen.TabIndex = 25;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(147, 65);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(75, 19);
            this.lblOrigen.TabIndex = 24;
            this.lblOrigen.Text = "Origen (*)";
            // 
            // txtEstreno
            // 
            this.txtEstreno.Location = new System.Drawing.Point(24, 87);
            this.txtEstreno.Name = "txtEstreno";
            this.txtEstreno.Size = new System.Drawing.Size(96, 20);
            this.txtEstreno.TabIndex = 23;
            // 
            // lblañoEstreno
            // 
            this.lblañoEstreno.AutoSize = true;
            this.lblañoEstreno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblañoEstreno.ForeColor = System.Drawing.Color.White;
            this.lblañoEstreno.Location = new System.Drawing.Point(24, 65);
            this.lblañoEstreno.Name = "lblañoEstreno";
            this.lblañoEstreno.Size = new System.Drawing.Size(109, 19);
            this.lblañoEstreno.TabIndex = 22;
            this.lblañoEstreno.Text = "Año Estreno (*)";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(382, 33);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(233, 20);
            this.txtSinopsis.TabIndex = 21;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSinopsis.ForeColor = System.Drawing.Color.White;
            this.lblSinopsis.Location = new System.Drawing.Point(382, 9);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(83, 19);
            this.lblSinopsis.TabIndex = 20;
            this.lblSinopsis.Text = "Sinopsis (*)";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(263, 33);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(96, 20);
            this.txtDuracion.TabIndex = 19;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(263, 9);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(89, 19);
            this.lblDuracion.TabIndex = 18;
            this.lblDuracion.Text = "Duración (*)";
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Location = new System.Drawing.Point(147, 33);
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.Size = new System.Drawing.Size(96, 20);
            this.txtLeyenda.TabIndex = 17;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLeyenda.ForeColor = System.Drawing.Color.White;
            this.lblLeyenda.Location = new System.Drawing.Point(147, 9);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(85, 19);
            this.lblLeyenda.TabIndex = 16;
            this.lblLeyenda.Text = "Leyenda (*)";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(24, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(96, 20);
            this.txtTitulo.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(24, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(67, 19);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Titulo (*)";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(278, 188);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(129, 24);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Location = new System.Drawing.Point(439, 188);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 24);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(535, 188);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(488, 116);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(76, 19);
            this.lblIdioma.TabIndex = 12;
            this.lblIdioma.Text = "Idioma (*)";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(488, 143);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(127, 21);
            this.cmbIdioma.TabIndex = 0;
            // 
            // gdrActualizarPeli
            // 
            this.gdrActualizarPeli.AllowUserToAddRows = false;
            this.gdrActualizarPeli.AllowUserToDeleteRows = false;
            this.gdrActualizarPeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrActualizarPeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPeliculaItem,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Duración,
            this.dataGridViewTextBoxColumn3,
            this.Origen,
            this.Calificación,
            this.Formato,
            this.Genero,
            this.Distribuidora,
            this.Idioma});
            this.gdrActualizarPeli.Location = new System.Drawing.Point(22, 312);
            this.gdrActualizarPeli.Name = "gdrActualizarPeli";
            this.gdrActualizarPeli.ReadOnly = true;
            this.gdrActualizarPeli.RowTemplate.Height = 25;
            this.gdrActualizarPeli.Size = new System.Drawing.Size(718, 153);
            this.gdrActualizarPeli.TabIndex = 26;
            this.gdrActualizarPeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrActualizarPeli_CellClick);
            // 
            // codPeliculaItem
            // 
            this.codPeliculaItem.DataPropertyName = "codPelicula";
            this.codPeliculaItem.HeaderText = "codPelicula";
            this.codPeliculaItem.Name = "codPeliculaItem";
            this.codPeliculaItem.ReadOnly = true;
            this.codPeliculaItem.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ptitulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pleyenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Leyenda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Duración
            // 
            this.Duración.DataPropertyName = "duracion";
            this.Duración.HeaderText = "Duración";
            this.Duración.Name = "Duración";
            this.Duración.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sinopsis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sinopsis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "nombre";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Calificación
            // 
            this.Calificación.DataPropertyName = "abreviatura";
            this.Calificación.HeaderText = "Calificación";
            this.Calificación.Name = "Calificación";
            this.Calificación.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.DataPropertyName = "fdescripcion";
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "gdescripcion";
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Distribuidora
            // 
            this.Distribuidora.DataPropertyName = "nombreDistribuidora";
            this.Distribuidora.HeaderText = "Distribuidora";
            this.Distribuidora.Name = "Distribuidora";
            this.Distribuidora.ReadOnly = true;
            // 
            // Idioma
            // 
            this.Idioma.DataPropertyName = "idescripcion";
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.gdrActualizarPeli);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 490);
            this.panel2.TabIndex = 24;
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(86, 20);
            this.lblError.TabIndex = 0;
            // 
            // AltaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(793, 559);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRegistroPelicula);
            this.Controls.Add(this.panel2);
            this.Name = "AltaPelicula";
            this.Text = "AltaPelicula";
            this.Load += new System.EventHandler(this.AltaPelicula_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrActualizarPeli)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblRegistroPelicula;
        private DataGridViewTextBoxColumn codPelicula;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Leyenda;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Sinopsis;
        private Label label1;
        private Panel panel1;
        private Label lblError2;
        private TextBox txtCodPelicula;
        private ComboBox cmbDistribuidora;
        private Label lblDistribuidora;
        private ComboBox cmbGenero;
        private Label lblGenero;
        private ComboBox cmbFormato;
        private Label lblFormato;
        private ComboBox cmbCalificacion;
        private Label lblCalificacion;
        private ComboBox cmbOrigen;
        private Label lblOrigen;
        private TextBox txtEstreno;
        private Label lblañoEstreno;
        private TextBox txtSinopsis;
        private Label lblSinopsis;
        private TextBox txtDuracion;
        private Label lblDuracion;
        private TextBox txtLeyenda;
        private Label lblLeyenda;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Button btnLimpiarCampos;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label lblIdioma;
        private ComboBox cmbIdioma;
        private DataGridView gdrActualizarPeli;
        private DataGridViewTextBoxColumn codPeliculaItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Duración;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Origen;
        private DataGridViewTextBoxColumn Calificación;
        private DataGridViewTextBoxColumn Formato;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Distribuidora;
        private DataGridViewTextBoxColumn Idioma;
        private Panel panel2;
        private Label lblError;
    }
}