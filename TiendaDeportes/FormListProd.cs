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
    public partial class FormListProd : Form
    {
        public FormListProd()
        {
            InitializeComponent();
            //List<Producto> productos = new List<Producto>();
            //ActualizarTabla();
            CargarTabla();
            FormAddProd.EventoNuevoProducto += CargarTabla;
            FormAddPromo.EventoNuevaPromo += CargarTabla;
        }
        private void CargarTabla()
        {
            dataGridViewProd.DataSource = null;
            dataGridViewProd.Rows.Clear();
            string[] fila = new string[6];
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("es-AR");

            foreach (Producto p in Global.MiTienda.ListaProductos)
            {

                fila = new string[] { p.Categoria, p.Descripcion, p.Marca, p.Talle, p.Color, p.Precio.ToString("C", culture), p.Descuento.ToString() + "%" };
                dataGridViewProd.Rows.Add(fila);
            }
        }
        private void ActualizarTabla()
        {          
            var source = new BindingSource();
            var bindingList = Global.MiTienda.ListaProductos;
            source.DataSource = bindingList;
            dataGridViewProd.DataSource = source;
        }
        /*private void ActualizarTabla(Producto p)
        {
            string[] fila = new string[6];
            if (p is ProductoGenerico)
            {
                fila = new string[] { p.Descripcion, p.Marca, "---", "---", p.Precio.ToString(), p.Descuento.ToString() };
            }
            else if (p is ProductoCalzado)
            {
                ProductoCalzado p1 = (ProductoCalzado)p;
                fila = new string[] { p1.Descripcion, p1.Marca, p1.Talle, p1.Color, p1.Precio.ToString(), p1.Descuento.ToString() };
            }
            else if (p is ProductoRopa)
            {
                ProductoRopa p2 = (ProductoRopa)p;
                fila = new string[] { p2.Descripcion, p2.Marca, p2.Talle, p2.Color, p2.Precio.ToString(), p2.Descuento.ToString() };
            }
            dataGridViewProd.Rows.Add(fila);
        }*/
    }
}
