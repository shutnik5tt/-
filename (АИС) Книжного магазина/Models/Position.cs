using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class Position
    {
        public int IdPosition { get; set; }
        public string NamePosition { get; set; }
        public List<User> Users { get; set; }
    }
}
