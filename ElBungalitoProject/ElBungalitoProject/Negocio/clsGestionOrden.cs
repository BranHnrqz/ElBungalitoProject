using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionOrden
    {
        clsOrden orden = new clsOrden();

        public int idGenerate()
        {
            return orden.idOrden();
        }

        public void RegistrarOrden(int idOrden, string Nombre)
        {
            orden.RegistrarOrden(idOrden, Nombre);
        }
    }
}
