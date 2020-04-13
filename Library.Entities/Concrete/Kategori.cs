using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities.Abstract;

namespace Library.Entities.Concrete
{
   public class Kategori:IEntity
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
    }
}
