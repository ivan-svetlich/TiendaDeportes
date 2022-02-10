using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace TiendaDeportes
{
    public partial class FormCliente : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("es-AR");
        Cliente miCliente;
        //delegado
        public delegate void DelegadoFormPago<MiForm>() where MiForm : Form, new();
        public static event DelegadoFormPago<FormPago> EventoFormPago;
        public FormCliente()
        {
            InitializeComponent();
            ShowDatos(false);
        }
        private void BuscarCliente(int dni)
        {
            miCliente = Global.MiTienda.ListaClientes.Where(cliente => cliente.Dni == dni).FirstOrDefault();
            if (miCliente != null)
            {
                DatosCliente(miCliente);
            }
            else
            {
                NuevoCliente(dni);
            }
        }
        private void DatosCliente(Cliente cliente)
        {
            ShowDatos(true);

            textBoxNombre.Text = cliente.Nombre;
            textBoxApellido.Text = cliente.Apellido;
            textBoxNacimiento.Text = cliente.Nacimiento.ToShortDateString();
            textBoxTotal.Text = cliente.TotalGastado.ToString("C", culture);
            FormFinalizar.EventoCompraFinalizada += Reset;
        }
        private void ShowDatos(bool c)
        {
            labelDatos.Visible = c;
            labelNombre.Visible = c;
            labelApellido.Visible = c;
            labelNacimiento.Visible = c;
            labelTotal.Visible = c;
            textBoxNombre.Visible = c;
            textBoxApellido.Visible = c;
            textBoxNacimiento.Visible = c;
            textBoxTotal.Visible = c;
            buttonContinuar.Visible = c;
            buttonReset.Visible = c;
        }
        private void NuevoCliente(int dni)
        {
            using (var form = new FormNuevoCliente(dni))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string nombre = form.Nombre;
                    string apellido = form.Apellido;
                    DateTime nacimiento = form.Nacimiento;

                    try
                    {
                        //Agrego nuevo cliente
                        miCliente = new Cliente(nombre, apellido, dni, nacimiento);
                        Global.MiTienda.AddCliente(miCliente);

                        string mensaje = "Operación exitosa";
                        string caption = "El cliente fue agregado a la base de datos";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                        DatosCliente(miCliente);
                    }
                    catch
                    {
                        string mensaje = "Ha ocurrido un error";
                        string caption = "El cliente no pudo ser agregado";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                    }
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int dni;
            string strDNI = textBoxDNI.Text;
            if (strDNI == "")
            {
                string mensaje = "Ha ocurrido un error";
                string caption = "Hay campos sin completar";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
            else
            {
                bool success = int.TryParse(strDNI, out dni);
                if (success)
                {
                    BuscarCliente(dni);
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

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (EventoFormPago != null)
            {
                Global.MiTienda.Compra.SetCliente(miCliente);
                EventoFormPago();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            ShowDatos(false);
            textBoxDNI.Text = "";
        }
    }
}
