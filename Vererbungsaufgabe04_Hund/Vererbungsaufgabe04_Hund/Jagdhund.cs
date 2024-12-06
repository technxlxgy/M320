using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbungsaufgabe04_Hund
{
    internal class Jagdhund : Hund
    {
        protected int Geschwindigkeit { get; set; }
        public Jagdhund(int geschwindigkeit, int groesse) : base(groesse)
        {
            this.Geschwindigkeit = geschwindigkeit;
        }

        public int GetGeschwindigkeit()
        {
            Console.WriteLine($"Der Jagdhund ist {Geschwindigkeit}km/h schnell.");
            return Geschwindigkeit;
        }

        public virtual void Fass(string nameDesTiers)
        {
            Console.WriteLine($"Ich habe {nameDesTiers} gefasst");
        }
    }
}
