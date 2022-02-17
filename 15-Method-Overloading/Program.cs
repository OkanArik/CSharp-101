using System;

    namespace Method_Overloading
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //***Out Parametre:Bir fonksiyona bir iş yaptırıp ve onun sonucunda bir değeri setlemek istiyorsak ve o setlediği şeyide kullanmak istiyorsak bunu out parametre olarak verebiliriz.
                //***Out Parametreler:
                string sayi="999";

                bool sonuc=int.TryParse(sayi,out int outSayi);//Burada int.TryParse(***"integere'a çevirilmek istenen veri"***  ,  ***"eğer veri integer'a çevirilebiliyorsa out parametresi ile setlenecek değişken tanımı"***) kullandık.Bu method bollean değer döner , type conversion gerçekleşirse true gerçekleşmezse false döner.

                if (sonuc)
                {
                    Console.WriteLine("Başarılı!");
                    Console.WriteLine(outSayi);
                }
                else
                { 
                    Console.WriteLine("Başarısız!");
                }

                int a=5, b=4;
                Methodlar ornek=new Methodlar();
                ornek.Topla(a,b,out int toplamSonucu);
                Console.WriteLine(toplamSonucu);
                ornek.Topla(6,5,out int toplamSonucu1);
                Console.WriteLine(toplamSonucu1);

                //***Method Overloading(Method Aşırı Yükleme):Bir fonsiyonun(methodun) imzasını değiştirerek birden fazla şekilde o foksiyonu kullanabiliriz.
                int ifade=9999;
                ornek.EkranaYazdir(Convert.ToString(ifade));
                ornek.EkranaYazdir(ifade);
                  //Method Imzasi: methodAdi + parametreSayisi + parametreTipi
                ornek.EkranaYazdir(ifade,ifade+1);
                ornek.EkranaYazdir("Okan","Arık",out string fullName );
                Console.WriteLine("Adınız ve soyadınız:{0}",fullName);
            }
        }

        class Methodlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a+b;
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri , int veri1)
            {
                Console.WriteLine(veri+veri1);
            }

            public void EkranaYazdir(string veri , string veri1 , out string sonuc)
            {
                Console.WriteLine(veri+" "+veri1);
                sonuc=veri+" "+veri1;
            }
        }
    }
//****************************************************************
  //*****Metot Overloading ve Out Parametre Kullanımı:
  //***Metot Overloading Nedir?:
  //Method overloading yani methodların aşırı yüklenmesi method imzasının değştirilerek aynı isimdeki methodun birden farklı versiyonunun yaratılmasıdır.
    //Method İmzası:
      //metotAdi + parametreSayisi + parametreTipleri
  
  //Örnek:
    //public void EkranaYazdir(int deger)
    //{
        //Console.WriteLine(deger);
    //}
    //public void EkranaYazdir(string deger)
    //{
        //Console.WriteLine(deger);
    //}
    //public void EkranaYazdir(string deger1,string deger2)
    //{
        //Console.WriteLine(deger1 + deger2);
    //}
  //Yukarıda EkranaYazdir isimli methodun 3 overload versiyonunu görüyoruz.Parametre sayısı ve parametre veri tiplerini değiştirerek aşırı yüklemiş olduk.
  //ÖNEMLİ: Geri dönüş tipi method imzasına dahil değildir.Yani sadece geri dönüş tipini değiştirerek bir methodu aşırı yükleyemeyiz.Derleyici hata verecektir.
  //***Out ve Ref Parametre Kullanımı:
    //Out anahtar kelimesi ref anahtar kelimesi ile aynı işi yapıyor diyebiliriz.Arada sadece bir kaç fark var.
    //Out Kullanımının Özellikleri:
      //-->Out olarak kullanılmak istenen değişkenin önüne mutlaka "out" yazılmalıdır.
      //-->out değişkeninin bir ilk değeri olmak zorunda değildir.Hatırlarsanız bu ref kullanırken zorunluydu.
    //Örnek out kullanımı:
      //instance.Toplam(4,8,out int toplam)
      //public int Toplam(int a,int b,out int toplam)
      //{
          //toplam=a+b;
          //return toplam;
      //}
//****************************************************************
