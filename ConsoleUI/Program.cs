using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager(new InMemoryBookDal());

            foreach (var book in bookManager.GetAll())
            {
                Console.WriteLine(book.BookName);
            }
            
        }
    }
}
