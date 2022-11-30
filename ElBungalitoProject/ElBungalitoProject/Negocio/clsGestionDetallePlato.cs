using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionDetallePlato
    {
        clsDetallePlato detallePlato = new clsDetallePlato();

        public DataTable ViewDetallePlatoWhere(string where)
        {
            DataTable table = new DataTable();
            table = detallePlato.SelectDetallePlatoWhere(where);
            return table;
        }

        public Tuple <double, string> ViewItemsDetalle(string where)
        {
            return detallePlato.SelectItemsDetallePlatoWhere(where);
        }

        public DataTable ViewDetallePlatoMenu(int where)
        {
            return detallePlato.InnerJoinDetallePlatoMenu(where);
        }

        public DataTable ViewAllDetallePlato()
        {
            return detallePlato.MostrarTodoDetalleIJ();
        }
    }
}
