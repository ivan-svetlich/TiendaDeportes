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
    public partial class FormListCarro : Form
    {
        Producto producto = null;
        bool wait = false;
        //delegado
        public delegate void DelegadoQuitarProducto();
        public static event DelegadoQuitarProducto EventoQuitarProducto;
        public FormListCarro()
        {
            InitializeComponent();
            //suscripcion a eventos
            FormAddCarro.EventoAddCarro += ListaCarro;
            FormAddPromo.EventoNuevaPromo += ListaCarro;
            FormFinalizar.EventoCompraFinalizada += ListaCarro;
            ListaCarro();
        }
        private void ListaCarro()
        {
            dataGridViewProd.DataSource = null;
            dataGridViewProd.Rows.Clear();
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("es-AR");
            string[] fila;
            foreach (Producto p in Global.MiTienda.Compra.Carro.ListaProductos)
            {
                fila = new string[] { p.Categoria, p.Descripcion, p.Marca, p.Talle, p.Color, p.Precio.ToString("C", culture), p.Descuento.ToString() + "%", p.PrecioFinal().ToString("C", culture) };
                dataGridViewProd.Rows.Add(fila);
            }
            textBoxTotal.Text = Global.MiTienda.Compra.Carro.CalcularTotal().ToString("C", culture);
        }
        private void QuitarProducto()
        {
            if (producto != null)
            {
                wait = true;
                Global.MiTienda.Compra.Carro.Quitar(producto);
                ListaCarro();
                string mensaje = "Operación exitosa";
                string caption = "El producto fue quitado correctamente";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
                if (EventoQuitarProducto != null)
                {
                    EventoQuitarProducto();
                }
                wait = false;
            }
            else
            {
                string mensaje = "Ha ocurrido un error";
                string caption = "No hay ningún producto seleccionado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
            
        }
        private void dataGridViewProd_SelectionChanged(object sender, EventArgs e)
        {
            int size = Global.MiTienda.Compra.Carro.ListaProductos.Count;
            if (size > 0 && !wait)
            {
                int index = dataGridViewProd.CurrentCell.RowIndex;
                producto = Global.MiTienda.Compra.Carro.ListaProductos[index];
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            QuitarProducto();
        }
    }
}
