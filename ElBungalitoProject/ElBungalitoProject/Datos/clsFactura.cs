using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ElBungalitoProject.Datos
{
    internal class clsFactura
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable Tabla = new DataTable();
        SqlCommand Cmd = new SqlCommand();

        public void RegistrarFactura(double pagoTotal, int Orden)
        {
            try
            {
                Cmd.Connection = cn.AbrirConexion();
                Cmd.CommandText = "Insert into Factura (PagoTotal, Orden) values ('" + pagoTotal + "' , '" + Orden + "')";
                Cmd.ExecuteNonQuery();
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en registrar su Factura" + ex);
            }
        }
    }
}
