using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;

namespace ElBungalitoProject.Negocio
{
    internal class clsGestionFacturaBebida
    {
        clsFacturaBebida facturaBebida = new clsFacturaBebida();
        public void RegistrarFBebida(int idDetalleBebida, int cantidad, double subTotal, int numOrden)
        {
            facturaBebida.RegistrarFacturaBebida(idDetalleBebida, cantidad, subTotal, numOrden);
        }
    }
}
