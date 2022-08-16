using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        public string ati;
        public string familyasi;
        public int tuwilganjili;
        public string oqiworni;

        public void Manzil(string mamleket,string rayon,string koshe,int uynomer)
        {
            Console.WriteLine($"Eli {mamleket},rayoni {rayon},ko'shesi {koshe},Jasaytug'in u'yi {uynomer}");
        }
    }
}
