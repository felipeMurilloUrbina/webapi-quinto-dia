using System.Data.Entity;
using Avika.Forum.Model;

namespace Avika.Forum.DAO
{
    public interface IContext
    {
        DbSet<CoArticu> Articulos { get; set; }
        DbSet<CoArtBod> ArticulosBodegas { get; set; }
        //DbSet<AspNetRole> AspNetRoles { get; set; }
        //DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        //DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        //DbSet<AspNetUser> AspNetUsers { get; set; }
        DbSet<CoBodega> Bodegas { get; set; }
        DbSet<CoCatPro> Categorias { get; set; }
        DbSet<CoCentroCosto> CentroCostos { get; set; }
        //DbSet<Granja> Granjas { get; set; }
        DbSet<CoMovInv> MovimientosInventario { get; set; }
        DbSet<CoTipMat> Tipos { get; set; }

        void disabled();
        void enabled();
    }
}