using Avika.Forum.Model;
using Avika.Forum.Model.Interfaces;
using EntityFramework.DynamicFilters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.DAO
{
    public class Context : DbContext, IContext
    {
        //public DbSet<AspNetRole> AspNetRoles { get; set; }
        //public DbSet<AspNetUser> AspNetUsers { get; set; }
        //public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<CoArtBod> ArticulosBodegas { get; set; }
        public DbSet<CoArticu> Articulos { get; set; }
        public DbSet<CoBodega> Bodegas { get; set; }
        public DbSet<CoCatPro> Categorias { get; set; }
        public DbSet<CoCentroCosto> CentroCostos{ get; set; }
        public DbSet<CoMovInv> MovimientosInventario { get; set; }
        public DbSet<CoTipMat> Tipos { get; set; }
        //public DbSet<Granja> Granjas { get; set; }
        public Context(string conexion)
           : base(conexion)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new AspNetUserConfiguration());
            //modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            //modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new CoArtBodConfiguration());
            modelBuilder.Configurations.Add(new CoArticuConfiguration());
            modelBuilder.Configurations.Add(new CoMovInvConfiguration());
            modelBuilder.Configurations.Add(new CoTipMatConfiguration());
            modelBuilder.Configurations.Add(new CoBodegaConfiguration());
            modelBuilder.Configurations.Add(new CoCentroCostoConfiguration());
            modelBuilder.Configurations.Add(new CoCatProConfiguration());
            //modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            //modelBuilder.Configurations.Add(new GranjaConfiguration());
            AddFilters(ref modelBuilder);
        }

        private void AddFilters(ref DbModelBuilder modelBuilder)
        {
            modelBuilder.Filter("DeleteLogic", (IDeleteLogic d) => d.Active, true);
        }

        public void disabled()
        {
            this.DisableFilter("DeleteLogic");
        }
        public void enabled()
        {
            this.EnableFilter("DeleteLogic");
        }
        //public static Context Create()
        //{
        //    return new Context();
        //}
    }
}
