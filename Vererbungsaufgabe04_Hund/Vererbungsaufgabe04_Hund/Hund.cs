using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbungsaufgabe04_Hund
{
    internal abstract class Hund
    {
        public int Groesse { get; set; }

        public Hund(int groesse)
        {
            this.Groesse = groesse;
        }

        public void Bellen()
        {
            Console.WriteLine("Wuff Wuff");
        }

        public int GetGroesse()
        {
            Console.WriteLine($"Der Hund ist {Groesse} cm gross");
            return Groesse;
        }
    }
}
