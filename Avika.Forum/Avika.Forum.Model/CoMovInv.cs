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

    // COMovInv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.0.0")]
    public partial class CoMovInv
    {
        public decimal FecAsenMoi { get; set; } // fec_asen_moi (Primary key)
        public decimal HoraAsenMoi { get; set; } // hora_asen_moi (Primary key)
        public string ModuloMoi { get; set; } // modulo_moi (Primary key) (length: 1)
        public string PrefDocMoi { get; set; } // pref_doc_moi (Primary key) (length: 2)
        public string NumDocMoi { get; set; } // num_doc_moi (Primary key) (length: 8)
        public decimal NumLineaMoi { get; set; } // num_linea_moi (Primary key)
        public string NumArtMoi { get; set; } // num_art_moi (Primary key) (length: 15)
        public string BodegaMoi { get; set; } // bodega_moi (Primary key) (length: 3)
        public string BodDestMoi { get; set; } // bod_dest_moi (length: 3)
        public decimal? FecDocMoi { get; set; } // fec_doc_moi
        public string TipoDocMoi { get; set; } // tipo_doc_moi (length: 1)
        public string TipoMovMoi { get; set; } // tipo_mov_moi (length: 1)
        public string NumCteProvMoi { get; set; } // num_cte_prov_moi (length: 12)
        public string NumVenMoi { get; set; } // num_ven_moi (length: 4)
        public decimal? CanVieMoi { get; set; } // can_vie_moi
        public decimal? CantidadMoi { get; set; } // cantidad_moi
        public decimal? PrecioMoi { get; set; } // precio_moi
        public decimal? ImporteMoi { get; set; } // importe_moi
        public decimal? CtoVieMoi { get; set; } // cto_vie_moi
        public decimal? CtoUniMoi { get; set; } // cto_uni_moi
        public decimal? CtoPromMoi { get; set; } // cto_prom_moi
        public decimal? CtoAdiMoi { get; set; } // cto_adi_moi
        public string UsuarioMoi { get; set; } // usuario_moi (length: 10)
        public string ComentMoi { get; set; } // coment_moi (length: 30)
        public string NumEntSalMoi { get; set; } // num_ent_sal_moi (length: 8)
        public string NumTransMoi { get; set; } // num_trans_moi (length: 8)

        // Foreign keys

        /// <summary>
        /// Parent CoBodega pointed by [COMovInv].([BodegaMoi]) (FK_COMovInv_COBodega)
        /// </summary>
        public virtual CoBodega CoBodega { get; set; } // FK_COMovInv_COBodega

        public CoMovInv()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
