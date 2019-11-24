using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. dodaj liczby");
            Console.WriteLine("2. odejmij liczby");
            Console.WriteLine("3. pomnoz liczby");
            Console.WriteLine("4. dziel liczby");
            Console.WriteLine("5. wyjście");
            int menuOption = Convert.ToInt32(Console.ReadLine());
        }
    }
}
