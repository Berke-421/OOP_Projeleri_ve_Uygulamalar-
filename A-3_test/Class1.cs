using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_3_test
{
    class Class1
    {
        static void Main(string[] args)
        {
            Deneme a = new Deneme();

            Console.WriteLine(a.deneme);

            Console.WriteLine(a.sayi1);
            int b = a.sayi1;
            a.sayi1 = 32;
           
        }
    }

    class Deneme 
    {
        private int sayi;

        public int sayi1 { get; }
    }
}
