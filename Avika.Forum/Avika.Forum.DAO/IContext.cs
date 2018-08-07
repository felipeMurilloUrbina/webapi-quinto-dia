using System.Data.Entity;
using Avika.Forum.Model;

namespace Avika.Forum.DAO
{
    public interface IContext
    {
        DbSet<AspNetUser> AspNetUsers { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<NewHasPhoto> NewHasPhotos { get; set; }
        DbSet<New> News { get; set; }

        void disabled();
        void enabled();
    }
}