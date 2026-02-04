using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class Book
    {
        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public string? DescriptionBook { get; set; }
        public int PagesBook { get; set; }
        public int PublicationYearBook { get; set; }
        public decimal PriceBook { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookGenre> BookGenres { get; set; }
        public List<BookCopy> BookCopies { get; set; }
    }
}