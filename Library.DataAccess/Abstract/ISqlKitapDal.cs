﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entities.Concrete;

namespace Library.DataAccess.Abstract
{
   public interface ISqlKitapDal
   {
       List<Kitap> KitapList();
        List<Kitap> ListKitapByCategory(int id);
        void AddCategory(string categoryName);

   }
}