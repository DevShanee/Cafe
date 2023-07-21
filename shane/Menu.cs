using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shane
{
    public class Menu
    {
        public List<string> menu;
        public List<int> price;
        public Menu()
        {
            menu = new List<string>() { "Chocolate Crinkle and French ", "White Raspberry Crinkle and Spanish Latte", "Strawberry Cream and Iced Americano", "Bavarian and Iced Latte ", "Tiramisu and Caramel Macchiato" };
            price = new List<int>() { 210, 235, 250, 245, 240 };
        }
        public void menuCaffe()
        {
            Console.WriteLine("             Welcome to Desired Cookie and Cafe");
            Console.WriteLine("************************ MENU ************************");
            Console.WriteLine("                                             Price: ");
            Console.WriteLine(menu[0] +"                 "+ price[0]);
            Console.WriteLine(menu[1] +"     "+ price[1]);
            Console.WriteLine(menu[2] + "           " + price[2]);
            Console.WriteLine(menu[3] + "                      " + price[3]);
            Console.WriteLine(menu[4] + "                " + price[4]);
        }
    }
}
