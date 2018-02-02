using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionVentas.Negocio.Implementacion;
using GestionVentas.Negocio.Dto;

namespace GestionVentas.Pruebas
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void MetodosPruebas()
        {
            var impl = new PresupuestoSvcImpl();

            var idResumen = impl.guardarPresupuestoResumen(new PresupuestoTrabajoResumenDto
            {
                Descripcion = "valor",
                Presupuesto = 3,
                Subtotal = 123,
                TotalnetoComisiones = 1234
            });

            impl.guardarPresupuestoResumenMoDetalle(new PresupuestoResumenMoDetalleDto
            {
                HorasParejas = 11,
                PresupuestoTrabajoResumen = idResumen,
                RecargoHHEE = 12,
                Subtotal = 13,
                Total = 10
            });

            impl.guardarPresupuestoTrabajoComisionDetalle(new PresupuestoTRComisionDetalleDto
            {
                PresupuestoTrabajoResumen = idResumen,
                CantidadFletes = 2,
                TotalFletes = 100,
                ValorMargenVenta = 97,
                ValorVenta = 69
            });
        }
    }
}
