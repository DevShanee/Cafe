namespace shane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool orderingSystem = true;

            while (orderingSystem)
            {
                Menu menu = new Menu();
                menu.menuCaffe();
                Console.Write("Select your Order: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {

                    var oneInput = new List<string>()
                    { "\n************************************",
                        "Chocolate Crinkle and French Vanilla",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    chocoCrinklesBill();
                }
                else if (userInput == 2)
                {
                    var oneInput = new List<string>()
                    { "\n************************************",
                        "White Raspberry Crinkle and Spanish Latte",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    raspberryLatteBill();


                }

                else if (userInput == 3)
                {
                    var oneInput = new List<string>()
                    { "\n************************************",
                        "Strawberry Cream Crinkle and Iced Americano",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    strawberryCreamIcedAmericanoBill();
                }
                else if (userInput == 4)
                {
                    var oneInput = new List<string>()
                    { "\n************************************",
                        "Bavarian Crinkle and Iced Latte",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    barvarianIcedteabBill();
                }
                else if (userInput == 5)
                {
                    var oneInput = new List<string>()
                    { "\n************************************",
                        "Tiramisu and Caramel Macchiato",
                        "***********************************"};
                    foreach (string i in oneInput)
                    {
                        Console.WriteLine(i);
                    }
                    tiramisuMacchiatoBill();

                }



            }



            static void chocoCrinklesBill()
            {

                Console.Write("Type the quantity of your order: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                int total = quantity * 210;
                Console.WriteLine();
                Console.WriteLine("Your total amount is Php " + total + ".00");
                Console.WriteLine();

            }
            static void raspberryLatteBill()
            {

                Console.Write("Type the quantity of your order: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                int total = quantity * 235;
                Console.WriteLine();
                Console.WriteLine("Your total amount is Php " + total + ".00");
                Console.WriteLine();

            }
            static void strawberryCreamIcedAmericanoBill()
            {

                Console.Write("Type the quantity of your order: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                int total = quantity * 250;
                Console.WriteLine();
                Console.WriteLine("Your total amount is Php " + total + ".00");
                Console.WriteLine();

            }
            static void barvarianIcedteabBill()
            {

                Console.Write("Type the quantity of your order: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                int total = quantity * 245;
                Console.WriteLine();
                Console.WriteLine("Your total amount is Php " + total + ".00");
                Console.WriteLine();

            }

            static void tiramisuMacchiatoBill()
            {

                Console.Write("Type the quantity of your order: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                int total = quantity * 240;
                Console.WriteLine();
                Console.WriteLine("Your total amount is Php " + total + ".00");
                Console.WriteLine();

            }

        }
    }
}