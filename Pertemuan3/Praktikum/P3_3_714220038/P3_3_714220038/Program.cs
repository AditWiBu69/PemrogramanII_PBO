using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Persegi Panjang");
            Console.WriteLine("1. Menghitung Keliling");
            Console.WriteLine("2. Menghitung Luas");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            int choice;
            double panjang, lebar, keliling, luas;

            do
            {
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1://keliling
                        Console.Write("Enter panjang : ");
                        panjang = int.Parse(Console.ReadLine());
                        Console.Write("Enter lebar: ");
                        lebar = int.Parse(Console.ReadLine());
                        keliling = 2 * (panjang + lebar);
                        Console.WriteLine("Hasil Keliling : " + keliling);
                        break;

                    case 2://luas
                        Console.Write("Enter panjang : ");
                        panjang = int.Parse(Console.ReadLine());
                        Console.Write("Enter lebar: ");
                        lebar = int.Parse(Console.ReadLine());
                        luas = panjang * lebar;
                        Console.WriteLine("Hasil luas : " + luas);
                        break;
                    case 3:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 3);
        }
    }
}
