using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        //[SecuredOperation("product.add,admin")]
        //[ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect ("IProductService.Get")] 
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(
           CheckIfProductCountOfCategoryCorrect(product.CategoryId),
           CheckProductNameLeight(product.ProductName),
           CheckProductNameExists(product.ProductName));
           //CheckIfCategoryLimitExeded());
            if (result != null)
            {
                return result;
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }


        [SecuredOperation("product.delete")]
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Product> GetById(long productId)
        {
            using var context = new KS_DBContext();
            {
                return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId), Messages.ProductDetail);

            }
        }
        [TransactionScopeAspect]
        [CacheRemoveAspect("IProductService.Get")] //key,value
        //[SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            IResult result = BusinessRules.Run(
           CheckIfProductCountOfCategoryCorrect(product.CategoryId),
           CheckProductNameLeight(product.ProductName),
           CheckProductNameExists(product.ProductName));
           //CheckIfCategoryLimitExeded());
            if (result != null)
            {
                return result;
            }

            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId), Messages.ProductListed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IDataResult<List<ProductDto>> GetPCategory()
        {
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetPCategory());
        }


        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            if (result >= 100)
            {
                return new SuccessResult();

            }
            return new ErrorResult();

        }
        private IResult CheckProductNameExists(string name)
        {
            var result = _productDal.GetAll(p => p.ProductName == name).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);

            }
            return new SuccessResult();

        }
        private IResult CheckProductNameLeight(string name)
        {
            var result = _productDal.GetAll(p => p.ProductName == name).Count;
            if (result <= 3)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        //private IResult CheckIfCategoryLimitExeded()
        //{
        //    var result = _categoryService.GetAll();
        //    if (result.Data.Count > 15)
        //    {
        //        return new ErrorResult(Messages.CheckIfCategoryLimitExeded);
        //    }
        //    return new SuccessResult();

        //}

    }
}
