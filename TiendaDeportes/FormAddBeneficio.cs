using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeportes
{
    public partial class FormAddBeneficio : Form
    {
        Tarjeta tarjeta;
        public FormAddBeneficio()
        {
            InitializeComponent();
            ListaTarjetas();
            //Suscripcion a eventos
            FormAddTarjeta.EventoNuevaTarjeta += ListaTarjetas;
            FormAddTarjeta.EventoNuevaFormaPago += ListaFormasPago;
            ShowControles(false);
        }
        private void ListaTarjetas()
        {
            comboBoxTarjetas.Items.Clear();
            foreach(Tarjeta card in Global.MiTienda.ListaTarjetas)
            {
                string texto = "Tarjeta " + card.Nombre + " - Banco " + card.Banco;
                comboBoxTarjetas.Items.Add(texto);
            }
        }
        private void ListaFormasPago(Tarjeta _tarjeta)
        {
            if (_tarjeta == tarjeta)
            {
                dataGridViewFP.DataSource = null;
                dataGridViewFP.Rows.Clear();
                if (dataGridViewFP.Columns[0].Name == "X")
                {
                    dataGridViewFP.Columns.RemoveAt(0);
                }
                for (int i = 0; i < tarjeta.FormasPago.Count; i++)
                {
                    int cuotas = tarjeta.FormasPago[i].Cuotas;
                    double interes = tarjeta.FormasPago[i].Interes;
                    double interesConBeneficio = tarjeta.FormasPago[i].InteresConBeneficio;

                    string[] row = new string[] { cuotas.ToString(), interes.ToString() + "%", interesConBeneficio.ToString() + "%" };
                    dataGridViewFP.Rows.Add(row);
                }
                AddCheckBox();
                dataGridViewFP.AutoResizeColumns();
            }    
        }
        private void comboBoxTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTarjetas.SelectedItem != null)
            {
                int index = comboBoxTarjetas.SelectedIndex;
                tarjeta = Global.MiTienda.ListaTarjetas[index];
                ShowControles(true);
                ListaFormasPago(tarjeta);
            }
            else
            {
                ShowControles(false);
            }
        }
        private void AddCheckBox()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "X";
            checkColumn.Width = 18;
            checkColumn.MinimumWidth = 18;
            checkColumn.ReadOnly = false;
            //checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //checkColumn.FillWeight = 20; 
            dataGridViewFP.Columns.Insert(0, checkColumn);
        }
        private int ElementoSeleccionado(DataGridViewRow fila)
        {
            int index = -1;
            if (Convert.ToBoolean(fila.Cells["X"].Value))
            {
                index = fila.Index;
            }
            return index;
        }
        private int AgregarBeneficio(int index, double beneficio)
        {
            int flag = -1;
            if (beneficio < 0)
            {
                //mensaje
                string mensaje = "Ha ocurrido un error";
                string caption = "El interés no puede ser menor a 0";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
            else
            {
                DialogResult result = DialogResult.Yes;
                if (beneficio > tarjeta.FormasPago[index].InteresConBeneficio)
                {
                    //mensaje
                    string mensaje = "";
                    string caption = "El valor ingresado es mayor que el beneficio actual. ¿Desea continuar?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    result = MessageBox.Show(caption, mensaje, buttons);
                }
                if (result == DialogResult.Yes)
                {
                    flag = tarjeta.AddBeneficio(index, beneficio);        
                }
            }
            return flag;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double beneficio = double.Parse(textBoxBeneficio.Text);
                int index;
                int flag;
                bool error = false;
                int count = 0;
                foreach (DataGridViewRow fila in dataGridViewFP.Rows)
                {
                    index = ElementoSeleccionado(fila);
                    if (index >= 0 && index < tarjeta.FormasPago.Count)
                    {
                        flag = AgregarBeneficio(index, beneficio);
                        if (flag == 1 && error == false)
                        {
                            error = false;
                        }
                        else
                        {
                            error = true;
                        }
                        count++;
                    }
                }
                ListaFormasPago(tarjeta);
                if (!error && count != 0)
                {
                    //mensaje
                    string mensaje = "Operación exitosa";
                    string caption = "El interés fue actualizado correctamente";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(caption, mensaje, buttons);
                }
                else
                {
                    //mensaje
                    string mensaje = "Ha ocurrido un error";
                    string caption = "El beneficio no pudo ser agregado";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(caption, mensaje, buttons);
                }
            }
            catch
            {
                //mensaje
                string mensaje = "Revise los datos ingresados";
                string caption = "El interés debe ser un valor numérico";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            } 
        }
        
        private void ShowControles(bool c)
        {
            labelFormasPago.Visible = c;
            dataGridViewFP.Visible = c;
            labelInteres.Visible = c;
            textBoxBeneficio.Visible = c;
            buttonAgregar.Visible = c;
            buttonQuitar.Visible = c;
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            int index;
            int flag;
            bool error = false;
            int count = 0;
            foreach (DataGridViewRow fila in dataGridViewFP.Rows)
            {
                index = ElementoSeleccionado(fila);
                if (index >= 0 && index < tarjeta.FormasPago.Count)
                {
                    flag = tarjeta.RemoveBeneficio(index);
                    if (flag == 1 && error == false)
                    {
                        error = false;
                    }
                    else
                    {
                        error = true;
                    }
                    count++;
                }
            }
            ListaFormasPago(tarjeta);
            if (!error && count != 0)
            {
                //mensaje
                string mensaje = "Operación exitosa";
                string caption = "El interés fue actualizado correctamente";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
            else
            {
                //mensaje
                string mensaje = "Ha ocurrido un error";
                string caption = "El beneficio no pudo ser removido.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(caption, mensaje, buttons);
            }
        }
    }
}
