using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;

namespace Library.DataAccess.Concrete.EntityFramework
{
   public class EfKitapDal:EfRepositoryBase<Kitap,LibraryDBContext>,IKitapDal
    {
    }
}
