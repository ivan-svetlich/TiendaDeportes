
namespace TiendaDeportes
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelTarjetas = new System.Windows.Forms.Panel();
            this.buttonListTarjetas = new System.Windows.Forms.Button();
            this.buttonAddBeneficio = new System.Windows.Forms.Button();
            this.buttonAddTarjeta = new System.Windows.Forms.Button();
            this.buttonTarjetas = new System.Windows.Forms.Button();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.buttonIdentificar = new System.Windows.Forms.Button();
            this.buttonVerCarro = new System.Windows.Forms.Button();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.buttonListPromos = new System.Windows.Forms.Button();
            this.buttonAddPromo = new System.Windows.Forms.Button();
            this.buttonListProductos = new System.Windows.Forms.Button();
            this.buttonAddProducto = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLabelMenu = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTarjetas.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelForms);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.panelBarra);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.MinimumSize = new System.Drawing.Size(500, 500);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(834, 511);
            this.panelMain.TabIndex = 0;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panelForms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(220, 40);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(614, 471);
            this.panelForms.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.panelTarjetas);
            this.panelMenu.Controls.Add(this.buttonTarjetas);
            this.panelMenu.Controls.Add(this.panelCompras);
            this.panelMenu.Controls.Add(this.buttonCompras);
            this.panelMenu.Controls.Add(this.panelProductos);
            this.panelMenu.Controls.Add(this.buttonProductos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 471);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(0, 525);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonInfo.Size = new System.Drawing.Size(203, 45);
            this.buttonInfo.TabIndex = 9;
            this.buttonInfo.Text = "Información";
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panelTarjetas
            // 
            this.panelTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTarjetas.Controls.Add(this.buttonListTarjetas);
            this.panelTarjetas.Controls.Add(this.buttonAddBeneficio);
            this.panelTarjetas.Controls.Add(this.buttonAddTarjeta);
            this.panelTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTarjetas.Location = new System.Drawing.Point(0, 420);
            this.panelTarjetas.Name = "panelTarjetas";
            this.panelTarjetas.Size = new System.Drawing.Size(203, 105);
            this.panelTarjetas.TabIndex = 8;
            // 
            // buttonListTarjetas
            // 
            this.buttonListTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListTarjetas.FlatAppearance.BorderSize = 0;
            this.buttonListTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListTarjetas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListTarjetas.ForeColor = System.Drawing.Color.White;
            this.buttonListTarjetas.Location = new System.Drawing.Point(0, 70);
            this.buttonListTarjetas.Name = "buttonListTarjetas";
            this.buttonListTarjetas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonListTarjetas.Size = new System.Drawing.Size(203, 35);
            this.buttonListTarjetas.TabIndex = 2;
            this.buttonListTarjetas.Text = "Lista de tarjetas";
            this.buttonListTarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListTarjetas.UseVisualStyleBackColor = true;
            this.buttonListTarjetas.Click += new System.EventHandler(this.buttonListTarjetas_Click);
            // 
            // buttonAddBeneficio
            // 
            this.buttonAddBeneficio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddBeneficio.FlatAppearance.BorderSize = 0;
            this.buttonAddBeneficio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBeneficio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddBeneficio.ForeColor = System.Drawing.Color.White;
            this.buttonAddBeneficio.Location = new System.Drawing.Point(0, 35);
            this.buttonAddBeneficio.Name = "buttonAddBeneficio";
            this.buttonAddBeneficio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddBeneficio.Size = new System.Drawing.Size(203, 35);
            this.buttonAddBeneficio.TabIndex = 1;
            this.buttonAddBeneficio.Text = "Dar de alta beneficio";
            this.buttonAddBeneficio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBeneficio.UseVisualStyleBackColor = true;
            this.buttonAddBeneficio.Click += new System.EventHandler(this.buttonAddBeneficio_Click);
            // 
            // buttonAddTarjeta
            // 
            this.buttonAddTarjeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddTarjeta.FlatAppearance.BorderSize = 0;
            this.buttonAddTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTarjeta.ForeColor = System.Drawing.Color.White;
            this.buttonAddTarjeta.Location = new System.Drawing.Point(0, 0);
            this.buttonAddTarjeta.Name = "buttonAddTarjeta";
            this.buttonAddTarjeta.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddTarjeta.Size = new System.Drawing.Size(203, 35);
            this.buttonAddTarjeta.TabIndex = 0;
            this.buttonAddTarjeta.Text = "Dar de alta tarjeta";
            this.buttonAddTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddTarjeta.UseVisualStyleBackColor = true;
            this.buttonAddTarjeta.Click += new System.EventHandler(this.buttonAddTarjeta_Click);
            // 
            // buttonTarjetas
            // 
            this.buttonTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTarjetas.FlatAppearance.BorderSize = 0;
            this.buttonTarjetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarjetas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTarjetas.ForeColor = System.Drawing.Color.White;
            this.buttonTarjetas.Location = new System.Drawing.Point(0, 375);
            this.buttonTarjetas.Name = "buttonTarjetas";
            this.buttonTarjetas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonTarjetas.Size = new System.Drawing.Size(203, 45);
            this.buttonTarjetas.TabIndex = 7;
            this.buttonTarjetas.Text = "Tarjetas";
            this.buttonTarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTarjetas.UseVisualStyleBackColor = true;
            this.buttonTarjetas.Click += new System.EventHandler(this.buttonTarjetas_Click);
            // 
            // panelCompras
            // 
            this.panelCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelCompras.Controls.Add(this.buttonIdentificar);
            this.panelCompras.Controls.Add(this.buttonVerCarro);
            this.panelCompras.Controls.Add(this.buttonAddCarro);
            this.panelCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompras.Location = new System.Drawing.Point(0, 270);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(203, 105);
            this.panelCompras.TabIndex = 6;
            // 
            // buttonIdentificar
            // 
            this.buttonIdentificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIdentificar.FlatAppearance.BorderSize = 0;
            this.buttonIdentificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIdentificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIdentificar.ForeColor = System.Drawing.Color.White;
            this.buttonIdentificar.Location = new System.Drawing.Point(0, 70);
            this.buttonIdentificar.Name = "buttonIdentificar";
            this.buttonIdentificar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonIdentificar.Size = new System.Drawing.Size(203, 35);
            this.buttonIdentificar.TabIndex = 1;
            this.buttonIdentificar.Text = "Identificar cliente";
            this.buttonIdentificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIdentificar.UseVisualStyleBackColor = true;
            this.buttonIdentificar.Click += new System.EventHandler(this.buttonIdentificar_Click);
            // 
            // buttonVerCarro
            // 
            this.buttonVerCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVerCarro.FlatAppearance.BorderSize = 0;
            this.buttonVerCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerCarro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVerCarro.ForeColor = System.Drawing.Color.White;
            this.buttonVerCarro.Location = new System.Drawing.Point(0, 35);
            this.buttonVerCarro.Name = "buttonVerCarro";
            this.buttonVerCarro.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonVerCarro.Size = new System.Drawing.Size(203, 35);
            this.buttonVerCarro.TabIndex = 2;
            this.buttonVerCarro.Text = "Ver carro";
            this.buttonVerCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVerCarro.UseVisualStyleBackColor = true;
            this.buttonVerCarro.Click += new System.EventHandler(this.buttonVerCarro_Click);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddCarro.FlatAppearance.BorderSize = 0;
            this.buttonAddCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCarro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCarro.ForeColor = System.Drawing.Color.White;
            this.buttonAddCarro.Location = new System.Drawing.Point(0, 0);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddCarro.Size = new System.Drawing.Size(203, 35);
            this.buttonAddCarro.TabIndex = 0;
            this.buttonAddCarro.Text = "Agregar productos";
            this.buttonAddCarro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // buttonCompras
            // 
            this.buttonCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCompras.FlatAppearance.BorderSize = 0;
            this.buttonCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCompras.ForeColor = System.Drawing.Color.White;
            this.buttonCompras.Location = new System.Drawing.Point(0, 225);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCompras.Size = new System.Drawing.Size(203, 45);
            this.buttonCompras.TabIndex = 5;
            this.buttonCompras.Text = "Compras";
            this.buttonCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelProductos.Controls.Add(this.buttonListPromos);
            this.panelProductos.Controls.Add(this.buttonAddPromo);
            this.panelProductos.Controls.Add(this.buttonListProductos);
            this.panelProductos.Controls.Add(this.buttonAddProducto);
            this.panelProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductos.Location = new System.Drawing.Point(0, 85);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(203, 140);
            this.panelProductos.TabIndex = 2;
            // 
            // buttonListPromos
            // 
            this.buttonListPromos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonListPromos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListPromos.FlatAppearance.BorderSize = 0;
            this.buttonListPromos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListPromos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListPromos.ForeColor = System.Drawing.Color.White;
            this.buttonListPromos.Location = new System.Drawing.Point(0, 105);
            this.buttonListPromos.Name = "buttonListPromos";
            this.buttonListPromos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonListPromos.Size = new System.Drawing.Size(203, 35);
            this.buttonListPromos.TabIndex = 3;
            this.buttonListPromos.Text = "Lista de promociones";
            this.buttonListPromos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListPromos.UseVisualStyleBackColor = false;
            this.buttonListPromos.Click += new System.EventHandler(this.buttonListPromos_Click);
            // 
            // buttonAddPromo
            // 
            this.buttonAddPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonAddPromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddPromo.FlatAppearance.BorderSize = 0;
            this.buttonAddPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPromo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPromo.ForeColor = System.Drawing.Color.White;
            this.buttonAddPromo.Location = new System.Drawing.Point(0, 70);
            this.buttonAddPromo.Name = "buttonAddPromo";
            this.buttonAddPromo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddPromo.Size = new System.Drawing.Size(203, 35);
            this.buttonAddPromo.TabIndex = 2;
            this.buttonAddPromo.Text = "Dar de alta promoción";
            this.buttonAddPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPromo.UseVisualStyleBackColor = false;
            this.buttonAddPromo.Click += new System.EventHandler(this.buttonAddPromo_Click);
            // 
            // buttonListProductos
            // 
            this.buttonListProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListProductos.FlatAppearance.BorderSize = 0;
            this.buttonListProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListProductos.ForeColor = System.Drawing.Color.White;
            this.buttonListProductos.Location = new System.Drawing.Point(0, 35);
            this.buttonListProductos.Name = "buttonListProductos";
            this.buttonListProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonListProductos.Size = new System.Drawing.Size(203, 35);
            this.buttonListProductos.TabIndex = 1;
            this.buttonListProductos.Text = "Lista de productos";
            this.buttonListProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListProductos.UseVisualStyleBackColor = true;
            this.buttonListProductos.Click += new System.EventHandler(this.buttonListProductos_Click);
            // 
            // buttonAddProducto
            // 
            this.buttonAddProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddProducto.FlatAppearance.BorderSize = 0;
            this.buttonAddProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProducto.ForeColor = System.Drawing.Color.White;
            this.buttonAddProducto.Location = new System.Drawing.Point(0, 0);
            this.buttonAddProducto.Name = "buttonAddProducto";
            this.buttonAddProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonAddProducto.Size = new System.Drawing.Size(203, 35);
            this.buttonAddProducto.TabIndex = 0;
            this.buttonAddProducto.Text = "Dar de alta  producto";
            this.buttonAddProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProducto.UseVisualStyleBackColor = true;
            this.buttonAddProducto.Click += new System.EventHandler(this.buttonAddProducto_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.BackColor = System.Drawing.Color.Black;
            this.buttonProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductos.FlatAppearance.BorderSize = 0;
            this.buttonProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProductos.ForeColor = System.Drawing.Color.White;
            this.buttonProductos.Location = new System.Drawing.Point(0, 40);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonProductos.Size = new System.Drawing.Size(203, 45);
            this.buttonProductos.TabIndex = 1;
            this.buttonProductos.Text = "Productos y Promociones";
            this.buttonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductos.UseVisualStyleBackColor = false;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonLabelMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(203, 40);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonLabelMenu
            // 
            this.buttonLabelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLabelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLabelMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLabelMenu.ForeColor = System.Drawing.Color.White;
            this.buttonLabelMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonLabelMenu.Name = "buttonLabelMenu";
            this.buttonLabelMenu.Size = new System.Drawing.Size(203, 40);
            this.buttonLabelMenu.TabIndex = 0;
            this.buttonLabelMenu.Text = "Menu";
            this.buttonLabelMenu.UseVisualStyleBackColor = true;
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.Black;
            this.panelBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(834, 40);
            this.panelBarra.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda Deportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTarjetas.ResumeLayout(false);
            this.panelCompras.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button buttonListPromos;
        private System.Windows.Forms.Button buttonAddPromo;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Button buttonListProductos;
        private System.Windows.Forms.Button buttonAddProducto;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Panel panelTarjetas;
        private System.Windows.Forms.Button buttonAddBeneficio;
        private System.Windows.Forms.Button buttonAddTarjeta;
        private System.Windows.Forms.Button buttonTarjetas;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Button buttonIdentificar;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonListTarjetas;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonLabelMenu;
        private System.Windows.Forms.Button buttonVerCarro;
    }
}

