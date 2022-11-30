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
        //Para poner las descripcion cuando el cursosr pasa sobre el cmb especialidad
        ToolTip tip = new ToolTip();

        //Instancia de las clases dentro de negocio
        clsGestionTipoPlato GTP = new clsGestionTipoPlato(); // GPT = Gestion Tipo Plato
        clsGestionPlato GP = new clsGestionPlato(); //GP = Gestion Plato
        clsGestionDetallePlato GDP = new clsGestionDetallePlato(); //GDP = Gestion Detalle Plato
        clsGestionOrden GO = new clsGestionOrden(); //GO = Gestion Orden
        clsGestionTipoBebida GTB = new clsGestionTipoBebida(); //GTB = Gestion Tipo Bebida
        clsGestionBebida GB = new clsGestionBebida(); // GB = Gestion Bebida
        clsGestionDetalleBebida GDB = new clsGestionDetalleBebida(); // GDB = Gestion Detalle Bebida
        clsGestionFacturaPlato GFP = new clsGestionFacturaPlato(); // GFP = Gestion Factura Plato
        clsGestionFacturaBebida GFB = new clsGestionFacturaBebida(); //GFB = Gestion Factura Bebida
        clsGestionFactura GF = new clsGestionFactura(); //GF = Gestion Factura

        public frmOrdenar()
        {
            InitializeComponent();
            txtNumOrden.Visible= false;

            //Deshabilitar controles
            panelFill.Enabled = false;
            cmbEspecialidadPlato.Enabled = false;
            numCantidadPlato.Enabled = false;
            txtSubTotalPlato.Enabled = false;
            cmbEspecialidadBebida.Enabled = false;
            numCantidadBebida.Enabled = false;
            txtSubTotalBebida.Enabled = false;
            txtTotalPagar.Enabled = false;
            btnDeleteBebida.Enabled=false;
            btnDeletePlato.Enabled=false;
        }

        private void frmOrdenar_Load(object sender, EventArgs e)
        {
            txtTotalPagar.Text = "0";
            txtNumOrden.Text = GO.idGenerate().ToString();
        }

        private void cargarDatosCmb()
        {
            try
            {
                GTP.ViewTipoPlato().Clear();
                GTB.ViewTipoBebida().Clear();
                panelFill.Enabled = true;

                //Cargar los datos de la tabla tipo plato en su cmb
                cmbTipoPlato.Text = "";
                cmbTipoPlato.DataSource = GTP.ViewTipoPlato();
                cmbTipoPlato.DisplayMember = "Tipo";
                cmbTipoPlato.ValueMember = "idTipoPlato";
                cmbPlato.Text = "";

                //Cargar los datos de la tabla tipo bebida en su cmb
                cmbTipoBebida.Text = "";
                cmbTipoBebida.DataSource = GTB.ViewTipoBebida();
                cmbTipoBebida.DisplayMember = "Tipo";
                cmbTipoBebida.ValueMember = "idTipoBebida";
                cmbBebida.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se ha podido cargar los datos");
            }
        }

        private void registrarOrden()
        {
            GO.RegistrarOrden(Convert.ToInt32(txtNumOrden.Text), txtNombre.Text);
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                cargarDatosCmb();
                registrarOrden();
                btnComenzar.Enabled = false;
                txtNombre.Enabled = false;
            }
            else
                MessageBox.Show("Debe agregar su nombre", "Llene el recuadro");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.Show();

        }

        //Código para los platillos
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
                cmbEspecialidadPlato.Enabled = true;
                numCantidadPlato.Value = 0;

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
                numCantidadPlato.Enabled = true;
                numCantidadPlato.Value = 0;
            }
            else
            {
                numCantidadPlato.Enabled = false;
            }
        }

        private void numCantidadPlato_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numCantidadPlato.Value > 0)
            {
                txtSubTotalPlato.Clear();
                double Precio = 0;
                Precio = GDP.ViewItemsDetalle(cmbEspecialidadPlato.Text).Item1 * (int)numCantidadPlato.Value;
                txtSubTotalPlato.Text = Precio.ToString();
            }
            else
            {
                txtSubTotalPlato.Text = "0"; ;
            }
        }

        public void AgregarPlatoDGV()
        {
            try
            {
                if (cmbTipoPlato.Text != "" && cmbPlato.Text != "" && cmbEspecialidadPlato.Text != "" && numCantidadPlato.Value != 0 && txtSubTotalPlato.Text != "")
                {
                    dgvPlato.Rows.Add(
                        cmbEspecialidadPlato.SelectedValue,
                        cmbPlato.Text,
                        cmbEspecialidadPlato.Text,
                        GDP.ViewItemsDetalle(cmbEspecialidadPlato.Text).Item1.ToString(),
                        numCantidadPlato.Value,
                        txtSubTotalPlato.Text
                    );
                    double total = 0;
                    for (int fila = 0; fila < dgvPlato.Rows.Count - 1; fila++)
                    {
                        string valor = dgvPlato.Rows[fila].Cells[5].Value.ToString();
                        total = total + Convert.ToDouble(valor);
                    }
                    double pagar = Convert.ToDouble(txtTotalPagar.Text) + total;
                    txtTotalPagar.Text = pagar.ToString();
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            AgregarPlatoDGV();
            if (dgvPlato.Rows.Count > 1)
            {
                btnDeletePlato.Enabled = true;
            }
        }

        //Código para bebida
        private void cmbTipoBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiar el datatable
            GB.ViewBebidaWhere(cmbTipoBebida.Text).Clear();
            //Cargar los datos del cmb
            cmbBebida.DataSource = GB.ViewBebidaWhere(cmbTipoBebida.Text);

            cmbBebida.DisplayMember = "Bebida";
            cmbBebida.ValueMember = "idBebida";
        }

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBebida.Text != "System.Data.DataRowView" && cmbBebida.ValueMember != "System.Data.DataRowView" && cmbBebida.Text != "") //Para que no muestre los controles si tiene datos en blanco
            {
                //Mostrar controles
                cmbEspecialidadBebida.Enabled = true;
                numCantidadBebida.Value = 0;

                GDB.ViewDetalleBebidaWhere(cmbBebida.Text).Clear();
                cmbEspecialidadBebida.Text = "";
                cmbEspecialidadBebida.DataSource = GDB.ViewDetalleBebidaWhere(cmbBebida.Text);
                cmbEspecialidadBebida.DisplayMember = "Especialidad";
                cmbEspecialidadBebida.ValueMember = "idDetalleBebida";
            }
        }

        private void cmbEspecialidadBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidadBebida.Text != "System.Data.DataRowView" && cmbEspecialidadBebida.ValueMember != "System.Data.DataRowView" && cmbEspecialidadBebida.Text != "")
            {
                tip.SetToolTip(this.cmbEspecialidadBebida, GDB.ViewItemsDetalleBebida(cmbEspecialidadBebida.Text).Item2);
                numCantidadBebida.Enabled = true;
                numCantidadBebida.Value = 0;
            }
            else
            {
                numCantidadBebida.Enabled = false;
            }
        }

        private void numCantidadBebida_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numCantidadBebida.Value > 0)
            {
                txtSubTotalBebida.Clear();
                double Precio = 0;
                Precio = GDB.ViewItemsDetalleBebida(cmbEspecialidadBebida.Text).Item1 * (int)numCantidadBebida.Value;
                txtSubTotalBebida.Text = Precio.ToString();
            }
            else
            {
                txtSubTotalBebida.Text = "0"; ;
            }
        }

        public void AgregarBebidaDGV()
        {
            try
            {
                if (cmbTipoBebida.Text != "" && cmbBebida.Text != "" && cmbEspecialidadBebida.Text != "" && numCantidadBebida.Value != 0 && txtSubTotalBebida.Text != "")
                {
                    dgvBebida.Rows.Add(
                        cmbEspecialidadBebida.SelectedValue,
                        cmbBebida.Text,
                        cmbEspecialidadBebida.Text,
                        GDB.ViewItemsDetalleBebida(cmbEspecialidadBebida.Text).Item1.ToString(),
                        numCantidadBebida.Value,
                        txtSubTotalBebida.Text
                    );
                    double total = 0;
                    for (int fila = 0; fila < dgvBebida.Rows.Count - 1; fila++)
                    {
                        string valor = dgvBebida.Rows[fila].Cells[5].Value.ToString();
                        total = total + Convert.ToDouble(valor);
                    }
                    double pagar = Convert.ToDouble(txtTotalPagar.Text) + total;
                    txtTotalPagar.Text = pagar.ToString();
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            AgregarBebidaDGV();
            if (dgvBebida.Rows.Count > 1)
            {
                btnDeleteBebida.Enabled = true;
            }
        }

        // Facturación

        //Agregar a DetalleFacturaPlato
        private void RegistrarFacturaPlato()
        {
            if (dgvPlato.Rows.Count != 1)
            {
                for (int fila = 0; fila < dgvPlato.Rows.Count - 1; fila++)
                {
                    GFP.RegistrarFPlato(
                        Convert.ToInt32(dgvPlato.Rows[fila].Cells[0].Value.ToString()),
                        Convert.ToInt32(dgvPlato.Rows[fila].Cells[4].Value.ToString()),
                        Convert.ToDouble(dgvPlato.Rows[fila].Cells[5].Value.ToString()),
                        Convert.ToInt32(txtNumOrden.Text)
                        );
                }
                MessageBox.Show("Se han registrado sus platos");
            }
        }

        //Agregar a DetalleFacturaPlato
        private void RegistrarFacturaBebida()
        {
            if (dgvBebida.Rows.Count != 1)
            {
                for (int fila = 0; fila < dgvBebida.Rows.Count - 1; fila++)
                {
                    GFB.RegistrarFBebida(
                        Convert.ToInt32(dgvBebida.Rows[fila].Cells[0].Value.ToString()),
                        Convert.ToInt32(dgvBebida.Rows[fila].Cells[4].Value.ToString()),
                        Convert.ToDouble(dgvBebida.Rows[fila].Cells[5].Value.ToString()),
                        Convert.ToInt32(txtNumOrden.Text)
                        );
                }
                MessageBox.Show("Se han registrado sus bebidas");
            }

        }

        private void RegistrarFactura()
        {
            GF.RegistrarFactura(Convert.ToDouble(txtTotalPagar.Text), Convert.ToInt32(txtNumOrden.Text));
            MessageBox.Show(txtNombre.Text + " su orden está completa, el monto a pagar es de: " + txtTotalPagar.Text + " favor pasar a caja a cancelar");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvPlato.Rows.Count != 1 || dgvBebida.Rows.Count != 1)
            {
                RegistrarFacturaPlato();
                RegistrarFacturaBebida();
                RegistrarFactura();
                Principal frmP = new Principal();
                frmP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tiene que añadir almenos un plato o una bebida");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu= new frmMenu();
            frmMenu.Show();
        }


        private void btnDeletePlato_Click(object sender, EventArgs e)
        {
            double total=0;
            if (dgvPlato.SelectedRows.Count > 0)
            {
                string valor = dgvPlato.CurrentRow.Cells[5].Value.ToString();
                total = total + Convert.ToDouble(valor);
                double pagar = Convert.ToDouble(txtTotalPagar.Text) - total;
                txtTotalPagar.Text = pagar.ToString();
                dgvPlato.Rows.Remove(dgvPlato.CurrentRow);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnDeleteBebida_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (dgvBebida.SelectedRows.Count > 0)
            {
                string valor = dgvBebida.CurrentRow.Cells[5].Value.ToString();
                total = total + Convert.ToDouble(valor);
                double pagar = Convert.ToDouble(txtTotalPagar.Text) - total;
                txtTotalPagar.Text = pagar.ToString();
                dgvBebida.Rows.Remove(dgvBebida.CurrentRow);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
    }
}
