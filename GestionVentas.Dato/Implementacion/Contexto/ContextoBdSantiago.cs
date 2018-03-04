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


        public DbSet<cotizacion> Cotizacion { get; set; }
        public DbSet<cotizacionrepuesto> CotizacionRepuesto { get; set; }
        public DbSet<cotizaciontrabajoterceros> CotizacionTerceros { get; set; }
        public DbSet<contabilidad> Contabilidad { get; set; }
        public DbSet<contabilidadfacturacion> ContabilidadFacturacion { get; set; }
        public DbSet<contabilidadformapago> ContabilidadFormaPago { get; set; }
        public DbSet<contabilidaddescuentos> ContabilidadDescuentos { get; set; }
        public DbSet<contabilidadaprobacion> ContabilidadAprobacion { get; set; }
        public DbSet<usuario> Usuario { get; set; }
        public DbSet<persona> Persona { get; set; }
    }
}
