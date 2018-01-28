using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionVentas.Negocio.Implementacion;

namespace GestionVentas.Pruebas
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void MetodosPruebas()
        {
            var impl = new PresupuestoSvcImpl();

            impl.obtenerPresupuestos();
        }
    }
}
