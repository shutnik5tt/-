using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AIS_Bookstore.Models;

namespace _АИС__Книжного_магазина.Models
{
    public class BookGenre
    {
        public int IdBookGenre { get; set; }
        public int IdBook { get; set; }
        public int IdGenre { get; set; }
        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
