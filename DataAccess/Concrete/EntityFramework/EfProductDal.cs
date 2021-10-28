using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, KS_DBContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (var context = new KS_DBContext())
            {
                var result = from c in context.Categories
                             join p in context.Products
                             on c.CategoryId equals p.CategoryId
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             join s in context.Supliers
                             on p.SuplierId equals s.SuplierId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 BrandName = b.BrandName,
                                 CategoryName = c.CategoryName,
                                 SuplierName = s.SuplierName,
                                 ProductDetail = p.ProductDetail,
                                 InStock = p.InStock,
                                 UnitPrice = p.UnitPrice,
                        
                             };
                return result.ToList();


            }
        }
        public List<ProductDto> GetPCategory()
        {
            using (var context = new KS_DBContext())
            {
                var result = from c in context.Categories
                             join p in context.Products
                             on c.CategoryId equals p.CategoryId
                             join sc in context.SubCategories
                             on c.CategoryId equals sc.CategoryId
                             join ssc in context.SubSubCategories
                             on sc.SubCategoryId equals ssc.SubCategoryId
                             join sssc in context.SubSubSubCategories
                             on ssc.SubSubCategoryId equals sssc.SubSubCategoryId
                             join ssssc in context.SubSubSubSubCategories
                             on sssc.SubSubSubCategoryId equals ssssc.SubSubSubCategoryId
                             select new ProductDto
                             {
                                 Name = p.ProductName,
                                 PCName = c.CategoryName,
                                 PSC1Name = sc.SubCategoryName,
                                 PSC2Name = ssc.SubSubCategoryName,
                                 PSC3Name = sssc.SubSubSubCategoryName,
                                 PSC4Name = ssssc.SubSubSubSubCategoryName,
                             };
                return result.ToList();


            }

        }

    }
}

