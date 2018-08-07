using Avika.Forum.BLL.Properties;
using Avika.Forum.DAO;
using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.BLL
{
    public class EmployeeService
    {
        string _element = "empleado";
        private readonly EmployeeRepository _repository = null;
        public EmployeeService(EmployeeRepository repository)
        {
            this._repository = repository;
        }
        public async Task<Pagination<Employee>> Get(int? page, int? qty)
        {
            var _employees = _repository.Get(page, qty).Result;
            return _employees;
        }
        public async Task<Employee> Get(int id)
        {
            return await this._repository.GetId(id);
        }
        public string Post(Employee employee)
        {
            employee.DateCreation = DateTime.Now;
            employee.Active = true;
            var error = validate(employee);
            if (!string.IsNullOrEmpty(error))
                return error;
            var result= this._repository.Save(employee).Result;
            
            return result> 0 ? "" : String.Format(Resources.SaveError, _element);
        }
        public async Task<int> Put(Employee employee)
        {
            if (employee.Id == 0)
                return -1;
            var _employee = await this._repository.GetId(employee.Id);
            if (_employee == null)
                return -1;
            _employee.Name = employee.Name ?? employee.Name;
            _employee.LastName = employee.LastName ?? _employee.LastName;
            _employee.MotherLastName = employee.MotherLastName ?? _employee.MotherLastName;
            _employee.Job = employee.Job ?? _employee.Job;
            _employee.Rfc = employee.Rfc ?? _employee.Rfc;
            _employee.Curp = employee.Curp ?? _employee.Curp;
            _employee.Email = employee.Email ?? employee.Email;
            _employee.StartWorkDate = employee.StartWorkDate == null ? _employee.StartWorkDate : employee.StartWorkDate;
            _employee.Gauge = employee.Gauge;
            _employee.DepartmentId = employee.DepartmentId != 0 ? employee.DepartmentId : _employee.DepartmentId;
            _employee.CompanyId = employee.CompanyId;
            _employee.UserModificatorId = employee.UserModificatorId;
            return await this._repository.Save(_employee);
        }
        public async Task<int> Delete(int id)
        {
            var Employee = await this._repository.GetId(id);
            Employee.Active = false;
            return await this._repository.Delete(Employee);
        }
        string validate(Employee employee)
        {
            if (String.IsNullOrEmpty(employee.Name))
                return String.Format(Resources.EmptyData, _element, "El nombre");
            if (string.IsNullOrEmpty(employee.LastName))
                return String.Format(Resources.EmptyData, _element, "El apellido paterno");
            if (string.IsNullOrEmpty(employee.Rfc))
                return String.Format(Resources.EmptyData, _element, "El RFC");
            if (string.IsNullOrEmpty(employee.Curp))
                return String.Format(Resources.EmptyData, _element, "La CURP");
            if (string.IsNullOrEmpty(employee.Email))
                return String.Format(Resources.EmptyData, _element, "El email");
            var employees = this._repository.FindBy(x => x.Rfc.Equals(employee.Rfc) || x.Curp.Equals(employee.Curp) || x.Email.Equals(employee.Email));
            if ((employees != null) && (employees.Count > 0))
            {
                ////Accion Actualizacion
                //if (action == 2)
                //{
                if (employees.FirstOrDefault(x => x.Id == employee.Id) != null)
                    return "";
                //}
                foreach (var empTemp in employees)
                {
                    if (employee.Email.Equals(empTemp.Email))
                        return String.Format(Resources.DuplicateData, "El Correo", _element);
                    if (employee.Rfc.Equals(empTemp.Rfc))
                        return String.Format(Resources.EmptyData, "El RFC", _element);
                    if (employee.Curp.Equals(empTemp.Curp))
                        return String.Format(Resources.EmptyData, "La CURP", _element);
                }
            }

            return "";
        }
    }
}
