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
    public partial class FormFinalizar : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("es-AR");
        //Delegado
        public delegate void DelegadoCompraFinalizada();
        public static event DelegadoCompraFinalizada EventoCompraFinalizada;
        public FormFinalizar()
        {
            InitializeComponent();
            //Suscripcion a eventos
            FormAddCarro.EventoAddCarro += ListaCarro;
            FormAddPromo.EventoNuevaPromo += ListaCarro;
            FormListCarro.EventoQuitarProducto += ListaCarro;
            Datos();
            ListaCarro();
        }
        private void ListaCarro()
        {
            if (dataGridViewProd.Columns.Count != 0)
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
            }
        }
        private void Datos()
        {
            string nombre = Global.MiTienda.Compra.Cliente.Nombre;
            string apellido = Global.MiTienda.Compra.Cliente.Apellido;
            string cliente = nombre + " " + apellido;
            string fecha = DateTime.Today.ToShortDateString();
            string subtotal = Global.MiTienda.Compra.Carro.CalcularTotal().ToString("C", culture);
            string interes = (Global.MiTienda.Compra.Carro.CalcularTotal()*Global.MiTienda.Compra.FormaPago.InteresConBeneficio/100).ToString("C", culture);
            string total = Global.MiTienda.Compra.PrecioFinal().ToString("C", culture);

            textBoxCliente.Text = cliente;
            textBoxFecha.Text = fecha;
            textBoxSubotal.Text = subtotal;
            textBoxInteres.Text = interes;
            textBoxTotal.Text = total;

            int numCuotas = Global.MiTienda.Compra.FormaPago.Cuotas;
            double cuota = Global.MiTienda.Compra.PrecioFinal() / numCuotas;
            labelCuotas.Text = "A pagar en " + numCuotas.ToString() + " cuotas de $" + cuota.ToString("0.00");
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Global.MiTienda.FinalizarCompra();
            string mensaje = "Operación exitosa";
            string caption = "¡Gracias por su compra!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(caption, mensaje, buttons);
            EventoCompraFinalizada();
            this.Close();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
