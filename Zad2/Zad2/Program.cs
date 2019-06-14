using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            Console.WriteLine("1.Podaj temperature w Kelwinach");
            Console.WriteLine("2.Zapisz temperature w Kelwinach");
            Console.WriteLine("3.Podaj obecna temperature w Celcjusza");
            Console.WriteLine("4.Zapisz temperature Celcjusza w Kelwinach");
            Console.WriteLine("5.Podaj obecna temperature w Fahrenheitach");
            Console.WriteLine("6.Zapisz temperature Fahrenheita w Kelwinach");
            ConsoleKeyInfo k = new ConsoleKeyInfo();
            k = Console.ReadKey();
            double kel;
            do
            {
                switch (k.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nObecna temperatura wyrazona w Kelwinach rowna sie:" + temp.Getkelwintemp());
                        Console.WriteLine("Wybierz inna opcje");
                        k = Console.ReadKey();
                        continue;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nPodaj temperature w Kelwinach");
                        kel = double.Parse(Console.ReadLine());
                        temp.Setkelwintemp(kel);
                        Console.WriteLine("Obecna temperatura wyrazona w Kelwinach rowna sie:" + temp.Getkelwintemp());
                        Console.WriteLine("Wybierz inna opcje");
                        k = Console.ReadKey();
                        continue;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nObecna temperatura wyrazona w Kelwinach rowna sie:" + temp.Getkelwintemp());
                        Console.WriteLine("Obecna temperatura wyrazona w Celcjuszach rowna sie:" + temp.GetCeltemp());
                        Console.WriteLine("Wybierz inna opcje");
                        k = Console.ReadKey();
                        continue;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nPodaj temperature w Cel: ");
                        kel = double.Parse(Console.ReadLine());
                        temp.Setkelfromcel(kel);
                        Console.WriteLine("Temperatura w Kelwinach: " + temp.Getkelwintemp());
                        Console.WriteLine("Wybierz inna opcje");
                        k = Console.ReadKey();
                        continue;
                    case ConsoleKey.D5:
                        Console.WriteLine("\ntemperatura w Kelwinach: " + temp.Getkelwintemp());
                        Console.WriteLine("Temperatura w Fahrenheitach: " + temp.Getfartemp());
                        Console.WriteLine("Wybierz inna opcje");
                        k = Console.ReadKey();
                        continue;
                    case ConsoleKey.D6:
                        Console.WriteLine("\nPodaj temperature w Fahrenheitach: ");
                        kel = double.Parse(Console.ReadLine());
                        temp.Setkelfromfar(kel);
                        Console.WriteLine("Temperatura w Kelwinach: " + temp.Getkelwintemp());
                        Console.WriteLine("Wybierz inna opcje");
                        k = Console.ReadKey();
                        continue;
                }
            } while (k.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
