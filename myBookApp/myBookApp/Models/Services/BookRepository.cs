using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public class BookRepository:IBookRepository
    {
        private readonly BookContext _db;

        public BookRepository(BookContext bookContext)
        {
            _db = bookContext;
        }

        public void AddBook(Book book)
        {
            _db.books.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _db.books.Remove(book);
            _db.SaveChanges();
        }

        public IEnumerable<Book> GetAllBook()
        {
            return _db.books;
        }

        public Book GetBook(int id)
        {
            return _db.books.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void UpdateBook(Book book)
        {
            _db.books.Update(book);
            _db.SaveChanges();

        }
    }
}
