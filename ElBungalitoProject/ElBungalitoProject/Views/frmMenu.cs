using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElBungalitoProject.Negocio;

namespace ElBungalitoProject.Views
{
    public partial class frmMenu : Form
    {
        clsGestionTipoPlato GTP = new clsGestionTipoPlato();
        clsGestionDetallePlato GDP = new clsGestionDetallePlato();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBebidas frmBebidas = new frmBebidas();
            frmBebidas.Show();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrdenar frmOrdenar = new frmOrdenar();
            frmOrdenar.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cmbFiltroComida.Text = "";
            cmbFiltroComida.DataSource = GTP.ViewTipoPlato();
            cmbFiltroComida.DisplayMember = "Tipo";
            cmbFiltroComida.ValueMember = "idTipoPlato";
            dgvMenu.DataSource = GDP.ViewAllDetallePlato();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            GDP.ViewDetallePlatoMenu((int)cmbFiltroComida.SelectedValue).Clear();
            if (cmbFiltroComida.SelectedValue != null)
            {
                dgvMenu.DataSource = GDP.ViewDetallePlatoMenu((int)cmbFiltroComida.SelectedValue);
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            GDP.ViewAllDetallePlato().Clear();
            dgvMenu.DataSource = GDP.ViewAllDetallePlato();
        }
    }
}
