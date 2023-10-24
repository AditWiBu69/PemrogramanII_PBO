using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220038
{
    internal class Inheritance
    {
        public class Apex
        {
            public int Damage { get; set; }
            public string JenisAmunisi { get; set; }

            public void chief_V()
            {
                Console.WriteLine("YO YO YO THIS CHIEF SPEAKING HERE MY NAME LUTFI HALIMAWAN AND WELKAM TO MY CHANEL");
                {

                }
            }
            class ChargeRifle : Apex
            {
                public ChargeRifle()
                {
                    Damage = 50;
                    JenisAmunisi = "SniperAmmo";
                }
                public void target()
                {
                    Console.WriteLine("hit");
                }
            }
        }
    }
}
