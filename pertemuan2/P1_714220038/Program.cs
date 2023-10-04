using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_714220038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double penjumlahan;
            double pengurangan;
            double perkalian;
            double pembagian;

            Console.WriteLine("masukan angka pertama :");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("masukan angka kedua :");
            b = double.Parse(Console.ReadLine());

            penjumlahan = a + b;
            Console.WriteLine("hasil penjumlahan {0} + {1} = {2} ", a, b, penjumlahan);

            pengurangan = a - b;
            Console.WriteLine("hasil pengurangan  {0} + {1} = {2} ", a, b, pengurangan);

            perkalian = a * b;
            Console.WriteLine("hasil perkalian {0} + {1} = {2} ", a, b, perkalian);

            pembagian = a / b;
            Console.WriteLine("hasil pembagian {0} + {1} = {2} ", a, b, pembagian);
        }
    }
}
