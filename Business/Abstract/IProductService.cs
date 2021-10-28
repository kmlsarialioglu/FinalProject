using Core;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(long productId);
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult <List <ProductDetailDto>> GetProductDetails();
        IDataResult<List<ProductDto>> GetPCategory();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);

    }
}
