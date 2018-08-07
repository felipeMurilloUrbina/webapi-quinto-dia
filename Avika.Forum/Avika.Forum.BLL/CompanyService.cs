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
    public class CompanyService
    {
        private readonly CompanyRepository _repository = null;
        string _element = "Sucursal";
        public CompanyService(CompanyRepository repository)
        {
            this._repository = repository;
        }
        public async Task<Pagination<Company>> Get(int? page, int? qty)
        {
            var _companies = _repository.Get(page, qty).Result;
            return _companies;
        }
        public async Task<Company> Get(int id)
        {
            return await this._repository.GetId(id);
        }
        public string Post(Company company)
        {
            company.DateCreation = DateTime.Now;
            company.Active = true;
            var error = validate(company);
            if (!string.IsNullOrEmpty(error))
                return error;
            var result = this._repository.Save(company).Result;

            return result > 0 ? "" : String.Format(Resources.SaveError, _element);
        }
        public async Task<string> Put(Company company)
        {
            //if (company.Id == 0)
            //    return "";
            var _company = await this._repository.GetId(company.Id);
            if (_company == null)
                return "";
            //_company.Name = company.Name ?? company.Name;
            //_company.LastName = company.LastName ?? _company.LastName;
            //_company.MotherLastName = company.MotherLastName ?? _company.MotherLastName;
            //_company.Job = company.Job ?? _company.Job;
            //_company.Rfc = company.Rfc ?? _company.Rfc;
            //_company.Curp = company.Curp ?? _company.Curp;
            //_company.Email = company.Email ?? company.Email;
            //_company.StartWorkDate = company.StartWorkDate == null ? _company.StartWorkDate : company.StartWorkDate;
            //_company.Gauge = company.Gauge;
            //_company.DepartmentId = company.DepartmentId != 0 ? company.DepartmentId : _company.DepartmentId;
            //_company.CompanyId = company.CompanyId;
            _company.UserModificatorId = company.UserModificatorId;
            _company.Code = company.Code;
            _company.Description = company.Description;
            _company.Address = company.Address;
            var error = validate(company);
            if (!string.IsNullOrEmpty(error))
                return error;
            var result = await this._repository.Save(_company);
            return result > 0 ? "" : String.Format(Resources.SaveError, _element);
        }
        public async Task<int> Delete(int id)
        {
            var company = await this._repository.GetId(id);
            company.Active = false;
            return await this._repository.Delete(company);
        }
        string validate(Company company)
        {
            if (String.IsNullOrEmpty(company.Description))
                return String.Format(Resources.EmptyData, _element, "La razon social");
            if (String.IsNullOrEmpty(company.Code))
                return String.Format(Resources.EmptyData, _element, "La Clave");
            var companies = _repository.FindBy(c => c.Code.Equals(company.Code) || c.Description.Equals(company.Description)).ToList();
            if (companies.FirstOrDefault(x => x.Id == company.Id) != null)
                return "";
            foreach (var compTemp in companies)
            {
                if (company.Code.Equals(compTemp.Code))
                    return String.Format(Resources.DuplicateData, "la clave", _element);
                if (company.Description.Equals(compTemp.Description))
                    return String.Format(Resources.DuplicateData, "La razón social", _element);
            }
            return "";
        }
    }
}
