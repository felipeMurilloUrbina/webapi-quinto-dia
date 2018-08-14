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
        public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public string TipoMaterial { get; set; }
        public string Categoria { get; set; }
    }
}
