﻿using Business.Abstract;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll()); 
        }

        IDataResult<Category> ICategoryService.GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));
        }
    }
}
