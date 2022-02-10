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
    public partial class FormListPromos : Form
    {
        public FormListPromos()
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
                if (p.Descuento != 0)
                {
                    fila = new string[] { p.Categoria, p.Descripcion, p.Marca, p.Talle, p.Color, p.Precio.ToString("C", culture), p.Descuento.ToString() + "%" };
                    dataGridViewProd.Rows.Add(fila);
                }
            }
        }
        private void ActualizarTabla()
        {
            var source = new BindingSource();
            var bindingList = Global.MiTienda.ListaProductos;
            source.DataSource = bindingList;
            dataGridViewProd.DataSource = source;
        }
    }
}
