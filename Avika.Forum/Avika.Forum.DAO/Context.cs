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
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<NewHasPhoto> NewHasPhotos { get; set; }
        public DbSet<New> News { get; set; }
        public Context()
           : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetUserConfiguration());
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            modelBuilder.Configurations.Add(new GranjaConfiguration());
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
        public static Context Create()
        {
            return new Context();
        }
    }
}
