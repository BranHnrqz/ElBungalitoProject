namespace ElBungalitoProject.Views
{
    partial class frmOrdenar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOrdenComida = new System.Windows.Forms.GroupBox();
            this.dgvPlato = new System.Windows.Forms.DataGridView();
            this.numCantidadPlato = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoPlato = new System.Windows.Forms.ComboBox();
            this.lbCantidadPlato = new System.Windows.Forms.Label();
            this.lbPrecioPlato = new System.Windows.Forms.Label();
            this.lbEspecialidadPlato = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.cmbEspecialidadPlato = new System.Windows.Forms.ComboBox();
            this.cmbPlato = new System.Windows.Forms.ComboBox();
            this.txtSubTotalPlato = new System.Windows.Forms.TextBox();
            this.grpOrdenBebida = new System.Windows.Forms.GroupBox();
            this.dgvBebida = new System.Windows.Forms.DataGridView();
            this.numCantidadBebida = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoBebida = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.cmbEspecialidadBebida = new System.Windows.Forms.ComboBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.txtSubTotalBebida = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.grpOrdenComida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPlato)).BeginInit();
            this.grpOrdenBebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadBebida)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 915);
            this.panel1.TabIndex = 0;
            // 
            // grpOrdenComida
            // 
            this.grpOrdenComida.Controls.Add(this.dgvPlato);
            this.grpOrdenComida.Controls.Add(this.numCantidadPlato);
            this.grpOrdenComida.Controls.Add(this.label6);
            this.grpOrdenComida.Controls.Add(this.cmbTipoPlato);
            this.grpOrdenComida.Controls.Add(this.lbCantidadPlato);
            this.grpOrdenComida.Controls.Add(this.lbPrecioPlato);
            this.grpOrdenComida.Controls.Add(this.lbEspecialidadPlato);
            this.grpOrdenComida.Controls.Add(this.label2);
            this.grpOrdenComida.Controls.Add(this.btnAgregarPlato);
            this.grpOrdenComida.Controls.Add(this.cmbEspecialidadPlato);
            this.grpOrdenComida.Controls.Add(this.cmbPlato);
            this.grpOrdenComida.Controls.Add(this.txtSubTotalPlato);
            this.grpOrdenComida.Location = new System.Drawing.Point(39, 17);
            this.grpOrdenComida.Name = "grpOrdenComida";
            this.grpOrdenComida.Size = new System.Drawing.Size(1205, 341);
            this.grpOrdenComida.TabIndex = 3;
            this.grpOrdenComida.TabStop = false;
            this.grpOrdenComida.Text = "Ordenar Plato";
            // 
            // dgvPlato
            // 
            this.dgvPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlato.Location = new System.Drawing.Point(503, 51);
            this.dgvPlato.Name = "dgvPlato";
            this.dgvPlato.Size = new System.Drawing.Size(667, 259);
            this.dgvPlato.TabIndex = 12;
            // 
            // numCantidadPlato
            // 
            this.numCantidadPlato.Location = new System.Drawing.Point(169, 220);
            this.numCantidadPlato.Name = "numCantidadPlato";
            this.numCantidadPlato.Size = new System.Drawing.Size(74, 32);
            this.numCantidadPlato.TabIndex = 11;
            this.numCantidadPlato.ValueChanged += new System.EventHandler(this.numCantidadPlato_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de plato";
            // 
            // cmbTipoPlato
            // 
            this.cmbTipoPlato.FormattingEnabled = true;
            this.cmbTipoPlato.Location = new System.Drawing.Point(169, 51);
            this.cmbTipoPlato.Name = "cmbTipoPlato";
            this.cmbTipoPlato.Size = new System.Drawing.Size(293, 32);
            this.cmbTipoPlato.TabIndex = 9;
            this.cmbTipoPlato.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPlato_SelectedIndexChanged);
            // 
            // lbCantidadPlato
            // 
            this.lbCantidadPlato.AutoSize = true;
            this.lbCantidadPlato.Location = new System.Drawing.Point(59, 222);
            this.lbCantidadPlato.Name = "lbCantidadPlato";
            this.lbCantidadPlato.Size = new System.Drawing.Size(102, 24);
            this.lbCantidadPlato.TabIndex = 7;
            this.lbCantidadPlato.Text = "Cantidad";
            // 
            // lbPrecioPlato
            // 
            this.lbPrecioPlato.AutoSize = true;
            this.lbPrecioPlato.Location = new System.Drawing.Point(263, 222);
            this.lbPrecioPlato.Name = "lbPrecioPlato";
            this.lbPrecioPlato.Size = new System.Drawing.Size(76, 24);
            this.lbPrecioPlato.TabIndex = 6;
            this.lbPrecioPlato.Text = "Precio";
            // 
            // lbEspecialidadPlato
            // 
            this.lbEspecialidadPlato.AutoSize = true;
            this.lbEspecialidadPlato.Location = new System.Drawing.Point(23, 168);
            this.lbEspecialidadPlato.Name = "lbEspecialidadPlato";
            this.lbEspecialidadPlato.Size = new System.Drawing.Size(140, 24);
            this.lbEspecialidadPlato.TabIndex = 5;
            this.lbEspecialidadPlato.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orden";
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Location = new System.Drawing.Point(22, 276);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(440, 34);
            this.btnAgregarPlato.TabIndex = 3;
            this.btnAgregarPlato.Text = "Añadir";
            this.btnAgregarPlato.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidadPlato
            // 
            this.cmbEspecialidadPlato.FormattingEnabled = true;
            this.cmbEspecialidadPlato.Items.AddRange(new object[] {
            " "});
            this.cmbEspecialidadPlato.Location = new System.Drawing.Point(169, 164);
            this.cmbEspecialidadPlato.Name = "cmbEspecialidadPlato";
            this.cmbEspecialidadPlato.Size = new System.Drawing.Size(293, 32);
            this.cmbEspecialidadPlato.TabIndex = 2;
            this.cmbEspecialidadPlato.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidadPlato_SelectedIndexChanged);
            // 
            // cmbPlato
            // 
            this.cmbPlato.FormattingEnabled = true;
            this.cmbPlato.Items.AddRange(new object[] {
            "ola"});
            this.cmbPlato.Location = new System.Drawing.Point(169, 106);
            this.cmbPlato.Name = "cmbPlato";
            this.cmbPlato.Size = new System.Drawing.Size(293, 32);
            this.cmbPlato.TabIndex = 1;
            this.cmbPlato.SelectedIndexChanged += new System.EventHandler(this.cmbPlato_SelectedIndexChanged);
            // 
            // txtSubTotalPlato
            // 
            this.txtSubTotalPlato.Location = new System.Drawing.Point(345, 219);
            this.txtSubTotalPlato.Name = "txtSubTotalPlato";
            this.txtSubTotalPlato.Size = new System.Drawing.Size(117, 32);
            this.txtSubTotalPlato.TabIndex = 0;
            // 
            // grpOrdenBebida
            // 
            this.grpOrdenBebida.Controls.Add(this.dgvBebida);
            this.grpOrdenBebida.Controls.Add(this.numCantidadBebida);
            this.grpOrdenBebida.Controls.Add(this.label7);
            this.grpOrdenBebida.Controls.Add(this.cmbTipoBebida);
            this.grpOrdenBebida.Controls.Add(this.label8);
            this.grpOrdenBebida.Controls.Add(this.label9);
            this.grpOrdenBebida.Controls.Add(this.label10);
            this.grpOrdenBebida.Controls.Add(this.label11);
            this.grpOrdenBebida.Controls.Add(this.btnAgregarBebida);
            this.grpOrdenBebida.Controls.Add(this.cmbEspecialidadBebida);
            this.grpOrdenBebida.Controls.Add(this.cmbBebida);
            this.grpOrdenBebida.Controls.Add(this.txtSubTotalBebida);
            this.grpOrdenBebida.Location = new System.Drawing.Point(39, 364);
            this.grpOrdenBebida.Name = "grpOrdenBebida";
            this.grpOrdenBebida.Size = new System.Drawing.Size(1205, 341);
            this.grpOrdenBebida.TabIndex = 12;
            this.grpOrdenBebida.TabStop = false;
            this.grpOrdenBebida.Tag = "";
            this.grpOrdenBebida.Text = "Ordenar Bebida";
            // 
            // dgvBebida
            // 
            this.dgvBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebida.Location = new System.Drawing.Point(503, 51);
            this.dgvBebida.Name = "dgvBebida";
            this.dgvBebida.Size = new System.Drawing.Size(667, 259);
            this.dgvBebida.TabIndex = 13;
            // 
            // numCantidadBebida
            // 
            this.numCantidadBebida.Location = new System.Drawing.Point(169, 220);
            this.numCantidadBebida.Name = "numCantidadBebida";
            this.numCantidadBebida.Size = new System.Drawing.Size(74, 32);
            this.numCantidadBebida.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo de bebida";
            // 
            // cmbTipoBebida
            // 
            this.cmbTipoBebida.FormattingEnabled = true;
            this.cmbTipoBebida.Location = new System.Drawing.Point(169, 51);
            this.cmbTipoBebida.Name = "cmbTipoBebida";
            this.cmbTipoBebida.Size = new System.Drawing.Size(293, 32);
            this.cmbTipoBebida.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Especialidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Orden";
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.Location = new System.Drawing.Point(22, 276);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(440, 34);
            this.btnAgregarBebida.TabIndex = 3;
            this.btnAgregarBebida.Text = "Añadir";
            this.btnAgregarBebida.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidadBebida
            // 
            this.cmbEspecialidadBebida.FormattingEnabled = true;
            this.cmbEspecialidadBebida.Location = new System.Drawing.Point(169, 164);
            this.cmbEspecialidadBebida.Name = "cmbEspecialidadBebida";
            this.cmbEspecialidadBebida.Size = new System.Drawing.Size(293, 32);
            this.cmbEspecialidadBebida.TabIndex = 2;
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Location = new System.Drawing.Point(169, 106);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(293, 32);
            this.cmbBebida.TabIndex = 1;
            // 
            // txtSubTotalBebida
            // 
            this.txtSubTotalBebida.Location = new System.Drawing.Point(345, 219);
            this.txtSubTotalBebida.Name = "txtSubTotalBebida";
            this.txtSubTotalBebida.Size = new System.Drawing.Size(117, 32);
            this.txtSubTotalBebida.TabIndex = 0;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(11, 728);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(195, 34);
            this.btnVender.TabIndex = 14;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Teal;
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComenzar.Location = new System.Drawing.Point(276, 10);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(144, 34);
            this.btnComenzar.TabIndex = 15;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 32);
            this.txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(1194, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 34);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(1109, 35);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 34);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(170, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 57);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1296, 91);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnComenzar);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1296, 50);
            this.panel4.TabIndex = 19;
            // 
            // panelFill
            // 
            this.panelFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFill.Controls.Add(this.grpOrdenComida);
            this.panelFill.Controls.Add(this.grpOrdenBebida);
            this.panelFill.Controls.Add(this.btnVender);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(200, 141);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1296, 774);
            this.panelFill.TabIndex = 20;
            // 
            // frmOrdenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 915);
            this.ControlBox = false;
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmOrdenar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenar";
            this.Load += new System.EventHandler(this.frmOrdenar_Load);
            this.grpOrdenComida.ResumeLayout(false);
            this.grpOrdenComida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPlato)).EndInit();
            this.grpOrdenBebida.ResumeLayout(false);
            this.grpOrdenBebida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadBebida)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpOrdenComida;
        private System.Windows.Forms.Label lbCantidadPlato;
        private System.Windows.Forms.Label lbPrecioPlato;
        private System.Windows.Forms.Label lbEspecialidadPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.ComboBox cmbEspecialidadPlato;
        private System.Windows.Forms.ComboBox cmbPlato;
        private System.Windows.Forms.TextBox txtSubTotalPlato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoPlato;
        private System.Windows.Forms.NumericUpDown numCantidadPlato;
        private System.Windows.Forms.GroupBox grpOrdenBebida;
        private System.Windows.Forms.NumericUpDown numCantidadBebida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoBebida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregarBebida;
        private System.Windows.Forms.ComboBox cmbEspecialidadBebida;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.TextBox txtSubTotalBebida;
        private System.Windows.Forms.DataGridView dgvPlato;
        private System.Windows.Forms.DataGridView dgvBebida;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelFill;
    }
}