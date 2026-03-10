using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace B_1_ÇALIŞMA_PROGRAMI
{
    class Class1
    {
        internal static void Main(string[] args)
        {
            // Kalk 07.30

            /* Not:
             
             * Günlük çalışma programı aşağıdaki gibidir. Bu program esnek ve kişiye özel hazırlanmıştır. Kendi ihtiyaçlarınıza göre uyarlayabilirsiniz.
             * nesne yönelimli planlama ile hem esnek hem de modüler bir yapı oluşturulmuştur. Yratıcısı Berke Biçer'dir.
             * Hayalindeki kariyere ulaşmak için disiplinli ve düzenli bir çalışma programı şarttır. Bu programı uygularken kararlılığını ve motivasyonunu yüksek tutmalısın.
             * Hedefindeki indie oyunu geliştir kesinlikle.
             * Atatürk'ün izinden git ve onun gibi çalış.
             * hayalindeki oyunu geliştirmek için her gün düzenli olarak çalış. çünkü ulusal bir görev bu.
             * ulusal bir görevde olduğunu unutma.
             * 'Pınar' oyununu geliştir ve dünyaya tanıt.
             * Her gün piyano çalışması yapmayı unutma. Müzik ruhun gıdasıdır. 'Pinar' oyununda müzik çok önemli.
             * sabah bölümü C# ve WEB çalışmaları olup boş vakitlerde mümkünce ingilizce çalışılsın 
             * mutlaka teknoloji kitap okumunu aksatma günde en az 1 adet
             * molaları sakın küçümseme yorgun olduğun yerde sakın ağır çalışmaya başlama dinlen ve enerji topla. Molaları stratejik kullanmalısın
             
             */

            /* Her gün mutlaka yapılması gerekiyor (ingilizce pratikler):
             
             * ingilizce defter çalışması
             * ingilizce yapay zeka sohbet (2 defa)
             * ingilizce kelime çalışması
             * ingilizce dinlemek
             * ingilizce okumak
             * ingilizce yazışmak
             * ama en önemlisi ingilizce konuşmak
                
             */

            /* Mevcut pratikler:
             
             * Hikaye pratiği
             * oyun fikri pratiği
             
             */

            // Sabah 07.30 - 11.40


            // burası çok önemli ingilizce pratik zamanı burada ingilizce pratikleri yap. az da olsa faydası olur
            // akşam yemeği bu zaman diliminde yenir ona göre planla
            // atomik alışkanlık oluşturma tekniğini kullanarak ingilizce pratiklerini yap
            // her gün her birinden sadece 5 dakika yap yeterli olur. sadece düzenli ol çünkü beyin alışkanlıkları sever
            // bu pratikler ingilizce konuşma, dinleme, yazma, okuma
            // her gün 5 dakika yaparsan beyninde yeni sinir bağlantıları oluşur ve zamanla ingilizce becerin artar
            // ve kendiliğinden 5 dakika 10 dakikaya çıkar zamanla daha da artar




            /* ===> */  Kitap.Roman_Oku();  /* <=== */
            /* ===> */  Piyano.tekrar_yap(20);  /* <=== */

            İngilizce.kelime(10);

            /* ===> */  İngilizce.dinleme(5);  /* <=== */
            /* ===> */  İngilizce.konuş(5);  /* <=== */
            
            /* ===> */  İngilizce.okuma(5);  /* <=== */

             /* ===> */ Unity.blender_calis(14);  /* <=== */

            // ------------------------------------------------------------------


            // Öğlen 11.40 - 15.40

            // 12.00 - 12.40 A
            Unity.blender_calis(20);


            // 13.00 - 13.40 A
            Unity.blender_calis(40);

            // 14.00 - 14.40 A
            Unity.Çalış(40);


            Kitap.Teknoloji_Kitabı_Oku();

            Kariyer.Planla();

            Piyano.tekrar_yap(30);

            // ------------------------------------------------------------------


            // İkindi 15.40 - 19.30


            // 16.00 - 16.40 B
            Unity.Çalış(40);

            // 17.00 - 17.40 B
            Unity.Çalış(40);


            // 18.00 - 18.40 B
            Unity.Çalış(40);

            Unity.tekrar_yap(20);
            C.tekrar_yap(20);

            Kitap.Teknoloji_Kitabı_Oku();

            Piyano.tekrar_yap();

            // ------------------------------------------------------------------


            // Akşam 19.30 - 21.00

            Piyano.tekrar_yap(20);
            İngilizce.kelime_tekrar(15);

            // kalıplar, tekrarlar ve pratikler

            /* ===> */  İngilizce.yazma();  /* <=== */
            /* ===> */  İngilizce.konuş();  /* <=== */

            // ------------------------------------------------------------------



            // Yatsı 21.00 - 23.30

            // son işemler ve dinlenme. Eğer kod okuma veya yazma yapacaksan bu zaman diliminde yapabilirsin

            /* ===> */  Kitap.Roman_Oku();  /* <=== */

            // ------------------------------------------------------------------

            // Yat 23.30 (MUTLAK KESİNLİK) kesinillikle bu saatte yat yoksa ertesi gün çok zorlanırsın
        }
    }

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

    class Ders
    {

    }

    class C : Ders
    {
        // unity için gerekli
        // temel seviye
        public static void Çalış(short miktar = 10 )
        {
            // her gün 1 saat veya daha fazla çalış
        }

        public static void Pratik_Yap(short miktar = 10)
        {
            // her gün 1 saat veya daha fazla pratik yap
        }

        public static void tekrar_yap(short miktar = 10)
        {
            // her akşam mutlaka tekrar yap
        }

        public static void kod_inceleme(short miktar = 10)
        {
            // mümkünse inceleme yap
        }
    }

    class Unity : Ders
    {
        public static void Çalış(short miktar = 10) { } // unity çalış çünkü oyun motoru bu
        public static void proje_calis(short miktar = 10) { } 
        public static void tekrar_yap(short miktar = 10) { }
        public static void kod_inceleme(short miktar = 10) { }

        public static void blender_calis(short miktar = 10) { } // blender çalış çünkü 3d modelleme burada
        public static void audacity_calis(short miktar = 10) { } // audacity çalış çünkü ses düzenleme burada
        public static void krita_calis(short miktar = 10) { } // krita çalış çünkü 2d modelleme burada
    }

    class WEB : Ders
    {
        public static void proje_calis(short miktar = 10) { } // proje çalış çünkü en önemlisi bu çünkü gelişim burada

        public static void html_calıs(short miktar = 10) { }

        public static void css_calıs(short miktar = 10) { }
        public static void js_calıs(short miktar = 10) { }
        public static void js_tekrar(short miktar = 10) { }

        public static void kod_inceleme(short miktar = 10) { }
    }

    class Python : Ders
    {
        public static void Çalış(short miktar = 10) { } // burada
        public static void proje_calis(short miktar = 10) { }
        public static void tekrar_yap(short miktar = 10) { }
        public static void kod_inceleme(short miktar = 10) { }
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    class İngilizce 
    {
        public static void konuş(short a = 10) { }

        public static void dinleme(short a = 10) { } 

        public static void yazma(short a = 10) { }

        public static void okuma(short a = 10) { }  
        public static void kelime(short a = 10) { }
        public static void kelime_tekrar(short a = 10) { }

        public static void kalıp(short a = 10) { }
        
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------

    class Kitap
    {
        public static void Roman_Oku(short a = 10) { }
        public static void Teknoloji_Kitabı_Oku(short a = 10) { }
        public static void Hikaye_Yaz(short a = 10) { }
        public static void Oyun_Tarzı_Üret(short a = 10) { }
    }

    class Piyano
    {
        public static void Çalış(short a = 10) { }
        public static void tekrar_yap(short a = 10) { }
    }

    class Kariyer
    {
        public static void Planla(short a = 10) { }
        public static void Hedef_Üret(short a = 10) { }
    }

    class Spor
    {
        public static void sporyap(short a = 10) { }
    }
}

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------
