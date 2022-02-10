using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace TiendaDeportes
{
    public partial class FormInfo : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("es-AR");
        public FormInfo()
        {
            InitializeComponent();
            //Suscripcion a eventos
            FormFinalizar.EventoCompraFinalizada += CargarDatos;
            CargarDatos();
        }
        private void CargarDatos()
        {
            Total();
            ListaTarjetas();
            ListaClientes();
        }
        private void ListaTarjetas()
        {
            dataGridViewTarjetas.Rows.Clear();
            
            foreach (Tarjeta tarjeta in Global.MiTienda.ListaTarjetas)
            {
                string nombre = tarjeta.Nombre;
                string banco = tarjeta.Banco;
                string total = tarjeta.TotalVendido.ToString("C", culture);
                string[] fila = new string[] { nombre, banco, total };
                dataGridViewTarjetas.Rows.Add(fila);
            }
            //Adaptar altura de DataGridView a la cantidad de filas
            var height = 40;
            foreach (DataGridViewRow dr in dataGridViewTarjetas.Rows)
            {
                height += dr.Height;
            }
            dataGridViewTarjetas.Height = height;
        }
        private void ListaClientes()
        {
            dataGridViewClientes.Rows.Clear();

            foreach (Cliente cliente in Global.MiTienda.ListaClientes)
            {
                string nombre = cliente.Nombre;
                string apellido = cliente.Apellido;
                string dni = cliente.Dni.ToString("N0", culture);
                string total = cliente.TotalGastado.ToString("C", culture);
                string[] fila = new string[] { nombre, apellido, dni, total };
                dataGridViewClientes.Rows.Add(fila);
            }
            //Adaptar altura de DataGridView a la cantidad de filas
            var height = 40;
            foreach (DataGridViewRow dr in dataGridViewClientes.Rows)
            {
                height += dr.Height;
            }
            dataGridViewClientes.Height = height;
        }
        private void Total()
        {
            string total = Global.MiTienda.TotalVendido.ToString("C", culture);
            textBoxTotal.Text = total;
        }
    }
}
