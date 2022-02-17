//Soru 2:Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

using System;

  
   namespace Koleksiyonlar_Soru_2
   {
       class Program
       {
           static void Main(string[] args)
           {
            int[] sayiDizisi = new int[20];
            Console.WriteLine("20 adet sayı giriniz:");
                 for (int i=1 ; i<=20 ; i++)
                 {
                      try
                      {
                          Console.Write("{0}. sayıyı giriniz:",i);
                          sayiDizisi[i-1]=Convert.ToInt32(Console.ReadLine());
                      }
                      catch 
                      {
                          Console.WriteLine("Yanlış formatta veri girişi yaptınız tekrar deneyiniz:"); 
                          i--;                       
                      }
                 }
                  Array.Sort(sayiDizisi);
                  Console.WriteLine("*****sayiDizisi dizisinin sıralanmış  hali*****");
                  foreach (var item in sayiDizisi)
                  {
                      Console.WriteLine(item);
                  }
                  Console.WriteLine("*****sayiDizisi dizisindeki en büyük 3 sayı*****");
                  Console.WriteLine(sayiDizisi[19]);
                  Console.WriteLine(sayiDizisi[18]);
                  Console.WriteLine(sayiDizisi[17]);
                  Console.WriteLine("*****sayiDizisi dizisindeki en büyük 3 sayının ortalaması*****");
                  Console.WriteLine(((double)sayiDizisi[19]+(double)sayiDizisi[18]+(double)sayiDizisi[17])/3);
                  Console.WriteLine("*****sayiDizisi dizisindeki en küçük 3 sayı*****");
                  Console.WriteLine(sayiDizisi[0]);
                  Console.WriteLine(sayiDizisi[1]);
                  Console.WriteLine(sayiDizisi[2]);
                  Console.WriteLine("*****sayiDizisi dizisindeki en küçük 3 sayının ortalaması*****");
                  Console.WriteLine(((double)sayiDizisi[0]+(double)sayiDizisi[1]+(double)sayiDizisi[2])/3);
                  Console.WriteLine("Ortalamaların toplamı");
                  Console.WriteLine(((double)(sayiDizisi[19]+sayiDizisi[18]+sayiDizisi[17])/3)+((double)(sayiDizisi[0]+sayiDizisi[1]+sayiDizisi[2])/3));
           }
       }
   }
