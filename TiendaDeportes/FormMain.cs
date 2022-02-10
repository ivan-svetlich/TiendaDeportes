using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeportes;

namespace TiendaDeportes
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            OcultarMenu();
            Global.MiTienda = BaseDatos.Cargar();
            //Manejo de eventos
            FormCliente.EventoFormPago += AbrirFormulario<FormPago>;
            FormPago.EventoFormFinalizar += AbrirFormulario<FormFinalizar>;
        }

        private void OcultarMenu()
        {
            panelProductos.Visible = false;
            panelCompras.Visible = false;
            panelTarjetas.Visible = false;
        }

        private void MostrarMenu(Panel panelMenu)
        {
            if (panelMenu.Visible == false)
            {
                OcultarMenu();
                panelMenu.Visible = true;
            }
            else
                panelMenu.Visible = false;
        }

        //Metodo para abrir formularios sobre el panel principal
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault();//Busca si el formulaio ya existe
            
            //si no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            //
        }
        #region Desplegado de menues
        private void buttonProductos_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelProductos);
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelCompras);
        }

        private void buttonTarjetas_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelTarjetas);
        }
        #endregion Desplegado de menues

        #region apertura de formularios
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormInfo>();
        }

        private void buttonAddProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAddProd>();
        }

        private void buttonListProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListProd>();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            BaseDatos.Guardar(Global.MiTienda);
        }

        private void buttonAddPromo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAddPromo>();
        }

        private void buttonListPromos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListPromos>();
        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAddCarro>();
        }

        private void buttonAddTarjeta_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAddTarjeta>();
        }

        private void buttonAddBeneficio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormAddBeneficio>();
        }

        private void buttonListTarjetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListTarjetas>();
        }

        private void buttonVerCarro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListCarro>();
        }

        private void buttonIdentificar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCliente>();
        }
        #endregion apertura de formularios
    }
}
