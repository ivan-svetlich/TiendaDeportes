using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeportes
{
    public partial class FormNuevoCliente : Form
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }

        public FormNuevoCliente(int dni)
        {
            InitializeComponent();
            textBoxDNI.Text = dni.ToString();
        }
        private void Datos()
        {
            string sNombre = textBoxNombre.Text;
            string sApellido = textBoxApellido.Text;
            Nacimiento = dateTimePickerNacimiento.Value;

            if(sNombre == "" || sApellido == "")
            {
                string mensaje = "Ha ocurrido un error";
                string caption = "Hay campos sin completar";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
            else
            {
                Nombre = sNombre;
                Apellido = sApellido;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Datos();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
