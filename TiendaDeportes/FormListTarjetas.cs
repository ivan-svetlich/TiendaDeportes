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
    public partial class FormListTarjetas : Form
    {
        bool filtro = false;
        public FormListTarjetas()
        {
            InitializeComponent();
            comboBoxFiltro.Items.Add("Todas las tarjetas");
            comboBoxFiltro.Items.Add("Solo tarjetas con beneficio");
            comboBoxFiltro.SelectedItem = "Todas las tarjetas";
            FormAddTarjeta.EventoNuevaTarjeta += ListaTarjetas;
            FormAddTarjeta.EventoNuevaFormaPago += ListaFormasPago;
        }

        private void ListaTarjetas()
        {
            dataGridViewTarjetas.Rows.Clear();
            bool show = true;
            
            CultureInfo culture = CultureInfo.CreateSpecificCulture("es-AR");
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
        private void ListaFormasPago(Tarjeta tarjeta)
        {
            dataGridViewFP.Rows.Clear();
            foreach(FormaPago fp in tarjeta.FormasPago)
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
        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFiltro.SelectedItem.ToString() == "Solo tarjetas con beneficio")
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
            Tarjeta tarjeta = Global.MiTienda.ListaTarjetas[index];
            return tarjeta;
        }
    }
}
