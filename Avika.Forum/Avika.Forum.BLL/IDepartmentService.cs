using System.Collections.Generic;
using System.Threading.Tasks;
using Avika.Forum.Model;
using Avika.Forum.DAO;

namespace Avika.Forum.BLL
{
    public interface IDepartmentService
    {
        Task<Pagination<Department>> Get(int? page, int? qty);
        Task<int> Post(Department departament);
        int Put(Department departament);
    }
}