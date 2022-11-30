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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOrdenComida = new System.Windows.Forms.GroupBox();
            this.btnDeletePlato = new System.Windows.Forms.Button();
            this.dgvPlato = new System.Windows.Forms.DataGridView();
            this.idEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnDeleteBebida = new System.Windows.Forms.Button();
            this.dgvBebida = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtNumOrden = new System.Windows.Forms.TextBox();
            this.panelFill = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.grpOrdenComida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPlato)).BeginInit();
            this.grpOrdenBebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadBebida)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 939);
            this.panel1.TabIndex = 0;
            // 
            // grpOrdenComida
            // 
            this.grpOrdenComida.Controls.Add(this.btnDeletePlato);
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
            this.grpOrdenComida.Size = new System.Drawing.Size(1250, 356);
            this.grpOrdenComida.TabIndex = 3;
            this.grpOrdenComida.TabStop = false;
            this.grpOrdenComida.Text = "Ordenar Plato";
            // 
            // btnDeletePlato
            // 
            this.btnDeletePlato.ForeColor = System.Drawing.Color.Red;
            this.btnDeletePlato.Location = new System.Drawing.Point(503, 316);
            this.btnDeletePlato.Name = "btnDeletePlato";
            this.btnDeletePlato.Size = new System.Drawing.Size(195, 34);
            this.btnDeletePlato.TabIndex = 15;
            this.btnDeletePlato.Text = "Eliminar";
            this.btnDeletePlato.UseVisualStyleBackColor = true;
            this.btnDeletePlato.Click += new System.EventHandler(this.btnDeletePlato_Click);
            // 
            // dgvPlato
            // 
            this.dgvPlato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecialidad,
            this.Orden,
            this.Especialidad,
            this.PrecioUnitario,
            this.Cantidad,
            this.SubTotal});
            this.dgvPlato.Location = new System.Drawing.Point(503, 51);
            this.dgvPlato.Name = "dgvPlato";
            this.dgvPlato.Size = new System.Drawing.Size(719, 259);
            this.dgvPlato.TabIndex = 12;
            // 
            // idEspecialidad
            // 
            this.idEspecialidad.HeaderText = "idEspecialidad";
            this.idEspecialidad.Name = "idEspecialidad";
            this.idEspecialidad.Visible = false;
            // 
            // Orden
            // 
            this.Orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.Width = 96;
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Width = 160;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 162;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 123;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 123;
            // 
            // numCantidadPlato
            // 
            this.numCantidadPlato.Location = new System.Drawing.Point(169, 220);
            this.numCantidadPlato.Name = "numCantidadPlato";
            this.numCantidadPlato.Size = new System.Drawing.Size(74, 31);
            this.numCantidadPlato.TabIndex = 11;
            this.numCantidadPlato.ValueChanged += new System.EventHandler(this.numCantidadPlato_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de plato";
            // 
            // cmbTipoPlato
            // 
            this.cmbTipoPlato.FormattingEnabled = true;
            this.cmbTipoPlato.Location = new System.Drawing.Point(169, 51);
            this.cmbTipoPlato.Name = "cmbTipoPlato";
            this.cmbTipoPlato.Size = new System.Drawing.Size(293, 33);
            this.cmbTipoPlato.TabIndex = 9;
            this.cmbTipoPlato.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPlato_SelectedIndexChanged);
            // 
            // lbCantidadPlato
            // 
            this.lbCantidadPlato.AutoSize = true;
            this.lbCantidadPlato.Location = new System.Drawing.Point(59, 222);
            this.lbCantidadPlato.Name = "lbCantidadPlato";
            this.lbCantidadPlato.Size = new System.Drawing.Size(98, 25);
            this.lbCantidadPlato.TabIndex = 7;
            this.lbCantidadPlato.Text = "Cantidad";
            // 
            // lbPrecioPlato
            // 
            this.lbPrecioPlato.AutoSize = true;
            this.lbPrecioPlato.Location = new System.Drawing.Point(263, 222);
            this.lbPrecioPlato.Name = "lbPrecioPlato";
            this.lbPrecioPlato.Size = new System.Drawing.Size(73, 25);
            this.lbPrecioPlato.TabIndex = 6;
            this.lbPrecioPlato.Text = "Precio";
            // 
            // lbEspecialidadPlato
            // 
            this.lbEspecialidadPlato.AutoSize = true;
            this.lbEspecialidadPlato.Location = new System.Drawing.Point(23, 168);
            this.lbEspecialidadPlato.Name = "lbEspecialidadPlato";
            this.lbEspecialidadPlato.Size = new System.Drawing.Size(135, 25);
            this.lbEspecialidadPlato.TabIndex = 5;
            this.lbEspecialidadPlato.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
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
            this.btnAgregarPlato.Click += new System.EventHandler(this.btnAgregarPlato_Click);
            // 
            // cmbEspecialidadPlato
            // 
            this.cmbEspecialidadPlato.FormattingEnabled = true;
            this.cmbEspecialidadPlato.Items.AddRange(new object[] {
            " "});
            this.cmbEspecialidadPlato.Location = new System.Drawing.Point(169, 164);
            this.cmbEspecialidadPlato.Name = "cmbEspecialidadPlato";
            this.cmbEspecialidadPlato.Size = new System.Drawing.Size(293, 33);
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
            this.cmbPlato.Size = new System.Drawing.Size(293, 33);
            this.cmbPlato.TabIndex = 1;
            this.cmbPlato.SelectedIndexChanged += new System.EventHandler(this.cmbPlato_SelectedIndexChanged);
            // 
            // txtSubTotalPlato
            // 
            this.txtSubTotalPlato.Location = new System.Drawing.Point(345, 219);
            this.txtSubTotalPlato.Name = "txtSubTotalPlato";
            this.txtSubTotalPlato.Size = new System.Drawing.Size(117, 31);
            this.txtSubTotalPlato.TabIndex = 0;
            // 
            // grpOrdenBebida
            // 
            this.grpOrdenBebida.Controls.Add(this.btnDeleteBebida);
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
            this.grpOrdenBebida.Location = new System.Drawing.Point(39, 388);
            this.grpOrdenBebida.Name = "grpOrdenBebida";
            this.grpOrdenBebida.Size = new System.Drawing.Size(1250, 358);
            this.grpOrdenBebida.TabIndex = 12;
            this.grpOrdenBebida.TabStop = false;
            this.grpOrdenBebida.Tag = "";
            this.grpOrdenBebida.Text = "Ordenar Bebida";
            // 
            // btnDeleteBebida
            // 
            this.btnDeleteBebida.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBebida.Location = new System.Drawing.Point(503, 316);
            this.btnDeleteBebida.Name = "btnDeleteBebida";
            this.btnDeleteBebida.Size = new System.Drawing.Size(195, 34);
            this.btnDeleteBebida.TabIndex = 16;
            this.btnDeleteBebida.Text = "Eliminar";
            this.btnDeleteBebida.UseVisualStyleBackColor = true;
            this.btnDeleteBebida.Click += new System.EventHandler(this.btnDeleteBebida_Click);
            // 
            // dgvBebida
            // 
            this.dgvBebida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBebida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvBebida.Location = new System.Drawing.Point(503, 51);
            this.dgvBebida.Name = "dgvBebida";
            this.dgvBebida.Size = new System.Drawing.Size(719, 259);
            this.dgvBebida.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "idEspecialidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Orden";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Sabor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 162;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 123;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 123;
            // 
            // numCantidadBebida
            // 
            this.numCantidadBebida.Location = new System.Drawing.Point(169, 220);
            this.numCantidadBebida.Name = "numCantidadBebida";
            this.numCantidadBebida.Size = new System.Drawing.Size(74, 31);
            this.numCantidadBebida.TabIndex = 11;
            this.numCantidadBebida.ValueChanged += new System.EventHandler(this.numCantidadBebida_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo de bebida";
            // 
            // cmbTipoBebida
            // 
            this.cmbTipoBebida.FormattingEnabled = true;
            this.cmbTipoBebida.Location = new System.Drawing.Point(169, 51);
            this.cmbTipoBebida.Name = "cmbTipoBebida";
            this.cmbTipoBebida.Size = new System.Drawing.Size(293, 33);
            this.cmbTipoBebida.TabIndex = 9;
            this.cmbTipoBebida.SelectedIndexChanged += new System.EventHandler(this.cmbTipoBebida_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Especialidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
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
            this.btnAgregarBebida.Click += new System.EventHandler(this.btnAgregarBebida_Click);
            // 
            // cmbEspecialidadBebida
            // 
            this.cmbEspecialidadBebida.FormattingEnabled = true;
            this.cmbEspecialidadBebida.Location = new System.Drawing.Point(169, 164);
            this.cmbEspecialidadBebida.Name = "cmbEspecialidadBebida";
            this.cmbEspecialidadBebida.Size = new System.Drawing.Size(293, 33);
            this.cmbEspecialidadBebida.TabIndex = 2;
            this.cmbEspecialidadBebida.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidadBebida_SelectedIndexChanged);
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Location = new System.Drawing.Point(169, 106);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(293, 33);
            this.cmbBebida.TabIndex = 1;
            this.cmbBebida.SelectedIndexChanged += new System.EventHandler(this.cmbBebida_SelectedIndexChanged);
            // 
            // txtSubTotalBebida
            // 
            this.txtSubTotalBebida.Location = new System.Drawing.Point(345, 219);
            this.txtSubTotalBebida.Name = "txtSubTotalBebida";
            this.txtSubTotalBebida.Size = new System.Drawing.Size(117, 31);
            this.txtSubTotalBebida.TabIndex = 0;
            // 
            // btnVender
            // 
            this.btnVender.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVender.Location = new System.Drawing.Point(1066, 755);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(195, 34);
            this.btnVender.TabIndex = 14;
            this.btnVender.Text = "Comprar";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnComenzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComenzar.Location = new System.Drawing.Point(278, 89);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(144, 34);
            this.btnComenzar.TabIndex = 15;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 31);
            this.txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(1192, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 34);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(1107, 35);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(98, 34);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenar";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnComenzar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtNumOrden);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1317, 135);
            this.panel3.TabIndex = 18;
            // 
            // txtNumOrden
            // 
            this.txtNumOrden.Location = new System.Drawing.Point(1109, 89);
            this.txtNumOrden.Name = "txtNumOrden";
            this.txtNumOrden.Size = new System.Drawing.Size(152, 31);
            this.txtNumOrden.TabIndex = 16;
            // 
            // panelFill
            // 
            this.panelFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelFill.Controls.Add(this.grpOrdenComida);
            this.panelFill.Controls.Add(this.grpOrdenBebida);
            this.panelFill.Controls.Add(this.label4);
            this.panelFill.Controls.Add(this.btnVender);
            this.panelFill.Controls.Add(this.txtTotalPagar);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(200, 135);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1317, 804);
            this.panelFill.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 755);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total a pagar";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(208, 752);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(117, 31);
            this.txtTotalPagar.TabIndex = 0;
            // 
            // frmOrdenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 939);
            this.ControlBox = false;
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
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
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtNumOrden;
        private System.Windows.Forms.DataGridView dgvBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnDeletePlato;
        private System.Windows.Forms.Button btnDeleteBebida;
    }
}