using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _АИС__Книжного_магазина.Models
{
    public class Store
    {
        public int IdStore { get; set; }
        public string CityStore { get; set; }
        public string StreetStore { get; set; }
        public string HouseStore { get; set; }
        public string PhoneStore { get; set; }
        public List<BookCopy> BookCopies { get; set; }
    }
}
