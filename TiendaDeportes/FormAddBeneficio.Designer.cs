
namespace TiendaDeportes
{
    partial class FormAddBeneficio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewFP = new System.Windows.Forms.DataGridView();
            this.ColumnCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBeneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.labelInteres = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxBeneficio = new System.Windows.Forms.TextBox();
            this.labelFormasPago = new System.Windows.Forms.Label();
            this.comboBoxTarjetas = new System.Windows.Forms.ComboBox();
            this.labelTarjetas = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 40);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(614, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "BENEFICIOS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 80);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(614, 25);
            this.panel7.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(444, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 366);
            this.panel5.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 366);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewFP);
            this.panel1.Controls.Add(this.buttonQuitar);
            this.panel1.Controls.Add(this.labelInteres);
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.textBoxBeneficio);
            this.panel1.Controls.Add(this.labelFormasPago);
            this.panel1.Controls.Add(this.comboBoxTarjetas);
            this.panel1.Controls.Add(this.labelTarjetas);
            this.panel1.Location = new System.Drawing.Point(110, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 360);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewFP
            // 
            this.dataGridViewFP.AllowUserToAddRows = false;
            this.dataGridViewFP.AllowUserToDeleteRows = false;
            this.dataGridViewFP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dataGridViewFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCuotas,
            this.ColumnInteres,
            this.ColumnBeneficio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFP.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFP.Location = new System.Drawing.Point(3, 100);
            this.dataGridViewFP.Name = "dataGridViewFP";
            this.dataGridViewFP.RowTemplate.Height = 25;
            this.dataGridViewFP.Size = new System.Drawing.Size(391, 181);
            this.dataGridViewFP.TabIndex = 37;
            // 
            // ColumnCuotas
            // 
            this.ColumnCuotas.FillWeight = 33.33F;
            this.ColumnCuotas.HeaderText = "Cuotas";
            this.ColumnCuotas.Name = "ColumnCuotas";
            // 
            // ColumnInteres
            // 
            this.ColumnInteres.FillWeight = 33.33F;
            this.ColumnInteres.HeaderText = "Interés sin beneficio";
            this.ColumnInteres.Name = "ColumnInteres";
            // 
            // ColumnBeneficio
            // 
            this.ColumnBeneficio.FillWeight = 33.33F;
            this.ColumnBeneficio.HeaderText = "Interés con beneficio";
            this.ColumnBeneficio.Name = "ColumnBeneficio";
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.BackColor = System.Drawing.Color.Black;
            this.buttonQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitar.ForeColor = System.Drawing.Color.White;
            this.buttonQuitar.Location = new System.Drawing.Point(316, 301);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(75, 25);
            this.buttonQuitar.TabIndex = 35;
            this.buttonQuitar.Text = "QUITAR";
            this.buttonQuitar.UseVisualStyleBackColor = false;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // labelInteres
            // 
            this.labelInteres.AutoSize = true;
            this.labelInteres.ForeColor = System.Drawing.Color.White;
            this.labelInteres.Location = new System.Drawing.Point(125, 306);
            this.labelInteres.Name = "labelInteres";
            this.labelInteres.Size = new System.Drawing.Size(59, 15);
            this.labelInteres.TabIndex = 34;
            this.labelInteres.Text = "Beneficio:";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Black;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(235, 301);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 25);
            this.buttonAgregar.TabIndex = 33;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxBeneficio
            // 
            this.textBoxBeneficio.Location = new System.Drawing.Point(190, 303);
            this.textBoxBeneficio.Name = "textBoxBeneficio";
            this.textBoxBeneficio.Size = new System.Drawing.Size(34, 23);
            this.textBoxBeneficio.TabIndex = 32;
            // 
            // labelFormasPago
            // 
            this.labelFormasPago.AutoSize = true;
            this.labelFormasPago.ForeColor = System.Drawing.Color.White;
            this.labelFormasPago.Location = new System.Drawing.Point(3, 82);
            this.labelFormasPago.Name = "labelFormasPago";
            this.labelFormasPago.Size = new System.Drawing.Size(210, 15);
            this.labelFormasPago.TabIndex = 31;
            this.labelFormasPago.Text = "Seleccione una o más formas de pago:";
            // 
            // comboBoxTarjetas
            // 
            this.comboBoxTarjetas.FormattingEnabled = true;
            this.comboBoxTarjetas.Location = new System.Drawing.Point(66, 26);
            this.comboBoxTarjetas.Name = "comboBoxTarjetas";
            this.comboBoxTarjetas.Size = new System.Drawing.Size(262, 23);
            this.comboBoxTarjetas.TabIndex = 29;
            this.comboBoxTarjetas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarjetas_SelectedIndexChanged);
            // 
            // labelTarjetas
            // 
            this.labelTarjetas.AutoSize = true;
            this.labelTarjetas.ForeColor = System.Drawing.Color.White;
            this.labelTarjetas.Location = new System.Drawing.Point(66, 8);
            this.labelTarjetas.Name = "labelTarjetas";
            this.labelTarjetas.Size = new System.Drawing.Size(177, 15);
            this.labelTarjetas.TabIndex = 28;
            this.labelTarjetas.Text = "Seleccione una tarjeta de la lista:";
            // 
            // FormAddBeneficio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(614, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddBeneficio";
            this.Text = "FormAddBeneficio";
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInteres;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxBeneficio;
        private System.Windows.Forms.Label labelFormasPago;
        private System.Windows.Forms.ComboBox comboBoxTarjetas;
        private System.Windows.Forms.Label labelTarjetas;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.DataGridView dataGridViewFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBeneficio;
    }
}