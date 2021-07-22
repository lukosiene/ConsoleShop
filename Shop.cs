using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    class Shop
    {
        private Book _book;
        private Candy _candy;
        private Cup _cup;

       public Shop()
        {
            _book = new Book(100, 12.5);
            _candy = new Candy(100, 3.0);
            _cup = new Cup(100, 4.5);
        }
            

        public void Buy(int choiceOfGood)
        {
            switch (choiceOfGood)
            {
                case 1:
                    Console.Write("Enter how many books do you want to buy: ");

                    var amountOfBooks = Convert.ToInt32(Console.ReadLine());

                    _book.DecreaseAmount(amountOfBooks);

                    break;
                case 2:
                    Console.Write("Enter how many kg candies do you want to buy: ");

                    var amountOfCandies = Convert.ToInt32(Console.ReadLine());

                    _candy.DecreaseAmount(amountOfCandies);

                    break;
                case 3:
                    Console.Write("Enter how many cups do you want to buy: ");

                    var amountOfCups = Convert.ToInt32(Console.ReadLine());

                    _cup.DecreaseAmount(amountOfCups);

                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }
        public void Add(int choiceOfGood)
        {
            switch (choiceOfGood)
            {
                case 1:
                    Console.Write("Enter how many books do you want to add: ");

                    var amountOfBooks = Convert.ToInt32(Console.ReadLine());

                    _book.IncreaseAmount(amountOfBooks);

                    break;
                case 2:
                    Console.Write("Enter how many kg candies do you want to add: ");

                    var amountOfCandies = Convert.ToInt32(Console.ReadLine());

                    _candy.IncreaseAmount(amountOfCandies);

                    break;
                case 3:
                    Console.Write("Enter how many cups do you want to add: ");

                    var amountOfCups = Convert.ToInt32(Console.ReadLine());

                    _cup.IncreaseAmount(amountOfCups);

                    break;
                default:
                    Console.WriteLine("There is no such choice");
                    break;
            }
        }

        internal void ShowList()
        {
            Console.WriteLine("\n List of available goods:");
            Console.WriteLine(_book.ToString());
            Console.WriteLine(_candy.ToString());
            Console.WriteLine(_cup.ToString());
        }
    }
}
