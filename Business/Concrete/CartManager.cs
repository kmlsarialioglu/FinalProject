using Business.Abstract;
using Business.Constants;
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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public IResult Add(Cart cart)
        {
            _cartDal.Add(cart);
            return new SuccessResult(Messages.CartAdded);
        }

        public IResult Delete(Cart cart)
        {
            _cartDal.Delete(cart);
            return new SuccessResult(Messages.CartDeleted);
        }

        public IDataResult<Cart> GetById(long Id)
        {
            using var context = new KS_DBContext();
            {
                return new SuccessDataResult<Cart>(_cartDal.Get(c => c.CartId == Id));

            }
        }

        public IResult Update(Cart Cart)
        {
            _cartDal.Update(Cart);
            return new SuccessResult(Messages.CartAdded);
        }
    }
}
