using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbungsaufgabe04_Hund
{
    internal class EntfesselterJagdhund : Jagdhund
    {
        protected string Blutdurst { get; set; }

        public EntfesselterJagdhund(string blutdurst, int geschwindigkeit, int groesse) : base(geschwindigkeit, groesse)
        {
            this.Blutdurst = blutdurst;
        }

        public override void Fass(string nameDesTiers)
        {
            Console.WriteLine($"Ich zerfleische {nameDesTiers} mit unbändiger Wut!");
        }

        public void Zerfetzen(int zeitdauer)
        { 
            Console.WriteLine($"Ich zerfetze das Tier {zeitdauer} Sekunden lang");
        }
    }
}
