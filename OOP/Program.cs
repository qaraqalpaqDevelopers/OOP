using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {      Student STD = new Student(); 
               STD.ati = "Jorabek";
               STD.familyasi = "Turg'anbaev";
               STD.tuwilganjili = 2003;
               STD.oqiworni = "QMU";
               Console.WriteLine($"Student ati: {STD.ati}\nFamilyasi: {STD.familyasi}\nTuwilg'an jili: {STD.tuwilganjili}\nOqiw orni: {STD.oqiworni}");
            Console.WriteLine("\n");
            
            Console.ReadKey();
        }
    }
}
