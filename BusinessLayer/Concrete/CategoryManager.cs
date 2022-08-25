using BusinessLayer.Abstract;
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
        EfCategoryRepository categoryRepository;

        public CategoryManager()
        {
            categoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            categoryRepository.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            categoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public List<Category> getList()
        {
            return categoryRepository.GetListAll();
        }
    }
}
