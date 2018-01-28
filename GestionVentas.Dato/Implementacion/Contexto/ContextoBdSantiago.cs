using GestionVentas.Dato.Implementacion.Contexto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Contexto
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class ContextoBdSantiago : DbContext
    {
        const string CADENA_CONEXION_KEY = "bd_santiagoEntities";

        public ContextoBdSantiago() : base(nameOrConnectionString: ConfigurationManager.ConnectionStrings[CADENA_CONEXION_KEY].ConnectionString)
        {
            Database.SetInitializer<ContextoBdSantiago>(new ContextoBdInicializador());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<presupuesto> Presupuesto { get; set; }
        public DbSet<presupuesto_comercial> PresupuestoComercial { get; set; }
        public DbSet<presupuesto_orden_trabajo> PresupuestoOrdenTrabajo { get; set; }
        public DbSet<presupuesto_repuesto> PresupuestoRepuesto { get; set; } //presupesto_repuesto
        public DbSet<presupuesto_repuesto_desgloce> PresupuestoRepuestoDetalle { get; set; }
        public DbSet<presupuesto_trabajo_terceros> PresupuestoTerceros { get; set; }
        public DbSet<repuesto> Repuesto { get; set; }
        public DbSet<presupuesto_trabajo_resumen> PresupuestoTrabajoResumen { get; set; }
        public DbSet<presupuesto_trabajo_resumen_comercial_detalle> PresupuestoResumenComercialDetalle { get; set; }
        public DbSet<presupuesto_trabajo_resumen_comision_desgloce> PresupuestoResumenComisionDesgloce { get; set; }
        public DbSet<presupuesto_trabajo_resumen_comision_detalle> PresupuestoResumenComisionDetalle { get; set; }
        public DbSet<presupuesto_trabajo_resumen_mo_detalle> PresupuestoResumenMoDetalle { get; set; }
    }
}
