using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    class Candy : Product
    {
        public Candy(int amount, double price) : base(amount, price)
        {
            _goodType = GoodType.Candy;
        }
        // Galima papildyti pavadinimu. sukurti papildoma lista skirtingu rusiu ir ju kiekiu atvaizdavimui.  
    }
}
