﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetAllByCategory(string BookCategory);

        List<Book> GetAllByName(string BookName);
    }
}
