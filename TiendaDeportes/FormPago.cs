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
    public partial class FormPago : Form
    {
        bool filtro = false;
        Tarjeta tarjeta;
        FormaPago formaPago;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("es-AR");
        //delegado
        public delegate void DelegadoFormFinalizar<MiForm>() where MiForm : Form, new();
        public static event DelegadoFormFinalizar<FormFinalizar> EventoFormFinalizar;
        public FormPago()
        {
            InitializeComponent();
            comboBoxFiltro.Items.Add("Todas las tarjetas");
            comboBoxFiltro.Items.Add("Solo tarjetas con beneficio");
            comboBoxFiltro.SelectedItem = "Todas las tarjetas";
            //suscripcion a eventos
            FormAddTarjeta.EventoNuevaTarjeta += ListaTarjetas;
            FormAddTarjeta.EventoNuevaFormaPago += ListaFormasPago;
            FormFinalizar.EventoCompraFinalizada += this.Close;
        }
        private void ListaTarjetas()
        {
            dataGridViewTarjetas.Rows.Clear();
            bool show = true;

            foreach (Tarjeta tarjeta in Global.MiTienda.ListaTarjetas)
            {
                if (filtro)
                {
                    show = tarjeta.TieneBeneficio();
                }
                if (show)
                {
                    string nombre = tarjeta.Nombre;
                    string banco = tarjeta.Banco;
                    string total = tarjeta.TotalVendido.ToString("C", culture);
                    string[] fila = new string[] { nombre, banco, total };
                    dataGridViewTarjetas.Rows.Add(fila);
                }

            }
        }
        private void ListaFormasPago(Tarjeta _tarjeta)
        {
            if (_tarjeta != null)
            {
                dataGridViewFP.Rows.Clear();
                foreach (FormaPago fp in _tarjeta.FormasPago)
                {
                    string cuotas = fp.Cuotas.ToString();
                    string interes = fp.Interes.ToString() + "%";
                    string beneficio;
                    if (fp.Beneficio)
                    {
                        beneficio = fp.InteresConBeneficio.ToString() + "%";
                    }
                    else
                    {
                        beneficio = "---";
                    }
                    string[] fila = new string[] { cuotas, interes, beneficio };
                    dataGridViewFP.Rows.Add(fila);
                }
            }
        }
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltro.SelectedItem.ToString() == "Solo tarjetas con beneficio")
            {
                filtro = true;
            }
            else
            {
                filtro = false;
            }
            ListaTarjetas();
        }
        private void dataGridViewTarjetas_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewTarjetas.CurrentCell.RowIndex;
            if (index >= 0 && index < Global.MiTienda.ListaTarjetas.Count)
            {
                ListaFormasPago(GetTarjeta(index));
            }
        }
        private Tarjeta GetTarjeta(int index)
        {
            tarjeta = Global.MiTienda.ListaTarjetas[index];
            return tarjeta;
        }
        private void dataGridViewFP_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewFP.CurrentCell.RowIndex;
            if (tarjeta.FormasPago != null)
            {
                if (index >= 0 && index < tarjeta.FormasPago.Count)
                {
                    formaPago = tarjeta.FormasPago[index];
                    CalcularTotal();
                }
            }           
        }
        private void CalcularTotal()
        {
            Global.MiTienda.Compra.SetTarjeta(tarjeta);
            Global.MiTienda.Compra.SetFormaPago(formaPago);
            double total = Global.MiTienda.Compra.PrecioFinal();
            textBoxTotal.Text = total.ToString("C", culture);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (formaPago != null)
            {
                if (EventoFormFinalizar != null)
                {
                    EventoFormFinalizar();
                }
            }
            else
            {
                string mensaje = "Ha ocurrido un error";
                string caption = "Antes de continuar seleccione una forma de pago";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
        }
    }
}
