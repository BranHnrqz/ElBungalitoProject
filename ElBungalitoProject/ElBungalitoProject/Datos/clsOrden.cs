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
    internal class clsOrden
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable Tabla = new DataTable();
        SqlCommand Cmd = new SqlCommand();
        int idM;

        //Calcula el id de las ordenes
        public int idOrden()
        {
            try
            {
                Cmd.Connection = cn.AbrirConexion();
                Cmd.CommandText = "SELECT MAX(idOrden) as id FROM Orden";
                Cmd.CommandType = CommandType.Text;
                read = Cmd.ExecuteReader();
                if (read.Read() == true && read["id"].ToString() != "")
                {
                    idM = (int)read["id"];
                }
                else
                {
                    idM = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.CerrarConexion();
            return idM + 1;
        }

        //Metodo para insertar datos
        public void RegistrarOrden(int idOrden, string nombre)
        {
            try
            {
                Cmd.Connection = cn.AbrirConexion();
                Cmd.CommandText = "Insert into Orden (idOrden, Cliente) values ('" + idOrden + "' , '" + nombre + "')";
                Cmd.ExecuteNonQuery();
                cn.CerrarConexion();
                MessageBox.Show("Se ha registrado su orden");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en registrar su orden" + ex);
            }
        }
    }
}
