using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220038
    {
        public class Ceo 
        {
            public string nama;
            public string alias;
            public int umur;
            public Ceo()
            {
                this.nama = "Motoaki Tanigo";
                this.alias = "Yagoo";
                this.umur = 49;
            }
            public Ceo(string nama, string alias, int umur)
            {
                this.nama = nama;
                this.alias = alias;
                this.umur = umur;
            }
        }
}
