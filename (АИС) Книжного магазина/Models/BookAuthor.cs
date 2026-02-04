using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AIS_Bookstore.Models;

namespace _АИС__Книжного_магазина.Models
{
    public class BookAuthor
    {
        public int IdBookAuthor { get; set; }
        public int IdBook { get; set; }
        public int IdAuthor { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
