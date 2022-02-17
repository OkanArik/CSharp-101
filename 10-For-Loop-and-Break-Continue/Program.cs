
//template:şablon
using System;

    namespace For_Loop_Break_Coninue
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //***for loop:
                //Örnek:Console'dan girilen sayı için girilen sayıya kadar olan tek sayıları Console'a yazdır.
                Console.Write("Lütfen girdiğiniz sayıya kadar olan tek sayıları Console'da görmek istediğiniz sayıyı giriniz:");
                if(int.TryParse(Console.ReadLine(),out int counter))
                for (int i = 1; i <= counter; i++)
                {
                    if(i%2==1)
                      Console.WriteLine(i);
                }
                
                //Not: Console.ReadLine ekrandan string okur.Bu konu önemlidir.

                Console.WriteLine("1 ile 1000 arasındaki tek ve çift sayıların toplamını Console'a yazdır.");
                int tekToplam=0;
                for (int i = 1; i <=999; i+=2)
                {
                    tekToplam+=i;
                }
                int cifttoplam=0;
                for (int i = 2; i <=1000; i+=2)
                {
                    cifttoplam+=i;
                }
                Console.WriteLine("1 ile 1000 arasındaki tek sayıların toplamı:{0}",tekToplam);
                Console.WriteLine("1 ile 1000 arasındaki çift sayıların toplamı:{0}",cifttoplam);
                
                //***Break and Continue:
                //Döngülerle birlikte kullanılabilecek iki tane keyword(anahtar kelime) var bunlar break ve continue keyword'leridir.
                //Break keyword'ü: Eğer bir loop içerisinde bir case'e bağlı olarak loop'tan çıkmak istiyorsak yani döngüyü sonlandrımak istiyorsak break keyword'ünü kullanırız.Break sadece current loop'u yani içinde olduğu loop'u sonlandırır.
                //Continue keyword'ü:Eğer bir loop içerisinde bir case'e bağlı olarak mevcut döngünün o cycle'ını atlamak istiyorsak continue keyword'ünü kullanırız.
                int toplam=0;
                for (int i = 1; i < 10; i++)
                {   
                    if (i==4)
                    break;
                    Console.WriteLine(i);     
                    toplam+=i;
                    
                }
                Console.WriteLine("Toplam:{0}",toplam);//Output: 6

                int toplamOrnek=0;
                for (int i =1; i <5; i++)
                {
                    if(i==2)
                    continue;
                    Console.WriteLine(i);
                    toplamOrnek+=i;
                }
                Console.WriteLine("Toplam:{0}",toplamOrnek);//Output: 8

                //for(;;): bu bir sonsuz döngüdür , bu aslında tehlikelidir.Biz sonsuz döngülerden uzak duruyoruz.
                //Infinite Loop:Sounsuz Döngü
            }
        }
    }
//****************************************************************
   //Loops(dögüler):C Sharp'ta birden fazla döngü çeşiti vardır.Bunlar ForLoop , While ve ForEach döngüleridir.Döngüleri belli bir kod bloğunun belli şartlar altında yani belli şartlara bağlı kalarak birden fazla defa çalışmasını istiyorsak döngüleri kullanırız.
   //curly braces:kıvırcık parantez:{I' writing this in curly braces}
//****************************************************************
   //For Döngüsü ve Break Continue Anahtar Kelimeleri:
   // Örnek bir for döngüsü 2 ifade, 1 koşuldan oluşur.
   
   // for(ifade1;kosul;ifade2)
   // {
   //     komut1;
   //     komut2;
   // }
   // ifade1: Döngünün sayacının tanımlandığı ve atamasının yapıldığı ifadedir. Örneğin; int i=0;

   // ifade2: Döngünün sayacının artırım yada azaltım şeklini belirten ifadedir. Örneğin ; i++, i-- gibi.

   // koşul: döngünün devam etme koşuludur. Bu koşul sağlandığı sürece döngü devam eder. Örneğin : i<=12;

   // ÖNEMLİ: For döngüsünü oluşturan bu 2 ifade 1 koşulun bir kısmı ya da tamamı boş bırakılabilir. Ama aralardaki ";" işareti mutlaka kullanılmalıdır.

   // for(;;) // Sonsuz döngüyü ifade eder. 
   // Break Anahtar Kelimesi
   // Break ifadesi döngü içerisinden çıkmak istenildiğinde kullanılır.

   // for (int i; ;)// Sonsuz döngü
   // {
   //     a = Convert.ToChar(Console.ReadLine());
   //     if (i == 7)
   //         break;
   // }
   // //Kod burdan devam eder. 
   // Yukarıdaki örnekte console'dan girilen değer 7' ye eşit ise döngü sonlandırılır.

   // Not: İç içe döngüler kullanıldığında break ifadesi yalnızca içinde bulunduğu ilk döngüyü sonlandırır.

   // Continue Anahtar Kelimesi
   // Kullanım amacı break ifadesine benzer ama continue sadece mevcut iterasyonu sonlandırır. Döngü bir sonraki iterasyondan devam eder.

   // for (int i = 1; i <= 10; i++)
   // {
   //     if (i % 2 == 0)
   //         continue;
   //     Console.WriteLine(i);
   // }
   // Yukarıdaki örnekte i çift sayıya eşit olduğunda döngünün o anki iterasyon sonlanacaktır. Bu durumda console'a 1 ile 10 arasındaki tek sayılar yazdırılacaktır.