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
    internal class clsGestionFacturaPlato
    {
        clsFacturaPlato facturaPlato = new clsFacturaPlato();
        public void RegistrarFPlato(int idDetallePlato, int cantidad, double subTotal, int numOrden)
        {
            facturaPlato.RegistrarFacturaPlato(idDetallePlato, cantidad, subTotal, numOrden);
        }
    }
}
