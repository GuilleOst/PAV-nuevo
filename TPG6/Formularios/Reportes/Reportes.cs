using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TPG6.Entidades;
using TPG6.AccesoADatos;
using TPG6.Reportes;
using TPG6.Reportes.Funcion;
using TPG6.Reportes.Tarifa;
using TPG6.Reportes.Entrada;
using TPG6.Estadisticas.Funcion;
using TPG6.Estadisticas.TicketEntrada;
using TPG6.Estadisticas.Empleado;
using TPG6.Estadisticas.PrecioDescuento;


namespace TPG6.Formularios.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReporteFuncion formulario = new ReporteFuncion();
            formulario.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReporteTarifa formulario = new ReporteTarifa();
            formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteEntrada formulario = new ReporteEntrada();
            formulario.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            EstadisticaEmpleado formulario = new EstadisticaEmpleado();
            formulario.ShowDialog();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            EstadisticaFuncion formulario = new EstadisticaFuncion();
            formulario.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EstadisticaPrecioDescuento formulario = new EstadisticaPrecioDescuento();
            formulario.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            EstadisticaTicketEntrada formulario = new EstadisticaTicketEntrada();
            formulario.ShowDialog();
        }
    }
}
