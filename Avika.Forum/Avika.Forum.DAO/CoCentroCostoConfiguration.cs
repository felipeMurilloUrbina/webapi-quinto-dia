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

    // COCentroCostos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class CoCentroCostoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CoCentroCosto>
    {
        public CoCentroCostoConfiguration()
            : this("dbo")
        {
        }

        public CoCentroCostoConfiguration(string schema)
        {
            ToTable("COCentroCostos", schema);
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName(@"codigo").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Descripcion).HasColumnName(@"descripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Variedad).HasColumnName(@"variedad").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Ingreso).HasColumnName(@"ingreso").HasColumnType("decimal").IsOptional().HasPrecision(16,2);
            Property(x => x.Porcentaje).HasColumnName(@"porcentaje").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.Cliente).HasColumnName(@"cliente").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(12);
        }
    }

}
// </auto-generated>
