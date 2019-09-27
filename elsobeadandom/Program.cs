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
            Console.WriteLine("Add meg hány számot kérjek be: ");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < e; i++)
            {
                try
                {
                    Console.WriteLine("Kérlek add meg a(z) {0}. számot ", i + 1);
                    szamok.Add(Convert.ToInt32(Console.ReadLine()));
                }catch
                {
                    Console.WriteLine("Nem jó számot adtál meg, próbáld újra");
                    i--;
                }
                
            }
            int max = szamok.Max();
            int min = szamok.Min();
            Console.WriteLine("A legnagyobb szám: {0}, legkissebb pedig: {1}", max , min);


            Console.ReadKey();
        }
    }
}
