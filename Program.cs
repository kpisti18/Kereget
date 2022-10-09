using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kereget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int a = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();

            while (a != 0)
            {
                szamok.Add(a);
                Console.Write("Kérek egy számot: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A számok:");
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
