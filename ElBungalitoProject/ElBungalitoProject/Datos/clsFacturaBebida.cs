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
    internal class clsFacturaBebida
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable Tabla = new DataTable();
        SqlCommand Cmd = new SqlCommand();

        public void RegistrarFacturaBebida(int idDetalleBebida, int cantidad, double subTotal, int numOrden)
        {
            try
            {
                Cmd.Connection = cn.AbrirConexion();
                Cmd.CommandText = "Insert into DetalleFacturaBebida (idDetalleBebida, Cantidad, SubTotal, NumOrden) values ('" + idDetalleBebida + "' , '" + cantidad + "' , '" + subTotal + "' , '" + numOrden + "')";
                Cmd.ExecuteNonQuery();
                cn.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en registrar sus Bebidas" + ex);
            }
        }
    }
}
