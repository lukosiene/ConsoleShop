using System;

namespace ConsoleShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ConsoleShop!\n" +
                "-*-*-*-*-*-*-*-*-*-*-*-");

            var mainShop = new Shop();
            
            var work = true;

            while (work)
            {
                Console.WriteLine("\nPlease choose what do you want to do:\n" +
                    "1. To see list of available goods;\n" +
                    "2. To buy something;\n" +
                    "3. To add more goods;\n" +
                    "4. To exit the shop.");
                Console.Write("Enter number of your choice:"); // Jei noreciau panaudoti ShowMainMenu. Ar verta? 

                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        mainShop.ShowList();
                        break;
                    case 2:
                        var buying = true;
                        while (buying)
                        {
                            Console.WriteLine("\nChoose what do you want to buy:\n" +
                                "1. Book;\n" +
                                "2. Candies;\n" +
                                "3. Cup.");
                            Console.Write("Enter number of your choice:"); // sitoj vietoj priristi enum butu patogu. kolkas paprastai

                            var choiceOfGood = Convert.ToInt32(Console.ReadLine());

                            mainShop.Buy(choiceOfGood);

                            Console.Write("\nDo you want to go back to main menu?(y/n): ");
                            var answerBuy = Console.ReadLine();
                            buying = answerBuy == "n"; // ivedus bet koki kitoki zenkla grizta i mainmenu. Apriboti?
                        }
                        break;
                    case 3:
                        var adding = true;
                        while (adding)
                        {
                            Console.WriteLine("\nChoose what do you want to add:\n" +
                                              "1. Book;\n" +
                                              "2. Candies;\n" +
                                              "3. Cup.");
                            Console.Write("Enter number of your choice: ");

                            var choiceOfGood = Convert.ToInt32(Console.ReadLine());

                            mainShop.Add(choiceOfGood);

                            Console.Write("Do you want to go back to main menu?(y/n): ");
                            var answerAdd = Console.ReadLine();
                            adding = answerAdd == "n";
                        } 
                        break;
                    case 4:
                        Console.WriteLine("Good Buy!");
                        work = false;
                        break;
                }
            }

            void ShowMainMenu() // Kaip pataisyti, kad galeciau issikviesti cikle
            {
                Console.WriteLine("Please choose what do you want to do:\n " +
                    "1. To see list of available goods;\n" + // priri6ti enum reiksmes?
                    "2. To buy something;\n" +
                    "3. To add more goods;\n" +
                    "4. To exit the shop.");
                Console.Write("Enter number of your choice:");
            }
        }

       
    }
}
