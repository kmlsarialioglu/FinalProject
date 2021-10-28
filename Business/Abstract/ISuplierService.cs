using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISuplierService
    {
        IResult Add(Suplier suplier);
        IResult Update(Suplier suplier);
        IResult Delete(Suplier suplier);
        IDataResult<Suplier> GetById(long Id);

    }
}