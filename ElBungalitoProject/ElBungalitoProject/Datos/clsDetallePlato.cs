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

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla DetallePlato");
            }
            cn.CerrarConexion();
            return dt;
        }

        public Tuple<double, string> SelectItemsDetallePlatoWhere(string where)
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

        public DataTable InnerJoinDetallePlatoMenu(int where)
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = "Select P.Plato, DP.Especialidad, DP.Descripcion, DP.Precio from DetallePlato as DP inner join Plato as P on DP.idPlato = P.idPlato  inner join TipoPlato on P.idTipoPlato = TipoPlato.idTipoPlato where TipoPlato.idTipoPlato  = '" + where + "'";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla DetallePlato");
            }
            cn.CerrarConexion();
            return dt;
        }
        public DataTable MostrarTodoDetalleIJ()
        {
            try
            {
                cmd.Connection = cn.AbrirConexion();
                cmd.CommandText = "Select P.Plato, DP.Especialidad, DP.Descripcion, DP.Precio from DetallePlato as DP inner join Plato as P on DP.idPlato = P.idPlato  inner join TipoPlato on P.idTipoPlato = TipoPlato.idTipoPlato";
                cmd.CommandType = CommandType.Text;
                read = cmd.ExecuteReader();
                dt.Load(read);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error no se puede obtener la tabla DetallePlato");
            }
            cn.CerrarConexion();
            return dt;
        }
    }
}
