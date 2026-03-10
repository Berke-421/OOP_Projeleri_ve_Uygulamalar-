using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projeleri_ve_Uygulamaları
{
    class Class1
    {
        static void Main()
        {
            Sınıf berke = new Sınıf();
            berke.isim = "adnan";
            berke.yas = 18;
            berke.kendinitanıt();

            Sınıf bicer = new Sınıf();
            bicer.isim = "ayşe";
            bicer.yas = 17;
            bicer.kendinitanıt();

            Sınıf nesne = new Sınıf();
            nesne.isim = "Gökçe";
            nesne.yas = 16;
            nesne.kendinitanıt();
        }
    }

    class Sınıf
    {
        public string? isim;
        public int yas;

        public void kendinitanıt()
        {
            Console.WriteLine($"merhaba benim adım {isim}, {yas} yaşındayım");
        }
    }
}
