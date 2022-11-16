using System.Windows.Forms;

namespace TPG6.Formularios.Actores
{
    partial class AltaActor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodActor = new System.Windows.Forms.TextBox();
            this.btnLimpiarCamposActores = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizarActor = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistroActor = new System.Windows.Forms.Label();
            this.lblActualizarActor = new System.Windows.Forms.Label();
            this.dtgActualizarActor = new System.Windows.Forms.DataGridView();
            this.codActor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActualizarActor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodActor);
            this.panel1.Controls.Add(this.btnLimpiarCamposActores);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnActualizarActor);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(27, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 121);
            this.panel1.TabIndex = 2;
            // 
            // txtCodActor
            // 
            this.txtCodActor.Location = new System.Drawing.Point(51, 74);
            this.txtCodActor.Name = "txtCodActor";
            this.txtCodActor.Size = new System.Drawing.Size(26, 20);
            this.txtCodActor.TabIndex = 5;
            this.txtCodActor.Text = "-1";
            this.txtCodActor.Visible = false;
            // 
            // btnLimpiarCamposActores
            // 
            this.btnLimpiarCamposActores.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarCamposActores.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCamposActores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCamposActores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarCamposActores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCamposActores.Location = new System.Drawing.Point(267, 81);
            this.btnLimpiarCamposActores.Name = "btnLimpiarCamposActores";
            this.btnLimpiarCamposActores.Size = new System.Drawing.Size(130, 23);
            this.btnLimpiarCamposActores.TabIndex = 2;
            this.btnLimpiarCamposActores.Text = "Limpiar Campos";
            this.btnLimpiarCamposActores.UseVisualStyleBackColor = false;
            this.btnLimpiarCamposActores.Click += new System.EventHandler(this.btnLimpiarCamposActores_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(511, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizarActor
            // 
            this.btnActualizarActor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnActualizarActor.FlatAppearance.BorderSize = 0;
            this.btnActualizarActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarActor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizarActor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarActor.Location = new System.Drawing.Point(411, 81);
            this.btnActualizarActor.Name = "btnActualizarActor";
            this.btnActualizarActor.Size = new System.Drawing.Size(87, 23);
            this.btnActualizarActor.TabIndex = 3;
            this.btnActualizarActor.Text = "Actualizar";
            this.btnActualizarActor.UseVisualStyleBackColor = false;
            this.btnActualizarActor.Click += new System.EventHandler(this.btnActualizarActor_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(352, 25);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(273, 29);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 19);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(21, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRegistroActor
            // 
            this.lblRegistroActor.AutoSize = true;
            this.lblRegistroActor.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroActor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblRegistroActor.ForeColor = System.Drawing.Color.Transparent;
            this.lblRegistroActor.Location = new System.Drawing.Point(31, 9);
            this.lblRegistroActor.Name = "lblRegistroActor";
            this.lblRegistroActor.Size = new System.Drawing.Size(84, 28);
            this.lblRegistroActor.TabIndex = 3;
            this.lblRegistroActor.Text = "Actores";
            // 
            // lblActualizarActor
            // 
            this.lblActualizarActor.AutoSize = true;
            this.lblActualizarActor.BackColor = System.Drawing.Color.Transparent;
            this.lblActualizarActor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblActualizarActor.ForeColor = System.Drawing.Color.White;
            this.lblActualizarActor.Location = new System.Drawing.Point(460, 164);
            this.lblActualizarActor.Name = "lblActualizarActor";
            this.lblActualizarActor.Size = new System.Drawing.Size(166, 28);
            this.lblActualizarActor.TabIndex = 5;
            this.lblActualizarActor.Text = "Actualizar Actor";
            // 
            // dtgActualizarActor
            // 
            this.dtgActualizarActor.AllowUserToAddRows = false;
            this.dtgActualizarActor.AllowUserToDeleteRows = false;
            this.dtgActualizarActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActualizarActor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codActor,
            this.Nombre,
            this.Apellido});
            this.dtgActualizarActor.Location = new System.Drawing.Point(53, 195);
            this.dtgActualizarActor.Name = "dtgActualizarActor";
            this.dtgActualizarActor.ReadOnly = true;
            this.dtgActualizarActor.RowTemplate.Height = 25;
            this.dtgActualizarActor.Size = new System.Drawing.Size(547, 160);
            this.dtgActualizarActor.TabIndex = 5;
            this.dtgActualizarActor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgActualizarActor_CellClick);
            // 
            // codActor
            // 
            this.codActor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codActor.DataPropertyName = "codActor";
            this.codActor.HeaderText = "codActor";
            this.codActor.Name = "codActor";
            this.codActor.ReadOnly = true;
            this.codActor.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(32, 85);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dtgActualizarActor);
            this.panel2.Controls.Add(this.lblActualizarActor);
            this.panel2.Location = new System.Drawing.Point(9, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 398);
            this.panel2.TabIndex = 7;
            // 
            // AltaActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(686, 482);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRegistroActor);
            this.Controls.Add(this.panel2);
            this.Name = "AltaActor";
            this.Text = "AltaActor";
            this.Load += new System.EventHandler(this.AltaActor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActualizarActor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblRegistroActor;
        private Button btnActualizarActor;
        private Button btnLimpiarCamposActores;
        private Button btnAgregar;
        private Label lblActualizarActor;
        private DataGridView dtgActualizarActor;
        private DataGridViewTextBoxColumn codActor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private Label lblError;
        private TextBox txtCodActor;
        private Panel panel2;
    }
}