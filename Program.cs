using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Bookstore";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Menu("Show buy history", "Show all books", "Buy a book", "Sell a book");
        }
        public static void Menu(string text1, string text2, string text3, string text4)
        {
            bool runMenu = true;
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║ Wellcome to the bookstore ║");
                Console.WriteLine("╠═══════════════════════════╣");
                Console.WriteLine("╟─                         ─╢");
                Console.WriteLine("╟─                         ─╢");
                Console.WriteLine("╟─                         ─╢");
                Console.WriteLine("╟─                         ─╢");
                Console.WriteLine("╟─  (X): Exit               ║");
                Console.WriteLine("╚═══════════════════════════╝");
                Console.SetCursorPosition(4, 3);
                Console.Write("(1): " + text1);
                Console.SetCursorPosition(4, 4);
                Console.Write("(2): " + text2);
                Console.SetCursorPosition(4, 5);
                Console.Write("(3): " + text3);
                Console.SetCursorPosition(4, 6);
                Console.Write("(4): " + text4);
                Console.SetCursorPosition(28, 7);

                string key1 = Console.ReadKey().Key.ToString();
                switch (key1)
                {
                    case "D1":
                        break;
                    case "D2":
                        break;
                    case "D3":
                        break;
                    case "D4":
                        break;
                    case "X":
                        runMenu = false;
                        break;
                    default:
                        break;
                }
            } while (runMenu);
        }
    }
}
