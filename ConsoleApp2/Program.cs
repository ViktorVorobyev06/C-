using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Viktor Vorobyev");

            Console.Write("Введите а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите в: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Результат с = {0}", c);
           
        }
    }
}
