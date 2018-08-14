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
    public partial class CoArtBod
    {
        public string NumArtArb { get; set; } // num_art_arb (Primary key) (length: 15)
        public string BodegaArb { get; set; } // bodega_arb (Primary key) (length: 3)
        public string StatusArb { get; set; } // status_arb (length: 1)
        public string PrevStatArb { get; set; } // prev_stat_arb (length: 1)
        public decimal? CanExiArb { get; set; } // can_exi_arb
        public decimal? CanAsiArb { get; set; } // can_asi_arb
        public decimal? CanPenArb { get; set; } // can_pen_arb
        public decimal? CanOrdArb { get; set; } // can_ord_arb
        public decimal? PrecioArb { get; set; } // precio_arb
        public decimal? CtoPromArb { get; set; } // cto_prom_arb
        public decimal? ValorInvArb { get; set; } // valor_inv_arb
        public decimal? UltCtoArb { get; set; } // ult_cto_arb
        public decimal? FecIniProArb { get; set; } // fec_ini_pro_arb
        public decimal? FecFinProArb { get; set; } // fec_fin_pro_arb
        public decimal? FecUltVtaArb { get; set; } // fec_ult_vta_arb
        public decimal? PrePromArb { get; set; } // pre_prom_arb
        public decimal? CanUltVtaArb { get; set; } // can_ult_vta_arb
        public decimal? FecUltConArb { get; set; } // fec_ult_con_arb
        public decimal? VecInvFisArb { get; set; } // vec_inv_fis_arb
        public decimal? ErrUltConArb { get; set; } // err_ult_con_arb
        public decimal? VendPerArb { get; set; } // vend_per_arb
        public decimal? CanVenPerArb { get; set; } // can_ven_per_arb
        public decimal? VtaPerArb { get; set; } // vta_per_arb
        public decimal? CtoPerArb { get; set; } // cto_per_arb
        public decimal? VendAnoArb { get; set; } // vend_ano_arb
        public decimal? CanVenAnoArb { get; set; } // can_ven_ano_arb
        public decimal? DevAnoArb { get; set; } // dev_ano_arb
        public decimal? VtaAnoArb { get; set; } // vta_ano_arb
        public decimal? CtoAnoArb { get; set; } // cto_ano_arb
        public decimal? VenAnoAntArb { get; set; } // ven_ano_ant_arb
        public decimal? CanVenAntArb { get; set; } // can_ven_ant_arb
        public decimal? VtaAnoAntArb { get; set; } // vta_ano_ant_arb
        public decimal? CtoAnoAntArb { get; set; } // cto_ano_ant_arb
        public decimal? CanComAnoArb { get; set; } // can_com_ano_arb
        public decimal? ComAnoArb { get; set; } // com_ano_arb
        public decimal? CanComAntArb { get; set; } // can_com_ant_arb
        public decimal? ComAntArb { get; set; } // com_ant_arb
        public decimal? MgenVtaArb { get; set; } // mgen_vta_arb
        public decimal? MinCompArb { get; set; } // min_comp_arb
        public decimal? MaxCompArb { get; set; } // max_comp_arb
        public decimal? InvSegArb { get; set; } // inv_seg_arb
        public decimal? OrdActArb { get; set; } // ord_act_arb
        public string CodImpuArb { get; set; } // cod_impu_arb (length: 5)
        public string CatProdArb { get; set; } // cat_prod_arb (length: 3)
        public string ClaInvArb { get; set; } // cla_inv_arb (length: 1)
        public string AplLisPreArb { get; set; } // apl_lis_pre_arb (length: 1)
        public string AplDctoArb { get; set; } // apl_dcto_arb (length: 1)
        public decimal? DctoArb { get; set; } // dcto_arb
        public string LocalizacionArb { get; set; } // localizacion_arb (length: 10)

        public CoArtBod()
        {
            StatusArb = "";
            PrevStatArb = "";
            CanExiArb = 0m;
            CanAsiArb = 0m;
            CanPenArb = 0m;
            CanOrdArb = 0m;
            PrecioArb = 0m;
            CtoPromArb = 0m;
            ValorInvArb = 0m;
            UltCtoArb = 0m;
            FecIniProArb = 0m;
            FecFinProArb = 0m;
            FecUltVtaArb = 0m;
            PrePromArb = 0m;
            CanUltVtaArb = 0m;
            FecUltConArb = 0m;
            VecInvFisArb = 0m;
            ErrUltConArb = 0m;
            VendPerArb = 0m;
            CanVenPerArb = 0m;
            VtaPerArb = 0m;
            CtoPerArb = 0m;
            VendAnoArb = 0m;
            CanVenAnoArb = 0m;
            DevAnoArb = 0m;
            VtaAnoArb = 0m;
            CtoAnoArb = 0m;
            VenAnoAntArb = 0m;
            CanVenAntArb = 0m;
            VtaAnoAntArb = 0m;
            CtoAnoAntArb = 0m;
            CanComAnoArb = 0m;
            ComAnoArb = 0m;
            CanComAntArb = 0m;
            ComAntArb = 0m;
            MgenVtaArb = 0m;
            MinCompArb = 0m;
            MaxCompArb = 0m;
            InvSegArb = 0m;
            OrdActArb = 0m;
            CodImpuArb = "";
            CatProdArb = "";
            ClaInvArb = "";
            AplLisPreArb = "";
            AplDctoArb = "";
            DctoArb = 0m;
            LocalizacionArb = "";
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
