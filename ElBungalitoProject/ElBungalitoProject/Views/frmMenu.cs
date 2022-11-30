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
    public partial class frmMenu : Form
    {
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
    }
}
