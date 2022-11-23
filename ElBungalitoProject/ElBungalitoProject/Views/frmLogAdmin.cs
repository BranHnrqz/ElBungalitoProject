using ElBungalitoProject.Negocio;
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
    public partial class frmLogAdmin : Form
    {
        ClsLogin data = new ClsLogin();
        public frmLogAdmin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            data.Login(txtUsuario.Text, txtPass.Text);
        }
    }
}
