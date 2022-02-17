using System;

 
    namespace Method_Tanımlama
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Methodlar aslında fonksiyonlardır, OOP(object oriented programming,nesne yönelimli programlama) dillerinden sonra method adını aldılar.Methodları bir programı parçalamak için kullanıyoruz.Programları parçalamaktaki yani küçük parçalar halinde yazmaktaki amaç bu şekilde yapmak bizi kod tekrarından kurtarır ve daha okunabilir kod parçaları yazıyor olmamızı sağlar.
                //Methodlar tek başlarına yazılabilen ve tek başlarına çağırılabilen yapılar değillerdir.Methodların bir class içerisinde yazılıyor olması gerekiyor.Bir methoda erişeceğimizde erişmek istediğimiz method mevcut çalıştığımız class içerisindeyse direk method adıyla erişebiliriz lakin mevcut çalıştığımız method içerisinde değilse erişmek istediğimiz method , o zaman erişmek istediğimiz methodun bulunduğu class'ın bir instance'ını (örneğini) mevcut çalıştığımız class'ta yaratmalıyız ve methoda bu instance(örnek) üzerinden erişebiliriz.

                //***Method Syntax'ı:*****************************************************
                  // erişim_belirteci geri_dönüş_tipi  method_adi(parametreListesi/arguman)
                  //{
                       //Komutlar
                  //}
                //************************************************************************
                  //erişim_belirteci:ErişimBelirteci ile bu method'a nerelerden erişilebileceğini belirliyoruz.Method'un erişim belirtecini public olarak tanımlarsak heryerden bu methoda erişilinebilir , fakat private olarak tanımlarsak method'un erişim belirtecini o method'a sadece bulunduğu sınıf içerisinden erişebiliriz.
                  //geri_dönüş_tipi:GeriDönüşTipi ile method bir iş yaptıktan sonra geriye bir şey dönecekmi yani çağırıldığı yerden bir şeye ihtiyaç duyuluyor mu onu belirtiyoruz.Her method bir şey dönmek zorunda değildir aslında geri dönüş yapmayan methodların geriDönüşTipi'de void'dir.geri_dönüş_tipi method'un imzasına ait bir bilgidir ve method tanımlanırken mutlaka belirtilmelidir.
                  //method_adi:Tanımladığımız method'a ne isim vermek istiyorsak onu yazarız buraya.method_adi önemlidir çünkü tanımladığımız method'un adına bakarak tanımladığımız methodun ne iş yaptığını anlıyabiliyor olmak gerekmektedir.İsimlendirmedeki bu durum aslında yazdığımız programdaki tüm isimlendirmeler için geçerlidir.
                  //parametreListesi/arguman:Tanımladığımız method'un iş yaparken kullanacağı parametrelerdir.
                  //Komutlar: Bu kısım kod parçamızı yazacağımız yerdir.Eğer geri dönüş yapmak istiyorsak method'umuzdan döneceğimiz değeri mutlaka return keyword'ü ile dönmeliyiz.

                  int a=2;
                  int b=3;
                  Console.WriteLine(a+b); //Output: 5    
                  int sonuc=Topla(a,b); 
                  Console.WriteLine(sonuc);//Output: 5

                  Methodlar instance=new  Methodlar();//Methodlar class'ının bir örneğini yarattık ve bu Methodlar class'ının örneği üzerinde içindeki methodlara erişebiliriz.
                  instance.EkranaYazdır(Convert.ToString(sonuc));//Output: 5
                  instance.EkranaYazdır(Convert.ToString(a+b));//Output: 5

                  
                  int sonuc1=instance.ArttırVeToplaDegerTipinde(a,b);
                  instance.EkranaYazdır(Convert.ToString(sonuc1));//Output: 7
                  instance.EkranaYazdır(Convert.ToString(a+b));//Output: 5 //a=2,b=3

                  int sonuc2=instance.ArttırVeToplaReferenceTipinde(ref a,ref b);
                  instance.EkranaYazdır(Convert.ToString(sonuc2));//Output: 7
                  instance.EkranaYazdır(Convert.ToString(a+b));//Output: 7 //a=3,b=4
            }

            public static int Topla(int deger1,int deger2)//Main method'dan bu methoda erişebilmek için bu method'u static yaptık.Çünkü Main method static ve bir static method'dan ancak static methodlara erişebiliriz.
            {
                return deger1+deger2;
            }
        }

        class Methodlar
        {
            public void EkranaYazdır(string veri)
            {
               Console.WriteLine(veri);
            }

            public int ArttırVeToplaDegerTipinde(int deger1 , int deger2)//Burada aldığımız parametreleri değer tipinde aldık bu demek oluyor ki aldığımız parametreleri alırken digit(hane) digit burada isimlendirdiğimiz parametrelere koplayardık bellkete bunlar için yer açtık yani bu methodu çağırdığımız yerden aldığımız verilerin kopyalarını yarattık ve bu methodda kullandık.Bu methodda işimiz bittiğinde bellekten tekrar bu kopyalar silinir.
            {
                deger1+=1;
                deger2+=1;
                return deger1+deger2;
            }

             public int ArttırVeToplaReferenceTipinde(ref int deger1 ,ref int deger2)//Burada aldığımız parametreleri ref(referans) tipinde aldık bu demek oluyor ki aldığımız parametreleri alırken digit(hane) digit burada isimlendirdiğimiz parametrelere koplayamak yerine aldığımız değerlerin  bellketeki karşılıklarını verdik(yani adreslerini işaret ettik).Bu method sonunda methodu çağırdığımız yerde bu methoda gönderdiğimiz ref verilerde bu method içerisinde uygulanan işlemler doğrultusunda değişiklik yansır.
            {
                deger1+=1;
                deger2+=1;
                return deger1+deger2;
            }
        }
    }
//****************************************************************
  //***Metot Nedir ?:
  //Metotları programı küçük parçalara ayrıştırmak için kullanırız. Büyük bir programı tek bir metot içinde yazmak yerine küçük parçalara ayırarak yazmak daha doğru bir yaklaşımdır.
  //Bu bizi hem kod tekrarından kurtarır hem de daha okunabilir kod parçaları yazmamızı sağlar. Metotlar tek başlarına kullanılabilen yapılar değildir. Bir sınıf içerisinde yazılmalı ve ancak sınıfın nesnesi aracılığıyla erişilebilir olmalıdır. (Static sınıf metodlarına sinifAdi.metotIsmi şeklinde erişilebilir.)

  //Söz dizimi ise aşağıdaki gibidir:
    //   erişim_belirteci geri_donus_tipi metot_adi(argüman/parametre)
    // 	{
    // 		//komutlar;
    // 	}

  //Metotlat içerisinde tanımlanan değişkenler sadece metot içerisinden erişilebilirler. Programından başından sonuna kadar yaşamazlar. Metottan çıkıldığından lifetime ı yani yaşam süresi sona erer.

  //***Ref Kullanımı:
    //Bir fonksiyona parametre aktarırken değer veya referans tipinde parametre verebiliriz.
    //-->Değer tipleri metoda bit bit kopyalanır. Yani int bir değişkeni parametre olarak değer tipinde bir fonksiyona verdiğimizde; fonksiyon çalışırken bellekten integer bir değişkeni saklayabilecek kadar yer ayrılır ve gönderilen parametre orda saklanır Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. Sadece kopyası üzerinde değişiklik yapılmış olur. Fonksiyon sonlandığındaysa bellekten silinir. Yani yaşam süresi sona erer.Değer Tiplerini şu şekildedir: int, long, float, double, decimal, char, bool, byte, short, struct, enum
    //-->Referans olarak bir atama yapıldığında ise fonksiyona ilgili değişkenin bellekteki adresi gönderilmiş gibi düşünebilirsiniz. Dolayısıyla fonksiyon asıl değişken üzerinde değişiklik yapar. Fonksiyon içerisinde bir değişiklik yapıldığında çağırıldığı yerdeki değişken de değişikliğe uğramış olur. Yani değeri değişir. Bu nedenle ref anahtar kelimesini kullanırken çok dikkatli olunmalıdır.
    //***Ref Kullanımının Özellikleri:
      //-->Referans olarak iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
      //-->ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.
    
    //Örnek ref kullanımı ise şu şekildedir :
      // int x = 3;
      // int y = 4;
      // int sonuc = instance.ArttırVeTopla(ref x, ref y);
      
      // public int ArttırVeTopla (ref int x, ref int y)
      // {
      //     x+=1;
      //     y+=y;
      //     return (x+y);
      // }
//****************************************************************