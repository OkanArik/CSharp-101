using System;


    namespace Switch_Case
    {
        class Program
        {
            public static void Main(string[] args)
            {
                int month=DateTime.Now.Month;//month adında integer veri tipinde tanımladığık değişkenime DateTime.Now.Month kodu ile kodun çalıştığı tarihteki ayı integer olarak yani kaçıncı ayda olduğumuzu atadık.
                
                //switch(expression(yani kontrol etmek istediğimiz koşul))
                switch (month)
                {
                    case 1:
                    Console.WriteLine("Ocak ayındasınız!");
                    break;
                    case 2:
                    Console.WriteLine("Şubat Ayındasınız!");
                    break;
                    case 3:
                    Console.WriteLine("Mart ayındasınız!");
                    break;
                    case 4:
                    Console.WriteLine("Nisan ayındasınız!");
                    break;
                    case 5:
                    Console.WriteLine("Mayıs ayındasınız!");
                    break;
                    case 6:
                    Console.WriteLine("Haziran ayındasınız!");
                    break;
                    case 7:
                    Console.WriteLine("Temmuz ayındasınız!");
                    break;
                    case 8:
                    Console.WriteLine("Ağustos ayındasınız!");
                    break;
                    case 9:
                    Console.WriteLine("Eylül ayındasınız!");
                    break;
                    case 10:
                    Console.WriteLine("Ekim ayındasınız!");
                    break;
                    case 11:
                    Console.WriteLine("Kasım ayındasınız!");
                    break;
                    case 12:
                    Console.WriteLine("Aralık ayındasınız!");
                    break;
                    default://Default sonda kullanılmak zorunda değildir ve optional'dır yani kullanımı zorunlu değil isteğe bağlıdır.
                    //Komutlar
                    break;
                }


                switch (month)//Bu örnekta görüldüğü gibi bir den çok case'i aynı çıktı için kullanabiliriz.
                {
                    case 12:
                    case 1:
                    case 2:
                    Console.WriteLine("Kış mevsimindesiniz!");
                    break;
                    case 3:
                    case 4:
                    case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz!");
                    break;
                    case 6:
                    case 7:
                    case 8:
                    Console.WriteLine("Yaz mevsimindesiniz!");
                    break;
                    default://Default(varsayılan) sonda kullanılmak zorunda değildir ve optional'dır yani kullanımı zorunlu değil isteğe bağlıdır.
                    //Komutlar
                    break;
                    case 9:
                    case 10:
                    case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz!");
                    break;            
                }
                   
            }
        }
    }
//****************************************************************
   //***Switch-Case Yapısı:
   //Switch-Case deyimi if-else deyimleri gibi karar kontrol yapılarıdır. Switch-Case ifadeleri yapabileceğiniz her şeyi if-else blokları ile de yapabiliriz. Bir ifade üç veya daha fazla koşula göre ayrıştırıldığında genel olarak if-else'e alternatif olarak switch case kullanılır.

        // Örnek bir switch-case ifadesi :

        // switch(degisken)
        // {
        //     case sabit1:
        //         komutlar;
        //         break;
        //     case sabit2:
        //         komutlar;
        //         break;
        //     case sabit3:
        //         komutlar;
        //         break;
        //     default:
        //         komutlar;
        //         break;
        // }
    // Yukarıdaki örnekte, değişken adıyla girdi alınan veri kontrol edilir. Eğer değişken sabit1'e eşit ise bazı komutlar çalıştırılır ve switch ifadesi sonlandırılır.

    // Bir koşul sağlandığında gerekli komutlar çalıştırıldıktan sonra break; ifadesi ile kontrol sonlandırılır. Bu demek oluyor ki her case ifadesi birbirinden farklı olmalıdır. Ve bir switch-case ifadesinde yalnızca bir case çalışmalıdır.

    // Peki kontrol edilen değişken hiç bir sabit ifadeye eşit değilse ne olacak ? Tam da bu noktada default case'ini görüyoruz. Bu durumda kod default kısmında belirtilen kod bloğunu çalıştırır.

    // Switch-Case ifadelerinde dikkat edilmesi gereken durumlar aşağıdaki gibidir:

    //--> Case ifadelerinin sırası önemli değildir.
    //--> Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
    //--> Default ifadesi zorunlu değildir. Yazılmasa da olur.