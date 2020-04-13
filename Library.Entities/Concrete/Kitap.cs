using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities.Abstract;

namespace Library.Entities.Concrete
{
    public class Kitap:IEntity
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public int YazarId { get; set; }
        public string KitapAdi { get; set; }
        public string RafNo { get; set; }
        
        
    }
}
