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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grbComida = new System.Windows.Forms.GroupBox();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.btnAgregarPlato = new System.Windows.Forms.Button();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.btnEliminarPlato = new System.Windows.Forms.Button();
            this.btnEliminarBebida = new System.Windows.Forms.Button();
            this.btnEditarPlato = new System.Windows.Forms.Button();
            this.btnEditarBebida = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbComida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(772, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 852);
            this.panel1.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(29, 25);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(291, 43);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administración";
            // 
            // grbComida
            // 
            this.grbComida.Controls.Add(this.btnEditarPlato);
            this.grbComida.Controls.Add(this.btnEliminarPlato);
            this.grbComida.Controls.Add(this.btnAgregarPlato);
            this.grbComida.Location = new System.Drawing.Point(33, 78);
            this.grbComida.Name = "grbComida";
            this.grbComida.Size = new System.Drawing.Size(340, 356);
            this.grbComida.TabIndex = 2;
            this.grbComida.TabStop = false;
            this.grbComida.Text = "Platos";
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Location = new System.Drawing.Point(33, 464);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.Size = new System.Drawing.Size(340, 289);
            this.dgvPlatos.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarBebida);
            this.groupBox1.Controls.Add(this.btnEliminarBebida);
            this.groupBox1.Controls.Add(this.btnAgregarBebida);
            this.groupBox1.Location = new System.Drawing.Point(406, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bebidas";
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(406, 464);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.Size = new System.Drawing.Size(340, 289);
            this.dgvBebidas.TabIndex = 5;
            // 
            // btnAgregarPlato
            // 
            this.btnAgregarPlato.BackColor = System.Drawing.Color.Green;
            this.btnAgregarPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPlato.Location = new System.Drawing.Point(6, 314);
            this.btnAgregarPlato.Name = "btnAgregarPlato";
            this.btnAgregarPlato.Size = new System.Drawing.Size(87, 36);
            this.btnAgregarPlato.TabIndex = 0;
            this.btnAgregarPlato.Text = "Agregar";
            this.btnAgregarPlato.UseVisualStyleBackColor = false;
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.BackColor = System.Drawing.Color.Green;
            this.btnAgregarBebida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBebida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarBebida.Location = new System.Drawing.Point(6, 314);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(87, 36);
            this.btnAgregarBebida.TabIndex = 1;
            this.btnAgregarBebida.Text = "Agregar";
            this.btnAgregarBebida.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPlato
            // 
            this.btnEliminarPlato.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlato.Location = new System.Drawing.Point(130, 314);
            this.btnEliminarPlato.Name = "btnEliminarPlato";
            this.btnEliminarPlato.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarPlato.TabIndex = 1;
            this.btnEliminarPlato.Text = "Eliminar";
            this.btnEliminarPlato.UseVisualStyleBackColor = false;
            // 
            // btnEliminarBebida
            // 
            this.btnEliminarBebida.BackColor = System.Drawing.Color.Red;
            this.btnEliminarBebida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBebida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarBebida.Location = new System.Drawing.Point(130, 314);
            this.btnEliminarBebida.Name = "btnEliminarBebida";
            this.btnEliminarBebida.Size = new System.Drawing.Size(87, 36);
            this.btnEliminarBebida.TabIndex = 2;
            this.btnEliminarBebida.Text = "Eliminar";
            this.btnEliminarBebida.UseVisualStyleBackColor = false;
            // 
            // btnEditarPlato
            // 
            this.btnEditarPlato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarPlato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPlato.Location = new System.Drawing.Point(247, 314);
            this.btnEditarPlato.Name = "btnEditarPlato";
            this.btnEditarPlato.Size = new System.Drawing.Size(87, 36);
            this.btnEditarPlato.TabIndex = 2;
            this.btnEditarPlato.Text = "Editar";
            this.btnEditarPlato.UseVisualStyleBackColor = false;
            // 
            // btnEditarBebida
            // 
            this.btnEditarBebida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditarBebida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarBebida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarBebida.Location = new System.Drawing.Point(247, 314);
            this.btnEditarBebida.Name = "btnEditarBebida";
            this.btnEditarBebida.Size = new System.Drawing.Size(87, 36);
            this.btnEditarBebida.TabIndex = 3;
            this.btnEditarBebida.Text = "Editar";
            this.btnEditarBebida.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicio.Location = new System.Drawing.Point(566, 25);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(87, 36);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(659, 25);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(87, 36);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(322, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 45);
            this.panel2.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(144, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 36);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // frmAdministrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 833);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.dgvBebidas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPlatos);
            this.Controls.Add(this.grbComida);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAdministrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrar";
            this.panel1.ResumeLayout(false);
            this.grbComida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox grbComida;
        private System.Windows.Forms.Button btnEditarPlato;
        private System.Windows.Forms.Button btnEliminarPlato;
        private System.Windows.Forms.Button btnAgregarPlato;
        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarBebida;
        private System.Windows.Forms.Button btnEliminarBebida;
        private System.Windows.Forms.Button btnAgregarBebida;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
    }
}