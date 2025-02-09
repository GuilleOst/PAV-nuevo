﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG6.Entidades;
using TPG6.AccesoADatos;

namespace TPG6.Formularios.Tarjeta
{
    public partial class ListaTarjeta : Form
    {
        public ListaTarjeta()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void ListaTarjeta_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            try
            {
                dgvTarjetas.DataSource = AD_Tarjeta.ObtenerTablaTarjeta();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener las tarjetas.");
            }
        }

        private void btnRegistrarTarjeta_Click(object sender, EventArgs e)
        {
            Entidades.Tarjeta tar = new Entidades.Tarjeta(0, "", "", 0, "", 3);

            Main.main1.btnSubAltaTarjeta(tar);
        }

            //if (txtCodTarjeta.Text.Equals(""))
            //{
            //    MessageBox.Show("Ingrese numero de tarjeta");
            //    txtCodTarjeta.Focus();
            //}

            //else if (txtNombreTarjeta.Text.Equals(""))
            //{
            //    MessageBox.Show("Ingrese nombre");
            //    txtNombreTarjeta.Focus();
            //}

            //else if (txtBancoTarjeta.Text.Equals(""))
            //{
            //    MessageBox.Show("Ingrese banco");
            //    txtBancoTarjeta.Focus();
            //}

        //    else
        //    {
        //        if (ExisteEnGrilla(txtCodTarjeta.Text) == true)
        //        {
        //            String codTarjeta = txtCodTarjeta.Text;
        //            String nombreTarjeta = txtNombreTarjeta.Text;
        //            String descripcionTarjeta = txtDescripcionTarjeta.Text;
        //            String bancoTarjeta = txtBancoTarjeta.Text;

        //            MessageBox.Show("Tarjeta registrada correctamente");
        //            LimpiarDatos();
        //            Tarjetas tarj = new Tarjetas(codTarjeta, nombreTarjeta, bancoTarjeta);
        //            agregarTarjeta(tarj);
        //        }

        //        else
        //        { 
        //            MessageBox.Show("Tarjeta ya existente");
        //        }
        //    }
        //}

        //private void agregarTarjeta(Tarjetas tarj)
        //{
        //    DataGridViewRow fila = new DataGridViewRow();

        //    DataGridViewTextBoxCell celdaCodigoTarjeta = new DataGridViewTextBoxCell();
        //    celdaCodigoTarjeta.Value = tarj.codigoTarjeta;
        //    fila.Cells.Add(celdaCodigoTarjeta);

        //    DataGridViewTextBoxCell celdaNombreTarjeta = new DataGridViewTextBoxCell();
        //    celdaNombreTarjeta.Value = tarj.nombreTarjeta;
        //    fila.Cells.Add(celdaNombreTarjeta);

        //    DataGridViewTextBoxCell celdaBancoTarjeta = new DataGridViewTextBoxCell();
        //    celdaBancoTarjeta.Value = tarj.bancoTarjeta;
        //    fila.Cells.Add(celdaBancoTarjeta);

        //    dgvTarjetas.Rows.Add(fila);
        //    txtCodTarjeta.Focus();
        //}

        //private void LimpiarDatos()
        //{
        //    txtCodTarjeta.Text = "";
        //    txtNombreTarjeta.Text = "";
        //    txtDescripcionTarjeta.Text = "";
        //    txtBancoTarjeta.Text = "";  
        //}

        //private void txtCodTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtNombreTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        //}

        //private bool ExisteEnGrilla(string datoABuscar)
        //{
        //    bool resultado = false;
        //    for (int i = 0; i < dgvTarjetas.Rows.Count; i++)
        //    {
        //        if (dgvTarjetas.Rows[i].Cells[0].Value.Equals(datoABuscar))
        //        {
                    //resultado = true;
        //            break;
        //        }
        //    }
        //    return resultado;
        //}

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var currentRow = dgvTarjetas.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dgvTarjetas.Rows[currentRow];
            int codigoTarjeta = int.Parse(dgvTarjetas.Rows[currentRow].Cells[0].Value.ToString());
            string nombre = dgvTarjetas.Rows[currentRow].Cells[1].Value.ToString();
            string descripcion = dgvTarjetas.Rows[currentRow].Cells[2].Value.ToString();
            //int banco = int.Parse(dgvTarjetas.Rows[currentRow].Cells[3].Value.ToString());
            string nombreBanco = dgvTarjetas.Rows[currentRow].Cells[3].Value.ToString();

            Entidades.Tarjeta tarje = new Entidades.Tarjeta (codigoTarjeta, nombre, descripcion, -1, nombreBanco, 2);
            Main.main1.btnSubAltaTarjeta(tarje);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea eliminar esta Tarjeta ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var currentRow = dgvTarjetas.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgvTarjetas.Rows[currentRow];
                int codigoTarjeta = int.Parse(dgvTarjetas.Rows[currentRow].Cells[0].Value.ToString());
                Entidades.Tarjeta tar = new Entidades.Tarjeta(codigoTarjeta, "", "", 0, "", 1);
                AltaTarjeta altaTarjeta = new AltaTarjeta(tar);
                var result = altaTarjeta.cargarTarjeta(tar);
                if (result)
                {
                    MessageBox.Show("Tarjeta eliminada con éxito!");
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscadorTarjeta_TextChanged(object sender, EventArgs e)
        {
            (dgvTarjetas.DataSource as DataTable).DefaultView.RowFilter = "Convert(Nombre, 'System.String') LIKE '" + txtBuscadorTarjeta.Text + "%'";
        }
    }
}