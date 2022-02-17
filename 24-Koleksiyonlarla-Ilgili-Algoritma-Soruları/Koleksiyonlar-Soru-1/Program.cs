// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System;
using System.Collections;


 namespace sorubir
 {
     class Program
     {
         static void Main(string[] args)
         {   
             ArrayList listeasal = new ArrayList();
             ArrayList listeasaldegil = new ArrayList();
             Console.WriteLine("20 adet pozitif sayı giriniz:");
                 for (int i=1 ; i<=20 ; i++)
                 {
                     Console.Write("{0}. pozitif sayıyı giriniz:",i);
                      try
                      {
                            UInt32 sayi=Convert.ToUInt32(Console.ReadLine());
                            int a=2 ;
                            int kontrol=0 ;
                            if(sayi>=2)
                            {while(a<=sayi)
                            {
                               if(sayi%a==0)
                                 kontrol++;
                                if(kontrol==2)
                                 break;
                               a++;  
                            }
                            if (kontrol>1)
                                listeasaldegil.Add(sayi);
                            else 
                                listeasal.Add(sayi);
                            }
                            else if(sayi==1)
                            {
                                i--;
                                Console.WriteLine("{0} sayısı girdiniz bu sayı asal olarak veya asal olmayarak değerlendirilmemektedir!Başka bir pozitif sayı giriniz:",sayi);
                            }
                            else 
                            {
                                i--;
                                Console.WriteLine("0 sayısı girdiniz pozitif bir sayi giriniz!Tekrar deneyiniz:");
                            }
                      }
                      catch 
                      {
                          Console.WriteLine("Pozitif sayı girmediniz tekrar deneyiniz!");
                          i--;                        
                      }
                 }
            
            Console.WriteLine("****Sıralanmış Asal Sayı Listesi*****");
            listeasal.Sort();
            double toplam1=0;
            int itemsayi1=0;
            double asalOrtalama=0;
            foreach (var item in listeasal)
            {
                Console.WriteLine(item);
                toplam1 +=Convert.ToInt32(item);
                itemsayi1++; 
            }
            Console.WriteLine("Listede kaç tane asal sayı var?");
            Console.WriteLine(itemsayi1);
            Console.WriteLine("Listedeki asal sayıların ortalaması nedir?");
            Console.WriteLine(asalOrtalama=toplam1==0?0:toplam1/itemsayi1);

            Console.WriteLine("****Sıralanmış Asal Olmayan Sayı Listesi*****");  
            listeasaldegil.Sort();
            double toplam2=0;
            int itemsayi2=0;
            double asalDegilOrtalama=0;
            foreach (var item in listeasaldegil)
            {
                Console.WriteLine(item);
                toplam2 +=Convert.ToInt32(item);
                itemsayi2++; 
            }
            Console.WriteLine("Listede kaç tane asal olmayan sayı var?");
            Console.WriteLine(itemsayi2);
            Console.WriteLine("Listedeki asal olmayan sayıların ortalaması nedir?");
            Console.WriteLine(asalDegilOrtalama=toplam2==0?0:toplam2/itemsayi2);
         }
     }
 }