using Avika.Forum.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.Model
{
    public partial class CoArticu : IObject
    {
        public string TipoMaterialString
        {
            get
            {
                return this.CoTipMat != null ? $"{this.CoTipMat.DescripTim}" : "";
            }
        }
        public string CategoriaString
        {
            get
            {
                return this.CoCatPro != null ? $"{this.CoCatPro.DescripCap}" : "";
            }
        }
    }
}
