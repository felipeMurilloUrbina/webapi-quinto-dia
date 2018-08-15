using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.Model
{
    public class ArticuloDTO
    {
        public int Id {get; set;}
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string TipoMaterial { get; set; }
        public string Categoria { get; set; }
        public decimal Existencia { get; set; }
        public decimal CostoPromedio { get; set; }
        public decimal ValorInventario { get; set; }
    }
}
