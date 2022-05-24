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
    internal class CategoryManager : ICategoryService
    {
        //private readonly ICategoryService
        //_categoryService;
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        void IService<Category>.Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        List<Category> IService<Category>.GetAll()
        {
            throw new NotImplementedException();
        }

        Category IService<Category>.GetById(int id)
        {
            efCategoryRepository.GetById(id);
        }

        void IService<Category>.Insert(Category entity)
        {
            efCategoryRepository.Insert(entity);
        }

        void IService<Category>.Update(Category entity)
        {
            efCategoryRepository.Update(entity);
         }
    }
}
