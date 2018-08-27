using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace Avika.Forum.WebApiAuthorization.Models
{
    public class User : IdentityUser
    {
        public string CadenaConexion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto { get {
                return $"{this.Nombre} {this.Apellido}";
            }
        }

        [Required]
        public DateTime JoinDate { get; set; }
        public bool Activo { get; set; }
        public string Avatar { get; set; }
        public ICollection<Conexion> Conexiones { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var usuario = manager.Users.Include(u=>u.Conexiones).FirstOrDefault(u=> u.Id== this.Id);
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            var conexionSerialize = Newtonsoft.Json.JsonConvert.SerializeObject(usuario.Conexiones.ToList());
            userIdentity.AddClaim(new Claim (ClaimTypes.UserData, conexionSerialize));
            userIdentity.AddClaim(new Claim ("NombreCompleto", usuario.NombreCompleto));
            return userIdentity;
        }
    }
}