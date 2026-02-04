using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class Transaction
    {
        public int IdTransaction { get; set; }
        public int? IdUser { get; set; }
        public string PaymentTypeTransaction { get; set; }
        public decimal AmountTransaction { get; set; }
        public string StatusTransaction { get; set; }
        public User? User { get; set; }
        public List<TransactionBookCopy> TransactionBookCopies { get; set; }
    }
}
