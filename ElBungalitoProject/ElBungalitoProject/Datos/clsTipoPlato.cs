using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ElBungalitoProject.Datos
{
    internal class clsTipoPlato
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable SelectTipoPlato()
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = "Select * from TipoPlato";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);
                cn.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla TipoPlato");
            }
            return null;
        }
    }
}
