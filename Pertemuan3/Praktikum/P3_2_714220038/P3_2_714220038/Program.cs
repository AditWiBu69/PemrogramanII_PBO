using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220038
{
    internal class Program
    {
        static void Main(string[] args)
        {
int n;
            do
            {
                Console.WriteLine("Masukkan jumlah anak ayam (1-10): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 10);

            if (n == 1)
            {
                Console.WriteLine("Anak ayam sudah mati");
            }
            else
            {
                for (int i = n; i >= 2; i--)
                {
                    Console.WriteLine("Anak ayam turun" + i + " Mati satu Tinggallah "+ (i - 1));
                }
                Console.WriteLine("anak ayam turun 1, mati satu tinggal induknya");
            }
        }
    }
}
