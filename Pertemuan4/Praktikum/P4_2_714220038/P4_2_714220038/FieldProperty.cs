using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220038
{
    internal class FieldProperty
    {
        public class HoloLiveID
        {
            private string namaIdol;
            private int tahunDebut;

            public string NamaIdol
            {
                get
                {
                    return namaIdol;
                }
                set
                {
                    namaIdol = value;
                }
            }

                public int tahundebut
                {
                get
                {
                    return tahunDebut;
                }
                set
                {
                    tahunDebut = value;
                }
            }
            }
        }
    }
