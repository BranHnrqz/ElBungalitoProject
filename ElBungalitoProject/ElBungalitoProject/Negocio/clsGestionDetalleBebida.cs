using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionDetalleBebida
    {
        clsDetalleBebida detalleBebida = new clsDetalleBebida();

        public DataTable ViewDetalleBebidaWhere(string where)
        {
            DataTable table = new DataTable();
            table = detalleBebida.SelectDetalleBebidaWhere(where);
            return table;
        }

        public Tuple<double, string> ViewItemsDetalleBebida(string where)
        {
            return detalleBebida.SelectItemsDetalleBebidaWhere(where);
        }
    }
}
