using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    class Cup : Product
    {
        public Cup(int amount, double price) : base(amount, price)
        {
            _goodType = GoodType.Cup;
        }
        // veliau papildyti spalva. Pagalvoti ar labai apsisunkintu papildomu opciju pridejimas? Kaip palengvinti?        
    }
}
