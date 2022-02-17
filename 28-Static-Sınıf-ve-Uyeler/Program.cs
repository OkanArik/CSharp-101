using System;


    namespace Static_Sinif_ve_Uyeleri
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Bu dersimizde static sınıflar ve static sınıf üyelerine bakacağız.Bir class içerisindeki static olmayan methodlara, fieldlara , propertylere osınıftan oluşturduğumuz nesne aracılığıyla erişiyoruz.Static olan elemanlara ise o sınıfın adı ile erişiriz yani bir nesne oluşturmamıza geek yok ki zaten oluşturamayız, o sınıfın adı nokta erişmek istediğimiz method yada field yada özelliği yazarak erişiriz.
                //***************************************************************************************************
                Console.WriteLine("Çalışan sayısı   :{0}",Calisan.CalisanSayisi);

                Calisan calisan=new Calisan("Ayşe","Yılmaz","Sotware Development");
                Console.WriteLine("Çalışan sayısı   :{0}",Calisan.CalisanSayisi);

                Calisan calisan1=new Calisan("Deniz","Arda","Sotware Development");
                Calisan calisan2=new Calisan("Okan","Arık","Sotware Development");
                Calisan calisan3=new Calisan("Gül","Döne","Sotware Development");
                Calisan calisan4=new Calisan("Ahmet","Dönmez","Sotware Development");
                Console.WriteLine("Çalışan sayısı   :{0}",Calisan.CalisanSayisi);
                //***************************************************************************************************

                Console.WriteLine("Toplama işlemi sonucu(110,100)  :{0}",Islemler.Topla(110,100));
                Console.WriteLine("Çıkarma işlemi sonucu(110,100)  :{0}",Islemler.Cıkar(110,100));
                 
            }
        }
//*******************************************************************************************************************

        class Calisan
        {
            //Static olmayan classlar için classın içerisinde static olmayan üyeler classın nesnelerine özel set leniyor ve get leniyorken, classın içerisindeki static olan üyeler class bazında atanır.
            //Calisan sınıfından her nesne oluşturduğumuzda public constructor'ı çalışır lakin Calisan sınıfının static kurucusu bir defa çalışır o da ilk nesnesini oluşturduğumuzda.
            private static int calisanSayisi;
            private string Isim;
            private string Soyisim;
            private string Departman;

            public static int CalisanSayisi { get => calisanSayisi;}
            static Calisan()//-->Static Constructor // Static kurucuların erişim belirteci yoktur.Sınıfın static üyelerini static kurucu içerisinden intilaze ediyorum yani intial value assign ediyorum.
            {
                calisanSayisi=0;
            }
            public Calisan(string isim, string soyisim , string departman )//--Constructor
            {
                this.Isim = isim;
                this.Soyisim = soyisim;
                this.Departman = departman;
                calisanSayisi++;
            }
        }
//*******************************************************************************************************************

        static class Islemler//Sınıfların static olmasına neden ihtiyaç duyarız? Bir sınıfı static yaparsak onun içerisindeki tüm propertyler , tüm fieldlar , tüm methodlar static olmak zorundadır.Static classlar içerisinde static olmayan herhangi bir üye kullanamazsınız.Eğer bir sınıfın içerisindeki tüm üyeleri static yapacaksam gider o sınıfıda static hem o sınıftaki üyelerimin static kalmasında koruma sağlarım hem okunabilirlik açısından fayda sağlar.Static sınıflara kalıtım işlemi uygulanamaz!
        {
            public static long Topla(int sayi1,int sayi2)
            {
                return sayi1+sayi2;
            }

            public static long Cıkar(int sayi1,int sayi2)
            {
                return sayi1-sayi2;
            }
        }
    }
//*******************************************************************************************************************
//Static Sınıf ve Üyeler:

//Static Üyeler
//Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
    // class Ogrenci
    // {
    //     public static int OgrenciSayisi = 0;
    //     public string Isim;
    //     public string Soyisim;
    //     public Ogrenci()
    //     {
    //         OgrenciSayisi++;
    //     }
    // }
    
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         //Static sınıf üyesine erişim
    //         Console.WriteLine("Öğrenci sayısı: {0}",Ogrenci.OgrenciSayisi);
    
    //         //Static olmayan sinif üyesine erişim
    //         Ogrenci ogrenci1 = new Ogrenci();
    //         ogrenci1.Isim = "Deniz";
    //         ogrenci1.Soyisim = "Arda";
            
    //         Ogrenci ogrenci2 = new Ogrenci();
    //         ogrenci2.Isim = "Ayşe";
    //         ogrenci2.Soyisim = "Yılmaz";
    
    //         Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);
    //     }
    // }
//Yukarıda hem static hemde static olmayan sınıf üyesine sahip bir sınıf tanımı ve program içerisinden kullanımı görüyorsunuz. Static olmayan üyeler nesne bazında yaratılırken static sınıf üyeleri uygulama çalıştığı sürece kendilerine atanan veriyi tutarlar. Yani yukarıdaki örnek için konuşursak, "Isim" ve "Soyisim" her nesne yaratıldığında başlangıç değeri olarak null alır, ataması yapıldığındaysa nesne bazında değerini tutar. Ama "Ogrenci Sayısı" field'ı program boyunca nesne yaratıldıkça öğrenci sayısının değerini 1 arttırarak bu veriyi korur.
//Yukarıdaki örnekte de görebileceğiniz gibi bir özelliği static yapmak için geri dönüş tipi yada veri tipinden önce erişim belirleyiciden sonra "static" anahtar kelimesini koymanız yeterlidir.
//Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz. Sınıfın static üyelerinin başlangıç değerlerini static kurucular aracılığıyla yapabiliriz. Parametre almazlar ve erişim belirleyicileri yoktur.

//Static Sınıflar:
//Metotlar ve özellikler gibi sınıflar da static anahtar kelimesi ile oluşturulabilirler. Yukarıdaki örnekte de görebileceğiniz üzere normal sınıflar içerisinde static metotlar ve üyeler kullanabiliriz. Peki o halde neden sınıfları static yapma ihtiyacımız olsun? Buna okunabilirliği arttırmak için diyebiliriz.
//Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.
//*******************************************************************************************************************

