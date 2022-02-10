using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeportes
{
    public partial class FormAddTarjeta : Form
    {
        Tarjeta tarjeta;
        //Delegados 
        public delegate void DelegadoNuevaTarjeta();
        public static event DelegadoNuevaTarjeta EventoNuevaTarjeta;
        public delegate void DelegadoNuevaFormaPago(Tarjeta card);
        public static event DelegadoNuevaFormaPago EventoNuevaFormaPago;
        public FormAddTarjeta()
        {
            InitializeComponent();
            panelFormasPago.Visible = false;
        }
        private void AgregarTarjeta()
        {
            try
            {
                string nombre = textBoxNombre.Text;
                string banco = textBoxBanco.Text;
                bool yaExiste = false;

                if(nombre != "" && banco != "")
                {
                    foreach(Tarjeta _tarjeta in Global.MiTienda.ListaTarjetas)
                    {
                        if (nombre == _tarjeta.Nombre && banco == _tarjeta.Banco)
                        {
                            //mensaje
                            string mensaje = "La tarjeta ya existe";
                            string caption = "¿Desea agregar formas de pago?";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult resultado = MessageBox.Show(caption, mensaje, buttons);
                            yaExiste = true;
                            if (resultado == DialogResult.Yes)
                            {
                                tarjeta = _tarjeta;
                                panelFormasPago.Visible = true;
                                ListaFormasPago();
                            }
                            else
                            {
                                textBoxNombre.Text = "";
                                textBoxBanco.Text = "";
                            }
                        }
                    }
                    if (!yaExiste)
                    {
                        try
                        {
                            int flag = Global.MiTienda.NuevaTarjeta(nombre, banco);
                            if (flag == 1)
                            {
                                tarjeta = Global.MiTienda.ListaTarjetas[Global.MiTienda.ListaTarjetas.Count - 1];
                                panelFormasPago.Visible = true;
                                ListaFormasPago();
                                if (EventoNuevaTarjeta != null)
                                {
                                    //Evento
                                    EventoNuevaTarjeta();
                                }
                            }
                        }
                        catch
                        {
                            //mensaje
                            string mensaje = "Ha ocurrido un error";
                            string caption = "Revise los datos ingresados";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(caption, mensaje, buttons);
                        }
                    }
                }
                else
                {
                    //mensaje
                    string mensaje = "Ha ocurrido un error";
                    string caption = "Hay campos sin completar";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(caption, mensaje, buttons);
                }
            }
            catch
            {
                //mensaje
                string mensaje = "Ha ocurrido un error";
                string caption = "Revise los datos ingresados";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
        }
        private void AgregarFormaPago()
        {
            using (var form = new FormFormaPago())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int cuotas = form.Cuotas;
                    double interes = form.Interes;
                   
                    try
                    {
                        int flag = tarjeta.AddFormaPago(cuotas, interes);
                        if (flag == 1)
                        {
                            if (EventoNuevaFormaPago != null)
                            {
                                //Evento
                                EventoNuevaFormaPago(tarjeta);
                            }
                            //mensaje
                            string mensaje = "Operación exitosa";
                            string caption = "La forma de pago fue agregada correctamente";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(caption, mensaje, buttons);
                        }
                        else
                        {
                            //mensaje
                            string mensaje = "";
                            string caption = "La forma de pago ya existe";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(caption, mensaje, buttons);
                        }
                        
                        ListaFormasPago();
                    }
                    catch
                    {
                        //mensaje
                        string mensaje = "Ha ocurrido un error";
                        string caption = "La forma de pago no pudo ser agregada";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                    }
                }
            }
        }
        private void ListaFormasPago()
        {
            dataGridViewFP.Rows.Clear();
            for (int i = 0; i < tarjeta.FormasPago.Count; i++)
            {
                int cuotas = tarjeta.FormasPago[i].Cuotas;
                double interes = tarjeta.FormasPago[i].Interes;

                string[] row = new string[] { cuotas.ToString(), interes.ToString() + "%" };
                dataGridViewFP.Rows.Add(row);
            }
            buttonNum.Text = (tarjeta.FormasPago.Count).ToString();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarTarjeta();
        }
        
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxBanco.Text = "";
            panelFormasPago.Visible = false;
        }

        private void buttonAddFP_Click(object sender, EventArgs e)
        {
            AgregarFormaPago();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxBanco.Text = "";
            panelFormasPago.Visible = false;
        }
    }
}
