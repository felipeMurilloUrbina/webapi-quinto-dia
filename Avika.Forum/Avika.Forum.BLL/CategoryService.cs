using Avika.Forum.DAO;
using Avika.Forum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Avika.Forum.BLL
{
    public class CategoryService
    {
        private readonly CategoryRepository _repository = null;
        public CategoryService(CategoryRepository repository)
        {
            this._repository = repository;
        }
        public async Task<Pagination<Category>> Get(int? page, int? qty)
        {
            var _categories = _repository.Get(page, qty).Result;
            return _categories;
        }
        public async Task<Category> Get(int id)
        {
            return await this._repository.GetId(id);
        }
        public async Task<int> Post(Category category)
        {
            category.DateCreation = DateTime.Now;
            category.Active = true;
            var categoryExists = this._repository.FindBy(x => x.Description.Equals(category.Description));
            if (categoryExists.Count > 0)
                return -1;
            return await this._repository.Save(category);
        }
        public async Task<int> Put(Category category)
        {
            return await this._repository.Save(category);
        }

        public async Task<int> Delete(int id)
        {
            var category = await this._repository.GetId(id);
            category.Active = false;
            return await this._repository.Delete(category);
        }
    }
}
