using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.DAO
{
   public  class Pagination<T> where T : class
    {
        public int CurrentPage { get; set; }

        public int ItemPerPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public ICollection<T> Items { get; set; }
    }
}
