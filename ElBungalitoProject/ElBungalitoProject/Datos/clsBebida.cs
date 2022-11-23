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
    internal class clsBebida
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable SelectWhereBebida(string where)
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = " select idBebida, Bebida from Bebida inner join TipoBebida on TipoBebida.idTipoBebida = Bebida.idTipoBebida where TipoBebida.Tipo = '" + where + "'";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla Bebida");
            }
            cn.CerrarConexion();
            return dt;
        }
    }
}
