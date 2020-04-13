using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities.Concrete;

namespace Library.Business.Abstract
{
   public interface IKitapService
    {
        List<Kitap> GetAll();
        List<Kitap> GetKitapByKategori(int categoryId);
        List<Kitap> GetKitapByKitapAdi(string kitapAdi);
        void Add(Kitap kitap);
        void Update(Kitap kitap);
        void Delete(Kitap kitap);
    }
}
