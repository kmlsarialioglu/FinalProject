using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class SuplierManager : ISuplierService
    {
        ISuplierDal _suplierDal;
        public SuplierManager(ISuplierDal suplierDal)
        {
            _suplierDal = suplierDal;
        }
        [SecuredOperation("brand.admin,admin")]
        public IResult Add(Suplier suplier)
        {
            _suplierDal.Add(suplier);
            return new SuccessResult(Messages.SuplierAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Suplier suplier)
        {
            _suplierDal.Delete(suplier);
            return new SuccessResult(Messages.SuplierDeleted);
        }

        public IDataResult<Suplier> GetById(long Id)
        {
            return new SuccessDataResult<Suplier>(_suplierDal.Get(s => s.SuplierId == Id),Messages.SuplierListed);
        }

        [SecuredOperation("brand.admin,admin")]
        public IResult Update(Suplier suplier)
        {
            _suplierDal.Update(suplier);
            return new SuccessResult(Messages.SuplierUpdated);
        }
    }
}
