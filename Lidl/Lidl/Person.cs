using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }

        public void Esse()
        {
            Console.WriteLine("Ich bin Person {0} {1} und ich esse gerne.", Vorname, Name);
        }
    }
}
