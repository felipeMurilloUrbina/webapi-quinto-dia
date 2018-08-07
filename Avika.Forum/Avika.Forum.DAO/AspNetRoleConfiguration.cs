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


namespace Avika.Forum.DAO
{
    using Avika.Forum.Model;

    // AspNetRoles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class AspNetRoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetRole>
    {
        public AspNetRoleConfiguration()
            : this("dbo")
        {
        }

        public AspNetRoleConfiguration(string schema)
        {
            ToTable("AspNetRoles", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            HasMany(t => t.AspNetUsers).WithMany(t => t.AspNetRoles).Map(m =>
            {
                m.ToTable("AspNetUserRoles", "dbo");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
        }
    }

}
// </auto-generated>