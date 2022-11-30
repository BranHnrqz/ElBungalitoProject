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
    internal class clsConexion
    {
        private SqlConnection cn = new SqlConnection("Data Source=LAPTOP-9EEEJEMK ;Initial Catalog=Bungalito;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo abrir la conexión", ex.Message);
            }
            return null;
        }
        public SqlConnection CerrarConexion()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                return cn;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error no se pudo cerrar la conexión", ex.Message);
            }
            return null;
        }
    }
}
