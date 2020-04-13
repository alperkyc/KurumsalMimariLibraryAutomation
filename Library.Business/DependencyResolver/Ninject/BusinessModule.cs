using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Business.Abstract;
using Library.Business.Concrete;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Library.Business.DependencyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IKitapService>().To<KitapManager>().InSingletonScope();
            Bind<IKitapDal>().To<EfKitapDal>().InSingletonScope();

            Bind<IKategoriService>().To<KategoriManager>().InSingletonScope();
            Bind<IKategoriDal>().To<EfKategoriDal>().InSingletonScope();
        }
    }
}
