using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AIS_Bookstore.Models;

namespace _АИС__Книжного_магазина.Models
{
    public class BookCopy
    {
        public int IdBookCopy { get; set; }
        public int IdBook { get; set; }
        public int IdStore { get; set; }
        public string StatusBookCopy { get; set; }
        public Book Book { get; set; }
        public Store Store { get; set; }
        public List<TransactionBookCopy> TransactionBookCopies { get; set; }
    }
}
