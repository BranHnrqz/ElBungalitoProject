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
    class clsTipoBebida
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable SelectTipoBebida()
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = "Select * from TipoBebida";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error no se puede obtener la tabla TipoBebida");
            }
            cn.CerrarConexion();
            return dt;
        }
    }
}
