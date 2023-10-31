﻿using EntityLayer.Concreate; // Contact sınıfını kullanabilmek için bu kütüphaneyi ekledik
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {
    }
}