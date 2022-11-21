using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionTipoPlato
    {
        clsTipoPlato tipoPlato = new clsTipoPlato();

        public DataTable ViewTipoPlato()
        {
            DataTable table = new DataTable();
            table = tipoPlato.SelectTipoPlato();
            return table;
        }
    }
}
