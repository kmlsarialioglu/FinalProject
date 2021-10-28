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
    public class EfCategoryDal : EfEntityRepositoryBase<Category, KS_DBContext>, ICategoryDal
    {
        public List<CategoryDto> GetCategory()
        {
            using (var context = new KS_DBContext())
            {
                var result = from c in context.Categories
                             join sc in context.SubCategories
                             on c.CategoryId equals sc.CategoryId
                             join ssc in context.SubSubCategories
                             on sc.SubCategoryId equals ssc.SubCategoryId
                             join sssc in context.SubSubSubCategories
                             on ssc.SubSubCategoryId equals sssc.SubSubCategoryId
                             join ssssc in context.SubSubSubSubCategories
                             on sssc.SubSubSubCategoryId equals ssssc.SubSubSubCategoryId
                             select new CategoryDto
                             {
                                 Name = c.CategoryName,
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
