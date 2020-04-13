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
    public class KitapManager:IKitapService
    {
        private IKitapDal _kitapDal;
        public KitapManager(IKitapDal kitapDal)
        {
            _kitapDal = kitapDal;
        }

        public void Add(Kitap kitap)
        {
            _kitapDal.Add(kitap);
        }

        public void Delete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);
        }

        public void Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);
        }

        public List<Kitap> GetAll()
        {
            return _kitapDal.GetAll();
        }

        public List<Kitap> GetKitapByKategori(int categoryId)
        {
            return _kitapDal.GetAll(k => k.KategoriId == categoryId);
        }

        public List<Kitap> GetKitapByKitapAdi(string kitapAdi)
        {
            return _kitapDal.GetAll(k => k.KitapAdi.ToLower().Contains(kitapAdi.ToLower()));
        }

      
    }
}
