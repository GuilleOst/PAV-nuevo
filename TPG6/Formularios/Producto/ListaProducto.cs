﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG6.Entidades;
using TPG6.AccesoADatos;
namespace TPG6.Formularios.Producto
{
    public partial class ListaProducto : Form
    {
        public ListaProducto()
        {
            InitializeComponent();
        }

        private void ListaProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaProducto(sender, e);
        }

        private void CargarGrilla()
        {
            try
            {
                gdrConsultarProd.DataSource = AccesoADatos.AD_Producto.ObtenerTablaProducto();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener productos");
            }
        }

 

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombreProducto.Text + "%' and Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }

        private void txtBuscadorTipoProd_TextChanged(object sender, EventArgs e)
        {
            (gdrConsultarProd.DataSource as DataTable).DefaultView.RowFilter = "Convert(nombre, 'System.String') LIKE '" + txtNombreProducto.Text + "%' and Convert(nombreTipoProd, 'System.String') LIKE '" + txtBuscadorTipoProd.Text + "%'";
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            var currentRow = gdrConsultarProd.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = gdrConsultarProd.Rows[currentRow];
            int idProducto = int.Parse(gdrConsultarProd.Rows[currentRow].Cells[0].Value.ToString());

            Entidades.Producto producto = new Entidades.Producto(idProducto, "", "", 1, 0, 0, 1);
            bool estaEnCombo = AD_ComposicionCombo.estaEnCombo(producto);
            bool result;
            if (estaEnCombo)
            {
                var confirmResult = MessageBox.Show("Este Producto pertenece a un Combo, desea eliminarlo ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    result = AD_ComposicionCombo.eliminarProductoCombo(producto);
                    if (result)
                    {
                        MessageBox.Show("Producto eliminado con éxito!");
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                var confirmResult2 = MessageBox.Show("Desea eliminar este Producto ??",
                                     "Confirmación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                {
                    result = AccesoADatos.AD_Producto.eliminarProducto(producto);
                    if (result)
                    {
                        MessageBox.Show("Producto eliminado con éxito!");
                        CargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Main.main1.btnSubComboAltaProducto(sender, e);
        }
    }
}
