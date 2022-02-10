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
    public partial class FormAddPromo : Form
    {
        //delegado
        public delegate void DelegadoNuevaPromo();
        public static event DelegadoNuevaPromo EventoNuevaPromo;
        public FormAddPromo()
        {
            InitializeComponent();
            CargarTabla();
            //suscripcion a eventos
            FormAddProd.EventoNuevoProducto += CargarTabla;
            EventoNuevaPromo += CargarTabla;
        }
        private void CargarTabla()
        {
            dataGridViewProd.DataSource = null; 
            dataGridViewProd.Rows.Clear();
            if (dataGridViewProd.Columns[0].Name == "X")
            {
                dataGridViewProd.Columns.RemoveAt(0);
            }
            string[] fila = new string[6];
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture("es-AR");

            foreach (Producto p in Global.MiTienda.ListaProductos)
            {
                double precioFinal = p.PrecioFinal();
                fila = new string[] { p.Categoria, p.Descripcion, p.Marca, p.Talle, p.Color, p.Precio.ToString("C", culture), p.Descuento.ToString() + "%", precioFinal.ToString("C", culture) };
                dataGridViewProd.Rows.Add(fila);
            }
            AddCheckBox();
            //adaptar altura de la tabla
            var height = 40;
            foreach (DataGridViewRow dr in dataGridViewProd.Rows)
            {
                height += dr.Height;
            }
            dataGridViewProd.Height = height;
        }

        private void AddCheckBox()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "X";
            checkColumn.Width = 20;
            checkColumn.MinimumWidth = 20;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 20; 
            dataGridViewProd.Columns.Insert(0, checkColumn);
        }

        private void AddPromo()
        {
            string mensaje;
            string caption;
            int i = 0;
            bool check = false;
            try
            {
                double descuento = double.Parse(textBoxDescuento.Text);
                if(descuento>=0 && descuento <= 100)
                {
                    foreach (DataGridViewRow fila in dataGridViewProd.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells["X"].Value))
                        {
                            try
                            {
                                int flag = Global.MiTienda.AddPromo(i, descuento);
                                if (flag == -1)
                                {
                                    mensaje = "Revise los datos ingresados";
                                    caption = "Ha ocurrido un error";
                                    Mensaje(mensaje, caption);
                                }
                                check = true;
                            }
                            catch
                            {
                                mensaje = "Revise los datos ingresados";
                                caption = "Ha ocurrido un error";
                                Mensaje(mensaje, caption);
                            }

                        }
                        i++;
                    }
                    if (check)
                    {
                        EventoNuevaPromo();
                        mensaje = "El descuento fue agregado correctamente";
                        caption = "Alta Promoción";
                        Mensaje(mensaje, caption);
                        textBoxDescuento.Text = "";
                    }
                    else
                    {
                        mensaje = "No hay ningún producto seleccionado";
                        caption = "Alta Promoción";
                        Mensaje(mensaje, caption);
                    }
                }
                else
                {
                    mensaje = "El descuento debe ser un número entre 0 y 100";
                    caption = "Revise los datos ingresados";
                    Mensaje(mensaje, caption);
                }
                
            }
            catch
            {
                mensaje = "Revise los datos ingresados";
                caption = "Ha ocurrido un error";
                Mensaje(mensaje, caption);
            }
            
        }

        private void QuitarPromo()
        {
            string mensaje;
            string caption;
            int i = 0;
            bool check = false;

            foreach (DataGridViewRow fila in dataGridViewProd.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["X"].Value))
                {
                    try
                    {
                        int flag = Global.MiTienda.AddPromo(i, 0);
                        if (flag == -1)
                        {
                            mensaje = "Revise los datos ingresados";
                            caption = "Ha ocurrido un error";
                            Mensaje(mensaje, caption);
                        }
                        check = true;
                    }
                    catch
                    {
                        mensaje = "Revise los datos ingresados";
                        caption = "Ha ocurrido un error";
                        Mensaje(mensaje, caption);
                    }

                }
                i++;
            }
            if (check)
            {
                EventoNuevaPromo();
                mensaje = "El descuento fue quitado correctamente";
                caption = "Baja Promoción";
                Mensaje(mensaje, caption);
                textBoxDescuento.Text = "";
            }
            else
            {
                mensaje = "No hay ningún producto seleccionado";
                caption = "Baja Promoción";
                Mensaje(mensaje, caption);
            }
        }
        private void Mensaje(string mensaje, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(mensaje, caption, buttons);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AddPromo();
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea continuar?";
            string caption = "El descuento será removido";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, caption, buttons);

            if (result == DialogResult.Yes)
            {
                QuitarPromo();
            }
        }

    }
}
