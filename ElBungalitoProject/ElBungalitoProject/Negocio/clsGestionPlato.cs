using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionPlato
    {
        clsPlato plato = new clsPlato();

        public DataTable ViewPlatoWhere(string where)
        {
            DataTable table = new DataTable();
            table = plato.SelectWherePlato(where);
            return table;
        }
    }
}
