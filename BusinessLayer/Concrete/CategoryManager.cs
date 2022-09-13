using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category t)
        {
            _categoryDal.Insert(t);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> getList()
        {
            return _categoryDal.GetListAll();
        }

        public void Remove(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void Update(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
