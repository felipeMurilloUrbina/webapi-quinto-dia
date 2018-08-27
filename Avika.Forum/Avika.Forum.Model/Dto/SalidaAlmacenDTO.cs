using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.Model.Dto
{
    public class SalidaAlmacenDTO
    {
        public decimal Fecha { get; set; }
        public decimal Hora { get; set; }
        public string Folio { get; set; }
        public int NumeroFila { get; set; }
        public string CodigoArticulo { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string CodigoBodega { get; set; }
        public string CodigoCentroCosto1 { get; set; }
        public string CodigoCentroCosto2 { get; set; }
        public string Usuario { get; set; }
        public string Posicion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoPromedio { get; set; }
    }
}
