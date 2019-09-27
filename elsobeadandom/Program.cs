using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsobeadandom
{
    class Program
    {
        static void Main(string[] args)
        {
            var szamok = new List<int>();
            Console.WriteLine("Most adj meg 10 számot kérlek: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kérlek add meg a(z) {0}. számot ", i +1);
                szamok.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int max = szamok.Max();
            Console.WriteLine("A legnagyobb szám: " + max);


            Console.ReadKey();
        }
    }
}
