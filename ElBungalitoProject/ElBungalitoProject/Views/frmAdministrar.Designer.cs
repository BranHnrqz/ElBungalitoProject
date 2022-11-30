namespace ElBungalitoProject.Views
{
    partial class frmAdministrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grbComida = new System.Windows.Forms.GroupBox();
            this.btnEditarTipoPlato = new System.Windows.Forms.Button();
            this.btnEliminarTipoPlato = new System.Windows.Forms.Button();
            this.btnAgregarTipoPlato = new System.Windows.Forms.Button();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.txtTipoPlato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlato = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Button();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.btnEditarDetallePlato = new System.Windows.Forms.Button();
            this.btnEliminarDetallePlato = new System.Windows.Forms.Button();
            this.btnAgregarDetallePlato = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPlato = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPlato = new System.Windows.Forms.ComboBox();
            this.grbComida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1142, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 905);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(1049, 25);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(28, 25);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(291, 43);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administración";
            // 
            // grbComida
            // 
            this.grbComida.Controls.Add(this.label6);
            this.grbComida.Controls.Add(this.txtTipoPlato);
            this.grbComida.Controls.Add(this.btnEditarTipoPlato);
            this.grbComida.Controls.Add(this.btnEliminarTipoPlato);
            this.grbComida.Controls.Add(this.btnAgregarTipoPlato);
            this.grbComida.Controls.Add(this.dgvPlatos);
            this.grbComida.Location = new System.Drawing.Point(33, 78);
            this.grbComida.Name = "grbComida";
            this.grbComida.Size = new System.Drawing.Size(1100, 268);
            this.grbComida.TabIndex = 2;
            this.grbComida.TabStop = false;
            this.grbComida.Text = "Tipo Plato";
            // 
            // btnEditarTipoPlato
            // 
            this.btnEditarTipoPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarTipoPlato.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditarTipoPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTipoPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTipoPlato.Location = new System.Drawing.Point(1007, 82);
            this.btnEditarTipoPlato.Name = "btnEditarTipoPlato";
            this.btnEditarTipoPlato.Size = new System.Drawing.Size(87, 36);
            this.btnEditarTipoPlato.TabIndex = 2;
            this.btnEditarTipoPlato.Text = "Editar";
            this.btnEditarTipoPlato.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTipoPlato
            // 
            this.btnEliminarTipoPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarTipoPlato.BackColor = System.Drawing.Color.Red;
            this.btnEliminarTipoPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipoPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTipoPlato.Location = new System.Drawing.Point(914, 82);
            this.btnEliminarTipoPlato.Name = "btnEliminarTipoPlato";
            this.btnEliminarTipoPlato.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarTipoPlato.TabIndex = 1;
            this.btnEliminarTipoPlato.Text = "Eliminar";
            this.btnEliminarTipoPlato.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTipoPlato
            // 
            this.btnAgregarTipoPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarTipoPlato.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarTipoPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTipoPlato.Location = new System.Drawing.Point(25, 82);
            this.btnAgregarTipoPlato.Name = "btnAgregarTipoPlato";
            this.btnAgregarTipoPlato.Size = new System.Drawing.Size(87, 36);
            this.btnAgregarTipoPlato.TabIndex = 0;
            this.btnAgregarTipoPlato.Text = "Agregar";
            this.btnAgregarTipoPlato.UseVisualStyleBackColor = false;
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlatos.Location = new System.Drawing.Point(3, 123);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.Size = new System.Drawing.Size(1094, 142);
            this.dgvPlatos.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(947, 24);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(87, 36);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(321, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 45);
            this.panel2.TabIndex = 7;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOrdenes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdenes.Location = new System.Drawing.Point(797, 24);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(144, 36);
            this.btnOrdenes.TabIndex = 8;
            this.btnOrdenes.Text = "Ver Órdenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // txtTipoPlato
            // 
            this.txtTipoPlato.Location = new System.Drawing.Point(107, 31);
            this.txtTipoPlato.Name = "txtTipoPlato";
            this.txtTipoPlato.Size = new System.Drawing.Size(152, 32);
            this.txtTipoPlato.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoPlato);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlato);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.btnEliminarPlato);
            this.groupBox1.Controls.Add(this.btnAgregarPlato);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(33, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 269);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Plato";
            // 
            // txtPlato
            // 
            this.txtPlato.Location = new System.Drawing.Point(107, 31);
            this.txtPlato.Name = "txtPlato";
            this.txtPlato.Size = new System.Drawing.Size(152, 32);
            this.txtPlato.TabIndex = 5;
            // 
            // a
            // 
            this.a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.a.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.a.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.a.Location = new System.Drawing.Point(1007, 82);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(87, 36);
            this.a.TabIndex = 2;
            this.a.Text = "Editar";
            this.a.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarPlato.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlato.Location = new System.Drawing.Point(914, 82);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarPlato.TabIndex = 1;
            this.btnEliminarPlato.Text = "Eliminar";
            this.btnEliminarPlato.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarPlato.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPlato.Location = new System.Drawing.Point(25, 82);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(87, 36);
            this.btnAgregarPlato.TabIndex = 0;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1094, 142);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPlato);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEspecialidad);
            this.groupBox2.Controls.Add(this.btnEditarDetallePlato);
            this.groupBox2.Controls.Add(this.btnEliminarDetallePlato);
            this.groupBox2.Controls.Add(this.btnAgregarDetallePlato);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(33, 627);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1100, 272);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Plato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(192, 31);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(152, 32);
            this.txtEspecialidad.TabIndex = 5;
            // 
            // btnEditarDetallePlato
            // 
            this.btnEditarDetallePlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditarDetallePlato.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditarDetallePlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDetallePlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarDetallePlato.Location = new System.Drawing.Point(1007, 86);
            this.btnEditarDetallePlato.Name = "btnEditarDetallePlato";
            this.btnEditarDetallePlato.Size = new System.Drawing.Size(87, 36);
            this.btnEditarDetallePlato.TabIndex = 2;
            this.btnEditarDetallePlato.Text = "Editar";
            this.btnEditarDetallePlato.UseVisualStyleBackColor = false;
            // 
            // btnEliminarDetallePlato
            // 
            this.btnEliminarDetallePlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarDetallePlato.BackColor = System.Drawing.Color.Red;
            this.btnEliminarDetallePlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetallePlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarDetallePlato.Location = new System.Drawing.Point(914, 86);
            this.btnEliminarDetallePlato.Name = "btnEliminarDetallePlato";
            this.btnEliminarDetallePlato.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarDetallePlato.TabIndex = 1;
            this.btnEliminarDetallePlato.Text = "Eliminar";
            this.btnEliminarDetallePlato.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDetallePlato
            // 
            this.btnAgregarDetallePlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarDetallePlato.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarDetallePlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetallePlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarDetallePlato.Location = new System.Drawing.Point(25, 85);
            this.btnAgregarDetallePlato.Name = "btnAgregarDetallePlato";
            this.btnAgregarDetallePlato.Size = new System.Drawing.Size(87, 36);
            this.btnAgregarDetallePlato.TabIndex = 0;
            this.btnAgregarDetallePlato.Text = "Agregar";
            this.btnAgregarDetallePlato.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1094, 142);
            this.dataGridView2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo Plato";
            // 
            // cmbTipoPlato
            // 
            this.cmbTipoPlato.FormattingEnabled = true;
            this.cmbTipoPlato.Location = new System.Drawing.Point(424, 34);
            this.cmbTipoPlato.Name = "cmbTipoPlato";
            this.cmbTipoPlato.Size = new System.Drawing.Size(121, 32);
            this.cmbTipoPlato.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(455, 31);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(55, 32);
            this.txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(678, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(119, 32);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Plato";
            // 
            // cmbPlato
            // 
            this.cmbPlato.FormattingEnabled = true;
            this.cmbPlato.Location = new System.Drawing.Point(895, 31);
            this.cmbPlato.Name = "cmbPlato";
            this.cmbPlato.Size = new System.Drawing.Size(121, 32);
            this.cmbPlato.TabIndex = 13;
            // 
            // frmAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 905);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.grbComida);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAdministrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrar";
            this.grbComida.ResumeLayout(false);
            this.grbComida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox grbComida;
        private System.Windows.Forms.Button btnEditarTipoPlato;
        private System.Windows.Forms.Button btnEliminarTipoPlato;
        private System.Windows.Forms.Button btnAgregarTipoPlato;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.TextBox txtTipoPlato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlato;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnEditarDetallePlato;
        private System.Windows.Forms.Button btnEliminarDetallePlato;
        private System.Windows.Forms.Button btnAgregarDetallePlato;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbTipoPlato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPlato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}