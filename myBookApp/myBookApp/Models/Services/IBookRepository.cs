using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
   public interface IBookRepository
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
        Book GetBook(int id);
        IEnumerable<Book> GetAllBook();
    }
}
