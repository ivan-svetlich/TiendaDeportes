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
    public partial class FormAddCarro : Form
    {
        Producto producto = null;
        //Delegado
        public delegate void DelegadoAddCarro();
        public static event DelegadoAddCarro EventoAddCarro;
        public FormAddCarro()
        {
            InitializeComponent();
            if (Global.MiTienda.Compra == null)
            {
                Global.MiTienda.NuevaCompra();
            }
            //Suscripcion a eventos
            FormAddProd.EventoNuevoProducto += CargarTabla;
            FormAddPromo.EventoNuevaPromo += CargarTabla;
            CargarTabla();
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
        private void Agregar()
        {
            if (producto != null)
            {
                string sCantidad = textBoxCantidad.Text;
                if (sCantidad == "")
                {
                    string mensaje = "Ha ocurrido un error";
                    string caption = "La cantidad debe ser un valor mayor a cero";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(caption, mensaje, buttons);
                }
                else
                {
                    int cantidad;
                    bool success = int.TryParse(textBoxCantidad.Text, out cantidad);
                    if (success)
                    {
                        Global.MiTienda.Compra.Carro.Agregar(producto, cantidad);
                        string mensaje = "Operación exitosa";
                        string caption = "El producto fue agregado correctamente";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                        if (EventoAddCarro != null)
                        {
                            //evento
                            EventoAddCarro();
                        }  
                    }
                    else
                    {
                        string mensaje = "Ha ocurrido un error";
                        string caption = "Revise los datos ingresados";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                    }
                }
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
            int index = dataGridViewProd.CurrentCell.RowIndex;
            producto = Global.MiTienda.ListaProductos[index];
            textBoxCantidad.Text = "1";
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

    }
}
