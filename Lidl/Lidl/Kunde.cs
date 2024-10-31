using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Kunde : Person
    {
        private double Umsatz {  get; set; }

        public void KaufeEin()
        {
            Console.WriteLine("Ich kaufe ein als Kunde {0} {1}.", Vorname, Name);
        } 
    }
}
