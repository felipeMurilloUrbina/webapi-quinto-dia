using Avika.Forum.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.Model
{
    public partial class Employee: IObject, IDeleteLogic
    {
        [NotMapped]
        public string FullName { get
            {
                return $"{this.Name} {this.LastName} {this.MotherLastName}";
            }
        }
    }
}
