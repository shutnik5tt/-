using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
//using _АИС__Книжного_магазина.Models;
namespace _АИС__Книжного_магазина.Models
{
    public class AIS_BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionBookCopy> TransactionBookCopies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=XYZ\\SQLEXPRESS;Database=AIS_Bookstore;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}