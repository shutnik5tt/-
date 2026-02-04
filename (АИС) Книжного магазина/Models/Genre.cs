using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class Genre
    {
        public int IdGenre { get; set; }
        public string NameGenre { get; set; }
        public List<BookGenre> BookGenres { get; set; }
    }
}