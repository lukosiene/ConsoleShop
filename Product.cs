using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    abstract class Product
    {
        protected GoodType _goodType;
        protected int _amount;
        protected double _price;
        
        protected Product(int amount, double price)
        {
            _amount = amount;
            _price = price;
        }
        
        public void DecreaseAmount(int amount) // Tikrai reiketu implementuoti iskart produktuose, nes minimaliai skiriasi
        {

            if ((_amount - amount) >= 0)
            {
                _amount = _amount - amount;
                Console.WriteLine($"You have purchased {amount} of {_goodType} successfully.\n");
            }
            else
            {
                Console.WriteLine($"We are sorry, there is only {_amount} left.\n");
            }

        }

        public void IncreaseAmount(int amount)
        {
            _amount = _amount + amount;
            Console.WriteLine($"You have added {amount} successfully.\n");
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Price: {1}, Amount: {2}", _goodType, _price, _amount);
        }
    }
}
