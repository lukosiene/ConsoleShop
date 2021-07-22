using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    class Book : Product
    {
        private string _title;

        public Book(string title, int amount, double price) : base(amount, price)
        {
            _title = title;
            _price = 11.4;
        }

        public Book(int amount, double price) : base(amount, price) // Kolkas, kad butu paprasciau
        {
            _goodType = GoodType.Book;
        }        
    }
}
