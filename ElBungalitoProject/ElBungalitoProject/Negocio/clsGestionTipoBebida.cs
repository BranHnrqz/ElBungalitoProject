using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionTipoBebida
    {
        clsTipoBebida tipoBebida = new clsTipoBebida();

        public DataTable ViewTipoBebida()
        {
            DataTable table = new DataTable();
            table = tipoBebida.SelectTipoBebida();
            return table;
        }
    }
}
