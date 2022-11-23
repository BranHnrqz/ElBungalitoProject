using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElBungalitoProject.Datos;


namespace ElBungalitoProject.Negocio
{
    internal class clsGestionFactura
    {
        clsFactura factura = new clsFactura();
        public void RegistrarFactura(double pagoTotal, int orden)
        {
            factura.RegistrarFactura(pagoTotal, orden);
        }
    }
}
