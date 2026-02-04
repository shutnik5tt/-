using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class TransactionBookCopy
    {
        public int IdTransactionBookCopy { get; set; }
        public int IdTransaction { get; set; }
        public int IdBookCopy { get; set; }
        public Transaction Transaction { get; set; }
        public BookCopy BookCopy { get; set; }
    }
}
