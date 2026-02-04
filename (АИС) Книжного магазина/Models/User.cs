using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public int IdPosition { get; set; }
        public string LastnameUser { get; set; }
        public string NameUser { get; set; }
        public string? MiddlenameUser { get; set; }
        public string PhoneUser { get; set; }
        public Position Position { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
