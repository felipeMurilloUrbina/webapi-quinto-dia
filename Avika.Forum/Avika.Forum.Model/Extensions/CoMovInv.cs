using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.Model
{
    public partial class CoMovInv : IObject
    {
        [NotMapped]
        public int Id { get; set; }
    }
}
