using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220038
{
    internal class Polymorphism
    {
        public virtual void Talent()
        {
            Console.WriteLine("nama idol");
        }
    }

    class Moona : Polymorphism
    {
        public override void Talent()
        {
            Console.WriteLine("Moon Moon Moona dayo~~~");
        }
    }
    class Zeta : Polymorphism
    {
        public override void Talent()
        {
            Console.WriteLine("Mission: start!");
        }
    }
}
