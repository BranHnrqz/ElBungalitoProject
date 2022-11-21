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
    public partial class frmOrdenar : Form
    {
        ToolTip tip = new ToolTip();

        //Instancia de las clases dentro de negocio
        clsGestionTipoPlato GTP = new clsGestionTipoPlato(); // GPT = Gestion Tipo Plato
        clsGestionPlato GP = new clsGestionPlato(); //GP = Gestion Plato
        clsGestionDetallePlato GDP = new clsGestionDetallePlato(); //GDP = Gestion Detalle Plato

        public frmOrdenar()
        {
            InitializeComponent();
            panelFill.Visible = false;

            //Ocultar controles de platillos al inicializar
            lbEspecialidadPlato.Visible = false;
            cmbEspecialidadPlato.Visible = false;
            numCantidadPlato.Visible = false;
            lbCantidadPlato.Visible = false;
            lbPrecioPlato.Visible = false;
            txtSubTotalPlato.Visible = false;
        }

        private void frmOrdenar_Load(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                panelFill.Visible = true;

                //Cargar los datos de la tabla tipo plato en su cmb
                cmbTipoPlato.Text = "";
                cmbTipoPlato.DataSource = GTP.ViewTipoPlato();
                cmbTipoPlato.DisplayMember = "Tipo";
                cmbTipoPlato.ValueMember = "idTipoPlato";
                cmbPlato.Text = "";
            }
            else
                MessageBox.Show("Debe´agregar su nombre", "Llene el recuadro");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cada vez que cambie el indice seleccionado (SelectedIndexChanged) va a mostrar el siguiente cmb con los datos correspondientes
        private void cmbTipoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiar el datatable
            GP.ViewPlatoWhere(cmbTipoPlato.Text).Clear();
            //Cargar los datos del cmb
            cmbPlato.DataSource = GP.ViewPlatoWhere(cmbTipoPlato.Text);
            cmbPlato.DisplayMember = "Plato";
            cmbPlato.ValueMember = "idPlato";
        }

        private void cmbPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlato.Text != "System.Data.DataRowView" && cmbPlato.ValueMember != "System.Data.DataRowView" && cmbPlato.Text != "") //Para que no muestre los controles si tiene datos en blanco
            {
                //Mostrar controles
                lbEspecialidadPlato.Visible = true;
                cmbEspecialidadPlato.Visible = true;

                GDP.ViewDetallePlatoWhere(cmbPlato.Text).Clear();
                cmbEspecialidadPlato.Text = "";
                cmbEspecialidadPlato.DataSource = GDP.ViewDetallePlatoWhere(cmbPlato.Text);
                cmbEspecialidadPlato.DisplayMember = "Especialidad";
                cmbEspecialidadPlato.ValueMember = "idDetallePlato";
            }
        }

        private void cmbEspecialidadPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidadPlato.Text != "System.Data.DataRowView" && cmbEspecialidadPlato.ValueMember != "System.Data.DataRowView" && cmbEspecialidadPlato.Text != "")
            {
                tip.SetToolTip(this.cmbEspecialidadPlato, GDP.ViewItemsDetalle(cmbEspecialidadPlato.Text).Item2);
                lbCantidadPlato.Visible = true;
                numCantidadPlato.Visible = true;
            }
            else
            {
                lbCantidadPlato.Visible = false;
                numCantidadPlato.Visible = false;
            }
        }

        private void numCantidadPlato_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numCantidadPlato.Value > 0)
            {
                lbPrecioPlato.Visible = true;
                txtSubTotalPlato.Visible = true;
                txtSubTotalPlato.Clear();
                double Precio = 0;
                Precio = GDP.ViewItemsDetalle(cmbEspecialidadPlato.Text).Item1 * (int)numCantidadPlato.Value;
                txtSubTotalPlato.Text = Precio.ToString();
            }
            else
            {
                lbPrecioPlato.Visible = false;
                txtSubTotalPlato.Visible = false;
            }
        }


    }
}
