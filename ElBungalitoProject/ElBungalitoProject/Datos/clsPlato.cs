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
    internal class clsPlato
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable SelectWherePlato(string where)
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = " select idPlato, Plato from Plato inner join TipoPlato on TipoPlato.idTipoPlato = Plato.idTipoPlato where Tipoplato.Tipo = '" + where + "'";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla Plato");
            }
            cn.CerrarConexion();
            return dt;
        }
    }
}
