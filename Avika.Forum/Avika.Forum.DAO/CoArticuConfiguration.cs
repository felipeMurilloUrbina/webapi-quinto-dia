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

    // COArticu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class CoArticuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CoArticu>
    {
        public CoArticuConfiguration()
            : this("dbo")
        {
        }

        public CoArticuConfiguration(string schema)
        {
            ToTable("COArticu", schema);
            HasKey(x => x.CodigoArt);

            Property(x => x.CodigoArt).HasColumnName(@"codigo_art").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DescripArt).HasColumnName(@"descrip_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.CatProdArt).HasColumnName(@"cat_prod_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.UniMedArt).HasColumnName(@"uni_med_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.UniMedVtaArt).HasColumnName(@"uni_med_vta_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.UniConvArt).HasColumnName(@"uni_conv_art").HasColumnType("decimal").IsOptional().HasPrecision(9,5);
            Property(x => x.UniMedComArt).HasColumnName(@"uni_med_com_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.PrecioArt).HasColumnName(@"precio_art").HasColumnType("decimal").IsOptional().HasPrecision(12,5);
            Property(x => x.TipMatArt).HasColumnName(@"tip_mat_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.CodActArt).HasColumnName(@"cod_act_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.AplicaIvaArt).HasColumnName(@"aplica_iva_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Descrip2Art).HasColumnName(@"descrip2_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.FacConvArt).HasColumnName(@"fac_conv_art").HasColumnType("decimal").IsOptional().HasPrecision(9,5);
            Property(x => x.LocalizaArt).HasColumnName(@"localiza_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.ProvArt).HasColumnName(@"prov_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.GarantArt).HasColumnName(@"garant_art").HasColumnType("decimal").IsOptional().HasPrecision(2,0);
            Property(x => x.CodArtProv).HasColumnName(@"cod_art_prov").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(13);
            Property(x => x.CodigoBarras).HasColumnName(@"codigo_barras").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.OrganArt).HasColumnName(@"organ_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.ClasifArt).HasColumnName(@"clasif_art").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            // Foreign keys
            HasOptional(a => a.CoCatPro).WithMany(b => b.CoArticus).HasForeignKey(c => c.CatProdArt).WillCascadeOnDelete(false); // FK_COArticu_COCatPro
            HasOptional(a => a.CoTipMat).WithMany(b => b.CoArticus).HasForeignKey(c => c.TipMatArt).WillCascadeOnDelete(false); // FK_COArticu_COTipMat
        }
    }

}
// </auto-generated>
