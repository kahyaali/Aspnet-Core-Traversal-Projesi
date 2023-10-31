﻿using EntityLayer.Concreate; // Comment sınıfını kullanabilmek için bu kütüphaneyi ekledik
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService: IGenericService<Comment>
    {
        List<Comment> TGetDestinationByID(int id);
        List<Comment> TGetListCommentWithDestination();
        public List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}