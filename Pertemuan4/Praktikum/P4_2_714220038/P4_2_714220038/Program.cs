using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P4_2_714220038.FieldProperty;
using static P4_2_714220038.Inheritance;

namespace P4_2_714220038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance
            Console.WriteLine("inheritance");
            Apex b = new Apex();
            Console.WriteLine(b.Damage);
            Console.WriteLine(b.JenisAmunisi);
            b.chief_V();
            b.chief_V();

            //polymorphism
            Console.WriteLine("Polymorphism");
            Polymorphism c = new Moona();
            c.Talent();
            Polymorphism d = new Zeta();
            d.Talent();

            //FieldProperty
            HoloLiveID holoLiveID = new HoloLiveID();
            holoLiveID.NamaIdol = "Moona Hosinova";
            holoLiveID.tahundebut = 2020;
            Console.WriteLine("namaIdol : " + holoLiveID.NamaIdol);
            Console.WriteLine("TahunDebut : " + holoLiveID.tahundebut);

            //constructor
            Console.WriteLine("Constructor: ");
            Ceo ceo = new Ceo { nama = "Motoaki Tanigo", umur = 49 };
            Console.WriteLine(ceo.nama);
            Console.WriteLine(ceo.alias);
            Console.WriteLine(ceo.umur);



        }
    }
}
