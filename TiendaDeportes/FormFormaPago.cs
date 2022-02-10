using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeportes
{
    public partial class FormFormaPago : Form
    {
        public int Cuotas { get; set; }
        public double Interes { get; set; }
        public FormFormaPago()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string sCuotas = textBoxCuotas.Text;
            string sInteres = textBoxInteres.Text;
            if (sCuotas != "" && sInteres != "")
            {
                try
                {
                    int _cuotas = int.Parse(textBoxCuotas.Text);
                    double _interes = double.Parse(textBoxInteres.Text);
                    if (_cuotas < 1)
                    {
                        string mensaje = "Ha ocurrido un error";
                        string caption = "La cantidad de cuotas no puede ser menor a 1";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                    }
                    else if (_interes < 0)
                    {
                        string mensaje = "Ha ocurrido un error";
                        string caption = "El interés no puede ser menor a 0";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(caption, mensaje, buttons);
                    }
                    else
                    {
                        Cuotas = _cuotas;
                        Interes = _interes;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch
                {
                    string mensaje = "Ha ocurrido un error";
                    string caption = "Revise los datos ingresados";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(caption, mensaje, buttons);
                }
            }
            else
            {
                string mensaje = "Ha ocurrido un error";
                string caption = "Hay campos sin completar";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
