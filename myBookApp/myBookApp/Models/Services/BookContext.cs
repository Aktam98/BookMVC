using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Models
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base(options)
        {

        }
        public DbSet<Book> books { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Purchase> purchases { get; set; }
    }
}
