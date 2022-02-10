using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeportes
{
    public partial class FormAddProd : Form
    {
        //delegado
        public delegate void DelegadoNuevoProducto();
        public static event DelegadoNuevoProducto EventoNuevoProducto;
        public FormAddProd()
        {
            InitializeComponent();
            DesactivarControles();
            foreach(string categoria in Global.MiTienda.CategoriasProducto())
            {
                comboBoxCategoria.Items.Add(categoria);
            }
        }

        private void ActivarControles()
        {
            comboBoxTalle.Enabled = true;
            comboBoxColor.Enabled = true;

            if (comboBoxCategoria.Text == "Calzado")
            {
                foreach(string talle in Producto.GetTallesCalzado())
                {
                    comboBoxTalle.Items.Add(talle);
                }

            }
            if (comboBoxCategoria.Text == "Ropa")
            {
                foreach (string talle in Producto.GetTallesRopa())
                {
                    comboBoxTalle.Items.Add(talle);
                }
            }
            foreach (string color in Producto.GetColores())
            {
                comboBoxColor.Items.Add(color);
            }
        }
        private void DesactivarControles()
        {
            comboBoxTalle.Enabled = false;
            comboBoxColor.Enabled = false;
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = comboBoxCategoria.Text;
            comboBoxTalle.Items.Clear();
            comboBoxTalle.Text = "";
            comboBoxColor.Items.Clear();
            comboBoxColor.Text = "";

            if (categoria == "Calzado" || categoria == "Ropa")
            {
                ActivarControles();
            }
            else
            {
                DesactivarControles();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetearControles();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }
        private void AgregarProducto()
        {
            string mensaje;
            string caption;
            try
            {
                string categoria = comboBoxCategoria.Text;
                string descripcion = textBoxDescripcion.Text;
                string marca = textBoxMarca.Text;
                string talle = comboBoxTalle.Text;
                string color = comboBoxColor.Text;
                double precio = double.Parse(textBoxPrecio.Text);

                if (categoria == "" || descripcion == "" || marca == "" || ((talle == "" || color == "") && categoria != "Genérico") || precio == 0)
                {
                    mensaje = "Revise los datos ingresados";
                    caption = "Hay campos sin completar";
                    Mensaje(mensaje, caption);
                }
                else
                {
                    //Agrego nuevo producto
                    int flag = Global.MiTienda.NuevoProducto(categoria, descripcion, marca, talle, color, precio);
                    if (flag == 1)
                    {
                        mensaje = "El producto fue dado de alta correctamente";
                        caption = "Alta Producto";
                        ResetearControles();
                        Mensaje(mensaje, caption);
                        if (EventoNuevoProducto != null)
                        {
                            //evento
                            EventoNuevoProducto();
                        }

                    }
                    if (flag == -1)
                    {
                        mensaje = "Revise los datos ingresados";
                        caption = "ha ocurrido un error";
                        Mensaje(mensaje, caption);
                    }
                }

            }
            catch (FormatException)
            {
                mensaje = "Revise los datos ingresados";
                caption = "ha ocurrido un error";
                Mensaje(mensaje, caption);
            }
        }

        private void Mensaje(string mensaje, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(mensaje, caption, buttons);
        }

        private void ResetearControles()
        {
            comboBoxCategoria.SelectedIndex = -1;
            textBoxDescripcion.Text = "";
            textBoxMarca.Text = "";
            comboBoxTalle.SelectedIndex = -1;
            comboBoxColor.SelectedIndex = -1;
            textBoxPrecio.Text = "";
        }
    }
}
