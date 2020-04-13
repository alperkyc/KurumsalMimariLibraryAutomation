using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Business.Abstract;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;

namespace Library.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public void Add(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
        }

        public void Delete(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
        }

        public List<Kategori> GetAll()
        {
            return _kategoriDal.GetAll();
        }

        public void Update(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
        }
    }
}
