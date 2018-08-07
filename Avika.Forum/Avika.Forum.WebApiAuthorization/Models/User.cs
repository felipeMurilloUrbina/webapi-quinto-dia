using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Avika.Forum.WebApiAuthorization.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string LastName { get; set; }
        public int ? CompanyId { get; set; }
        public int ? DepartmentId { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime ? IncorporationDate { get; set; }
        public string Rfc { get; set; }
        public string Language { get; set; }
        public bool Active { get; set; }
        public string Avatar { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
    }
}