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

    // COArtBod
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public class CoArtBodConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CoArtBod>
    {
        public CoArtBodConfiguration()
            : this("dbo")
        {
        }

        public CoArtBodConfiguration(string schema)
        {
            ToTable("COArtBod", schema);
            HasKey(x => new { x.NumArtArb, x.BodegaArb });

            Property(x => x.NumArtArb).HasColumnName(@"num_art_arb").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BodegaArb).HasColumnName(@"bodega_arb").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StatusArb).HasColumnName(@"status_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.PrevStatArb).HasColumnName(@"prev_stat_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.CanExiArb).HasColumnName(@"can_exi_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.CanAsiArb).HasColumnName(@"can_asi_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.CanPenArb).HasColumnName(@"can_pen_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.CanOrdArb).HasColumnName(@"can_ord_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.PrecioArb).HasColumnName(@"precio_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,6);
            Property(x => x.CtoPromArb).HasColumnName(@"cto_prom_arb").HasColumnType("decimal").IsOptional().HasPrecision(16,6);
            Property(x => x.ValorInvArb).HasColumnName(@"valor_inv_arb").HasColumnType("decimal").IsOptional().HasPrecision(16,2);
            Property(x => x.UltCtoArb).HasColumnName(@"ult_cto_arb").HasColumnType("decimal").IsOptional().HasPrecision(16,6);
            Property(x => x.FecIniProArb).HasColumnName(@"fec_ini_pro_arb").HasColumnType("decimal").IsOptional().HasPrecision(8,0);
            Property(x => x.FecFinProArb).HasColumnName(@"fec_fin_pro_arb").HasColumnType("decimal").IsOptional().HasPrecision(8,0);
            Property(x => x.FecUltVtaArb).HasColumnName(@"fec_ult_vta_arb").HasColumnType("decimal").IsOptional().HasPrecision(8,0);
            Property(x => x.PrePromArb).HasColumnName(@"pre_prom_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,6);
            Property(x => x.CanUltVtaArb).HasColumnName(@"can_ult_vta_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.FecUltConArb).HasColumnName(@"fec_ult_con_arb").HasColumnType("decimal").IsOptional().HasPrecision(8,0);
            Property(x => x.VecInvFisArb).HasColumnName(@"vec_inv_fis_arb").HasColumnType("decimal").IsOptional().HasPrecision(3,0);
            Property(x => x.ErrUltConArb).HasColumnName(@"err_ult_con_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,6);
            Property(x => x.VendPerArb).HasColumnName(@"vend_per_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.CanVenPerArb).HasColumnName(@"can_ven_per_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.VtaPerArb).HasColumnName(@"vta_per_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CtoPerArb).HasColumnName(@"cto_per_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.VendAnoArb).HasColumnName(@"vend_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.CanVenAnoArb).HasColumnName(@"can_ven_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.DevAnoArb).HasColumnName(@"dev_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.VtaAnoArb).HasColumnName(@"vta_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CtoAnoArb).HasColumnName(@"cto_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.VenAnoAntArb).HasColumnName(@"ven_ano_ant_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.CanVenAntArb).HasColumnName(@"can_ven_ant_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.VtaAnoAntArb).HasColumnName(@"vta_ano_ant_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CtoAnoAntArb).HasColumnName(@"cto_ano_ant_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CanComAnoArb).HasColumnName(@"can_com_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.ComAnoArb).HasColumnName(@"com_ano_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.CanComAntArb).HasColumnName(@"can_com_ant_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.ComAntArb).HasColumnName(@"com_ant_arb").HasColumnType("decimal").IsOptional().HasPrecision(15,2);
            Property(x => x.MgenVtaArb).HasColumnName(@"mgen_vta_arb").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.MinCompArb).HasColumnName(@"min_comp_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.MaxCompArb).HasColumnName(@"max_comp_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.InvSegArb).HasColumnName(@"inv_seg_arb").HasColumnType("decimal").IsOptional().HasPrecision(13,4);
            Property(x => x.OrdActArb).HasColumnName(@"ord_act_arb").HasColumnType("decimal").IsOptional().HasPrecision(7,0);
            Property(x => x.CodImpuArb).HasColumnName(@"cod_impu_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.CatProdArb).HasColumnName(@"cat_prod_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.ClaInvArb).HasColumnName(@"cla_inv_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.AplLisPreArb).HasColumnName(@"apl_lis_pre_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.AplDctoArb).HasColumnName(@"apl_dcto_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.DctoArb).HasColumnName(@"dcto_arb").HasColumnType("decimal").IsOptional().HasPrecision(5,2);
            Property(x => x.LocalizacionArb).HasColumnName(@"localizacion_arb").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
