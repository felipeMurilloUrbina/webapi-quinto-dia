using Avika.Forum.BLL.Properties;
using Avika.Forum.DAO;
using Avika.Forum.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Avika.Forum.BLL
{
    public class DepartmentService : IDepartmentService
    {
        string _element = "Departamento";
        private readonly DepartmentRepository _repository = null;
        public DepartmentService(DepartmentRepository repository)
        {
            this._repository = repository;
        }
        public async Task<Pagination<Department>> Get(int? page, int? qty)
        {
            var _departments = _repository.Get(page, qty).Result;
            return _departments;
        }
        public async Task<Department> Get(int id)
        {
            return await this._repository.GetId(id);
        }
        public async Task<int> Post(Department department)
        {
            department.DateCreation = DateTime.Now;
            department.Active = true;
            var categoryExists = this._repository.FindBy(x => x.Description.Equals(department.Description));
            if (categoryExists.Count > 0)
                return -1;
            return await this._repository.Save(department);
        }
        public int Put(Department department)
        {
            if (department.Id == 0)
                return -1;
            var _department = this._repository.GetId(department.Id).Result;
            if (_department == null)
                return -1;
            var exist =  this._repository.FindBy(x => x.Description.Equals(department.Description));
            if (exist.Count > 0)
            {
                return -1;
            }
            _department.Description = department.Description;
            _department.UserModificatorId = department.UserModificatorId;
            return  this._repository.Save(_department).Result;
        }
        public async Task<int> Delete(int id)
        {
            var department = await this._repository.GetId(id);
            department.Active = false;
            return await this._repository.Delete(department);
        }

     
    }
}
