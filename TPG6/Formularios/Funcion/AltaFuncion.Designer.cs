using System.Windows.Forms;

namespace TPG6.Formularios.Funcion
{
    partial class AltaFuncion
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
            this.components = new System.ComponentModel.Container();
            this.panelBackAltaFuncion = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbFechaFin = new System.Windows.Forms.ComboBox();
            this.cmbFechaInicio = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbPeli = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.btnCargarFuncion = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.funcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelBackAltaFuncion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackAltaFuncion
            // 
            this.panelBackAltaFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panelBackAltaFuncion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackAltaFuncion.Controls.Add(this.lblError);
            this.panelBackAltaFuncion.Controls.Add(this.cmbFechaFin);
            this.panelBackAltaFuncion.Controls.Add(this.cmbFechaInicio);
            this.panelBackAltaFuncion.Controls.Add(this.cmbEstado);
            this.panelBackAltaFuncion.Controls.Add(this.cmbPeli);
            this.panelBackAltaFuncion.Controls.Add(this.cmbSala);
            this.panelBackAltaFuncion.Controls.Add(this.btnCargarFuncion);
            this.panelBackAltaFuncion.Controls.Add(this.lblFechaInicio);
            this.panelBackAltaFuncion.Controls.Add(this.lblFechaFin);
            this.panelBackAltaFuncion.Controls.Add(this.lblEstado);
            this.panelBackAltaFuncion.Controls.Add(this.lblPelicula);
            this.panelBackAltaFuncion.Controls.Add(this.lblSala);
            this.panelBackAltaFuncion.Controls.Add(this.maskedTextBox1);
            this.panelBackAltaFuncion.Controls.Add(this.lblFechaHora);
            this.panelBackAltaFuncion.Location = new System.Drawing.Point(46, 54);
            this.panelBackAltaFuncion.Name = "panelBackAltaFuncion";
            this.panelBackAltaFuncion.Size = new System.Drawing.Size(634, 310);
            this.panelBackAltaFuncion.TabIndex = 15;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(39, 217);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 34;
            // 
            // cmbFechaFin
            // 
            this.cmbFechaFin.Enabled = false;
            this.cmbFechaFin.FormattingEnabled = true;
            this.cmbFechaFin.Location = new System.Drawing.Point(487, 67);
            this.cmbFechaFin.Name = "cmbFechaFin";
            this.cmbFechaFin.Size = new System.Drawing.Size(104, 21);
            this.cmbFechaFin.TabIndex = 5;
            // 
            // cmbFechaInicio
            // 
            this.cmbFechaInicio.FormattingEnabled = true;
            this.cmbFechaInicio.Location = new System.Drawing.Point(487, 22);
            this.cmbFechaInicio.Name = "cmbFechaInicio";
            this.cmbFechaInicio.Size = new System.Drawing.Size(104, 21);
            this.cmbFechaInicio.TabIndex = 4;
            this.cmbFechaInicio.SelectedIndexChanged += new System.EventHandler(this.cmbFechaInicio_SelectedIndexChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(166, 163);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(138, 21);
            this.cmbEstado.TabIndex = 3;
            // 
            // cmbPeli
            // 
            this.cmbPeli.FormattingEnabled = true;
            this.cmbPeli.Location = new System.Drawing.Point(166, 115);
            this.cmbPeli.Name = "cmbPeli";
            this.cmbPeli.Size = new System.Drawing.Size(138, 21);
            this.cmbPeli.TabIndex = 2;
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(166, 68);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(138, 21);
            this.cmbSala.TabIndex = 1;
            // 
            // btnCargarFuncion
            // 
            this.btnCargarFuncion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarFuncion.FlatAppearance.BorderSize = 0;
            this.btnCargarFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFuncion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargarFuncion.ForeColor = System.Drawing.Color.White;
            this.btnCargarFuncion.Location = new System.Drawing.Point(397, 243);
            this.btnCargarFuncion.Name = "btnCargarFuncion";
            this.btnCargarFuncion.Size = new System.Drawing.Size(123, 32);
            this.btnCargarFuncion.TabIndex = 6;
            this.btnCargarFuncion.Text = "Cargar";
            this.btnCargarFuncion.UseVisualStyleBackColor = false;
            this.btnCargarFuncion.Click += new System.EventHandler(this.btnCargarFuncion_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(358, 23);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(124, 21);
            this.lblFechaInicio.TabIndex = 23;
            this.lblFechaInicio.Text = "Fecha Inicio (*)";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(358, 68);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(104, 21);
            this.lblFechaFin.TabIndex = 22;
            this.lblFechaFin.Text = "Fecha Fin (*)";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(22, 164);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 21);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado (*)";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPelicula.ForeColor = System.Drawing.Color.White;
            this.lblPelicula.Location = new System.Drawing.Point(22, 115);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(94, 21);
            this.lblPelicula.TabIndex = 18;
            this.lblPelicula.Text = "Pelicula (*)";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSala.ForeColor = System.Drawing.Color.White;
            this.lblSala.Location = new System.Drawing.Point(22, 68);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(65, 21);
            this.lblSala.TabIndex = 15;
            this.lblSala.Text = "Sala (*)";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(166, 23);
            this.maskedTextBox1.Mask = "00/00/0000 00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Location = new System.Drawing.Point(22, 23);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(131, 21);
            this.lblFechaHora.TabIndex = 13;
            this.lblFechaHora.Text = "Fecha y Hora (*)";
            // 
            // funcionBindingSource
            // 
            this.funcionBindingSource.DataSource = typeof(TPG6.Entidades.Funcion);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(47, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(138, 30);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Alta Función";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AltaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(745, 390);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelBackAltaFuncion);
            this.Name = "AltaFuncion";
            this.Text = "AltaFuncion";
            this.Load += new System.EventHandler(this.AltaFuncion_Load);
            this.panelBackAltaFuncion.ResumeLayout(false);
            this.panelBackAltaFuncion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBackAltaFuncion;
        private Label lblTitulo;
        private Label lblFechaHora;
        private Label lblSala;
        private MaskedTextBox maskedTextBox1;
        private BindingSource funcionBindingSource;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label lblEstado;
        private Label lblPelicula;
        private Button btnCargarFuncion;
        private ComboBox cmbEstado;
        private ComboBox cmbPeli;
        private ComboBox cmbSala;
        private ComboBox cmbFechaFin;
        private ComboBox cmbFechaInicio;
        private Label lblError;
    }
}