using System;

namespace SklepyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Sklep zoologiczny = new SklepZoologiczny("ZooMarket", 2010, "1234567890");
            Sklep budowlany = new SklepBudowlany("BudMax", 2005, "0987654321");

            Console.WriteLine(zoologiczny.Powitanie());
            Console.WriteLine(zoologiczny.Info());
            Console.WriteLine(zoologiczny.MetodaPlatnosci());

            Console.WriteLine();

            Console.WriteLine(budowlany.Powitanie());
            Console.WriteLine(budowlany.Info());
            Console.WriteLine(budowlany.MetodaPlatnosci());
        }
    }
}