using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntityFramework
{
    public class LibraryDBContext:DbContext
    {
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
    }
}
