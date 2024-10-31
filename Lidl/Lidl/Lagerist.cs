using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Lagerist : Person
    {
        public int Groesse { get; set; }

        public void LagerEin()
        {
            Console.WriteLine("Ich bin Lagerist {0} {1} und lager ein.", Vorname, Name);
        }
    }
}
