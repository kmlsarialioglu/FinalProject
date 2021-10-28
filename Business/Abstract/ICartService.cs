using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService 
    {
        IResult Add(Cart Cart);
        IResult Delete(Cart Cart);
        IResult Update(Cart Cart);
        IDataResult<Cart> GetById(long Id);

    }
}
