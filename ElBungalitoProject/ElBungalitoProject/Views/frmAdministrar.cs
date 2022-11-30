using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElBungalitoProject.Views
{
    public partial class frmAdministrar : Form
    {
        public frmAdministrar()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerOrdenes frmVerOrdenes = new frmVerOrdenes();
            frmVerOrdenes.Show();
        }
    }
}
