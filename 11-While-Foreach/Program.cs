using System;

    namespace While_Foreach
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //***While:
                //1 den başlayarak Console'dan girilen sayı dahil, Console'dan girilen sayıya kadar olan sayıların ortalamasını hesapla Console'a yazdır.
                Console.Write("1 den başlayarak Console'dan girilen sayı dahil, Console'dan girilen sayıya kadar olan sayıların ortalamasını almak istediğiniz sayıyı giriniz: ");
                int counter=1;
                decimal sum=0;
                if(int.TryParse(Console.ReadLine(),out int number))
                while (counter<=number)
                {
                    sum+=counter;
                    counter++;     
                }
                Console.WriteLine(sum);
                Console.WriteLine("Average(Ortalama):{0}",sum/number);

                //'a' dan 'z' ye kadar 'z' de dahil tüm harfleri Console'a yanyana aralarında bir whitespace(boşluk) bırakarak yazdır.
                char character='a';
                while (character<='z')
                {
                    Console.Write(character+" ");
                    character++;
                }

                //***Foreach:Foreach dögüsünü diziler veya koleksiyonlar için kullanırız.
                string[] cars={"BMW","TOYOTA","MAZDA","NİSSAN","FORD"};//string veri tipinde cars adında dizi tanımladık ve içerisine 5 adet eleman atadık.
                Console.WriteLine("\nAraba Markaları:");//Burada \n ile Araba Markaları: yazımızı konsolda hangi satıra yazacaksa bir alt satırında yazmasını söyledik.
                foreach (var item in cars)//Cars dizisini her bir elemanına (nesnesine) item ismiyle erişeceğiz.Burada var aslında item'ın tipidir,var tipi belli olmayan genel bir tanımlama ifadesi gibi düşünülebilir.Var generic(genel) bir veri tipidir, direk specific(özel) bir veri tpi tanımlamadan her veri tipindeki veriyi var veri tipiyle saklayabiliriz.Object veritipinden türüyor aslında ,dolayısıyla tüm veri tiplerini kapsıyor gibi düşünülebilir.
                {
                     Console.WriteLine(item);                     
                }


            }   
        }
    }
//****************************************************************
   //***While Foreach:
   //While:
    // Koşullar sağlandıkça komut satırlarının çalıştırılmasını sağlar. For döngüsünden farklı olarak iterasyon sayısı belli değildir.

    // int sayac = 1;
    // while (sayac <= 5)
    // {
    //    Console.WriteLine(sayac);
    //    sayac++;
    // }
    // Yukarıdaki örnekte bir while döngüsü görüyoruz. sayac başlangıçta 1 olarak verilmiş. Ve sayaç 5 den küçük veya 5'e eşit olduğu sürece console'a sayacın değerini yazdıracak. Ve her döngü sonunda sayacın değerini bir arttıracak.
   //ForEach:
    //Foreach döngüsü diziler ve koleksiyonlarla döngüsel işlemler yapmak için kullanılır. Yapısı while ve for döngüsünden biraz farklıdır. Döngünün ne kadar devam edeceğini kullanılan dizi veya koleksiyonun eleman sayısı belirler. Her bir elaman için bir iterasyon gerçekleşir.

    // Yazım şekli aşağıdaki gibidir.

    // foreach(değişkenTipi değişkenAdı in diziAdı)
    // {
    //     //Komutlar
    // }
    // Aşağıdaki örnekte foreach döngüsü kullanarak dizinin elemanlarını topladık.

    // int[] sayiDizisi = {2,4,5,1,2,4};
    // int toplam = 0 ;

    // foreach(int i in SayiDizisi)
    // {
    //     toplam += i ;
    // }
//****************************************************************
   //initial value:başlangıç değeri
   //sum:toplam
   //result:sonuç
   //number:sayı
   //counter:sayaç
   //collection:koleksiyon