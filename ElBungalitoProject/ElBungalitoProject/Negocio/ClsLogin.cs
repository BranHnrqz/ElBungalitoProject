using ElBungalitoProject.Datos;
using ElBungalitoProject.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElBungalitoProject.Negocio
{
    internal class ClsLogin
    {
        clsConexion Conn = new clsConexion();
        SqlCommand Consulta = new SqlCommand();
        SqlDataReader LeerConsulta;
        public void Login(string Usuario, string Password)
        {
            try
            {
                Consulta.Connection = Conn.AbrirConexion();
                Consulta.CommandText = "Select Nombre, Pass From Administracion  WHERE (Nombre= '" + Usuario + "') AND Pass='" + Password + "'";

                LeerConsulta = Consulta.ExecuteReader();
                if (LeerConsulta.Read())
                {
                    frmAdministrar hh = new frmAdministrar();
                    frmLogAdmin pp = new frmLogAdmin();
                    pp.Close();
                    
                    hh.Show();
                   



                }
                else
                {
                    MessageBox.Show("Datos Incorrectos!!");

                }
                Consulta.Connection = Conn.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de acceso!!" + ex.Message);
            }
        }
    }
}
