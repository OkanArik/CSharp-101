using System;


    namespace CSharp_Enum
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Bu dersimizde enum'ları konuşacağız.Enum aslında enumeration'ın kısaltmasıdır yani numaralandırma(sıralama)dır.Birden fazla sabite aynı anda ihtiyacımız varsa sabit dediğimiz şeyler aslında değeri belli olan değişkenler.Bu noktada kodun okunabilirliğini artırmak için enumları kullanırız.Bir çok yerde tek tek değişken tanımlayıp onlarda sabit tutacağımız değerlerini atamak yerine enum kullanmak daha uygundur.Enumlar yazılım geliştirirken çok fazla kullanılan ve okunabilirliğide çok fazla artıran yapılardır.
                //***************************************************************************************************
                //***Enum:
                //    Enum
                // Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum lardan faydalanırız.
                // "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.

                // enum Gunler 
                // {
                //     Pazartesi, 
                //     Sali, 
                //     Carsamba, 
                //     Persembe, 
                //     Cuma, 
                //     Cumartesi, 
                //     Pazar
                // };
                // Yukarıda Gunler enum'ını görüyorsunuz. Enum lar default olarak 0'dan başlar.

                // Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine erişebiliriz. Eğer Pazartesinin 0. gün oldugu bilgisine ihtiyacımız varsa o da şu şekildedir: (int)Gunler.Pazartesi**
                //****************************************************************************************************
                Console.WriteLine(Gunler.Pazar);//Pazar
                Console.WriteLine((int)Gunler.Cumartesi);//24
  
  
                int sicaklik=32;
                if (sicaklik<=(int)HavaDurumu.Normal)
                    {Console.WriteLine("Dışarıaya çıkmak için havanın biraz daha ısınmasını bekleyelim.");}
                else if (sicaklik>=(int)HavaDurumu.Sıcak)
                    {Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");}
                else if (sicaklik>(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak)
                    {Console.WriteLine("Hadi dışarıya çıkalım.");}

            }

            enum Gunler
            {
                Pazartesi=1,//Gunler enum ının Pazartesi üyesi ve index'i bir. 
                Sali, //Gunler enum ının Salı üyesi ve index'i iki. 
     
                Carsamba, //Gunler enum ının Çarşamba üyesi ve index'i üç. 
     
                Persembe, //Gunler enum ının Perşembe üyesi ve index'i dört. 
     
                Cuma=23, //Gunler enum ının Cuma üyesi ve index'i 23. 
     
                Cumartesi, //Gunler enum ının Cumartesi üyesi ve index'i 24. 
     
                Pazar  //Gunler enum ının Pazar üyesi ve index'i 25. 
     
            }

            enum HavaDurumu
            {
                Soguk=5,
     
                Normal=20,
     
                Sıcak=25,
     
                CokSıcak=30
            }
        }
    }
//********************************************************************************************************************
//-->Bir sınıf kapsamında tanımlanmış değişkenler field denir.
//-->Bir sınıfı nesnesi ilk oluşturulduğunda yani nesnesi ayağa kalkarken yapılması gerekenler varsa Constructor metot tanımlanarak default constructor metot ezilir ve yapılması gerekenler constructor metotlta yazılır.
//-->Tanımlanmış sınıftan örneği oluşturulan bazı nesnelerin farklı durumlarda başlatılması gerektiğinde Aşırı yüklenmiş kurucu(overloading Constructor) kullanılır.
//-->Bir class için new anahtar sözcüğünü kullanarak bir nesne yaratıldığında , nesneyi oluşturmak için gerekli bellek heap üzerinden alınır.
//-->Öğenin yığından öbeğe otomatik kopyalanmasına Boxing/Kapsülleme adı verilir.
//-->Temel sınıfın bir üyesine, sadece bu sınıftan türemiş bir sınıfın erişebilmesi istiyorsak erişim belirteci olarak protected kullanmamız gerekir.
//********************************************************************************************************************