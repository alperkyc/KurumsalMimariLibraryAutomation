using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities.Abstract;

namespace Library.Entities.Concrete
{
    public class Yazar:IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Int16 DogumYili { get; set; }
        public string Email { get; set; }
    }
}
