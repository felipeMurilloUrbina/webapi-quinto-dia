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

    // COCatPro
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class CoCatProConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CoCatPro>
    {
        public CoCatProConfiguration()
            : this("dbo")
        {
        }

        public CoCatProConfiguration(string schema)
        {
            ToTable("COCatPro", schema);
            HasKey(x => x.CategoriaCap);

            Property(x => x.CategoriaCap).HasColumnName(@"categoria_cap").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DescripCap).HasColumnName(@"descrip_cap").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.DiasVenCap).HasColumnName(@"dias_ven_cap").HasColumnType("decimal").IsOptional().HasPrecision(3,0);
        }
    }

}
// </auto-generated>
