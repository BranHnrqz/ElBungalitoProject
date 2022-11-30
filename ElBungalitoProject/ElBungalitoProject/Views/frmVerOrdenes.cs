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
    public partial class frmVerOrdenes : Form
    {
        public frmVerOrdenes()
        {
            InitializeComponent();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdministrar frm = new frmAdministrar();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();
        }
    }
}
