using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionBebida
    {
        clsBebida bebida = new clsBebida();

        public DataTable ViewBebidaWhere(string where)
        {
            DataTable table = new DataTable();
            table = bebida.SelectWhereBebida(where);
            return table;
        }
    }
}
