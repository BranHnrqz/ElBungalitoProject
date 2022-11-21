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
    internal class clsDetallePlato
    {
        private clsConexion cn = new clsConexion();
        SqlDataReader read;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable SelectDetallePlatoWhere(string where)
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = "select * from DetallePlato inner join Plato on DetallePlato.idPlato = Plato.idPlato where Plato.Plato = '" + where + "'";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);
                cn.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla DetallePlato");
            }
            return dt;
        }

        public Tuple<double, string> SelectItemsDetalleWhere(string where)
        {

            double precio = 0;
            string descripcion= "";
            cmd.Connection = cn.AbrirConexion();
            cmd.CommandText = "select * from DetallePlato where Especialidad = '" + where + "'";
            cmd.CommandType = CommandType.Text;
            read = cmd.ExecuteReader();
            if (read.Read() == true)
            {
                precio = (double)read["Precio"];
                descripcion = read["Descripcion"].ToString();
            }
            cn.CerrarConexion();
            return Tuple.Create(precio, descripcion);
        }
    }
}
