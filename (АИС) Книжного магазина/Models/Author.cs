using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class Author
    {
        public int IdAuthor { get; set; }
        public string LastnameAuthor { get; set; }
        public string NameAuthor { get; set; }
        public string? MiddlenameAuthor { get; set; }
        public int? BirthYearAuthor { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
