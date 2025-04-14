using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    [SecuredOperation("product.add,admin")]
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [ValidationAspect(typeof(CategoryValidator))]

        public IResult Add(Category category)
        {
            var result = BusinessRules.Run(CheckIfCategoryNameExists(category.CategoryName));
            if(result != null)
            {
                return result;
            }

            _categoryDal.Add(category);
            return new SuccessResult(message: Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(message: Messages.CategoryDeleted);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(message: Messages.CategoryUpdated);
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), message: Messages.CategoryListed); 
        }

        IDataResult<Category> ICategoryService.GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id), message: Messages.CategoriesById);
        }

        public IResult CheckIfCategoryNameExists(string categoryName)
        {
            var result = _categoryDal.GetAll(c => c.CategoryName == categoryName).Any();
            if (result) {
                return new ErrorResult(message: Messages.CategoryNameAlreadyExists);
            }
            return new SuccessResult();

        }

    }
}
