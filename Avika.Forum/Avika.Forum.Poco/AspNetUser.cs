// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Avika.Forum.Model
{
    using Avika.Forum.Model;

    // AspNetUsers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public partial class AspNetUser
    {
        public string Id { get; set; } // Id (Primary key) (length: 128)
        public System.DateTime JoinDate { get; set; } // JoinDate
        public string Avatar { get; set; } // Avatar
        public string Email { get; set; } // Email (length: 256)
        public bool EmailConfirmed { get; set; } // EmailConfirmed
        public string PasswordHash { get; set; } // PasswordHash
        public string SecurityStamp { get; set; } // SecurityStamp
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool PhoneNumberConfirmed { get; set; } // PhoneNumberConfirmed
        public bool TwoFactorEnabled { get; set; } // TwoFactorEnabled
        public System.DateTime? LockoutEndDateUtc { get; set; } // LockoutEndDateUtc
        public bool LockoutEnabled { get; set; } // LockoutEnabled
        public int AccessFailedCount { get; set; } // AccessFailedCount
        public string UserName { get; set; } // UserName (length: 256)
        public int GranjaId { get; set; } // GranjaId
        public string Nombre { get; set; } // Nombre
        public string Apellido { get; set; } // Apellido
        public bool Activo { get; set; } // Activo

        // Reverse navigation

        /// <summary>
        /// Child AspNetRoles (Many-to-Many) mapped by table [AspNetUserRoles]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetRole> AspNetRoles { get; set; } // Many to many mapping
        /// <summary>
        /// Child AspNetUserClaims where [AspNetUserClaims].[UserId] point to this entity (FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims.FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        /// <summary>
        /// Child AspNetUserLogins where [AspNetUserLogins].[UserId] point to this entity (FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins.FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId

        public AspNetUser()
        {
            GranjaId = 0;
            Activo = false;
            AspNetUserClaims = new System.Collections.Generic.List<AspNetUserClaim>();
            AspNetUserLogins = new System.Collections.Generic.List<AspNetUserLogin>();
            AspNetRoles = new System.Collections.Generic.List<AspNetRole>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
