using System;

  
    namespace Rekursif_ve_Extension_Methodları
    {
        class Program
        {
            public static void Main(string[] args)
            {
               //***Rekürsif Method:Öz Yinelemeli Method(Kendi Kendini Çağıran Method)
               //Rekürsif fonksiyonlarla yaptığımız işlemleri for döngüleriyle de yapabiliriz.Rekürsif fonksiyonları en çok kullandığımız yerler faktoriyel işlemleri ve sayıların üssünü alma işlemleridir.

               // for loop ile 3^4=3*3*3*3:
                int result=1;

                for (int i = 0; i < 4; i++)
                {
                     result*=3;
                }
                Console.WriteLine(result);

                //Elimiz alışması için rekürsif methodla çözümü ayrı sınıfta oluşturup , main method'dan çağırıcam.Rekürsif method ile 3^4=3*3*3*3;
                Islemler instance=new Islemler();
                Console.WriteLine("Üssünü almak istediğiniz sayı ve üssünü giriniz n^m:");
                Console.WriteLine("n:");
                Console.WriteLine("m:");
                if(int.TryParse(Console.ReadLine(),out int ussuAlinacakSayi)&&int.TryParse(Console.ReadLine(),out int us))
                Console.WriteLine(instance.Expo(ussuAlinacakSayi,us));
                

                Console.Write("Faktoriyelini almak istediğiniz sayıyı giriniz:");
                if(int.TryParse(Console.ReadLine(),out int faktoriyel))
                {
                    Console.WriteLine(instance.Faktoriyel(faktoriyel));
                }

                Console.Write("Fibanocci serisinde bulmak istediğiniz n. sayı:");
                if(int.TryParse(Console.ReadLine(),out int n))
                   Console.WriteLine("F(n):{0}",instance.FibonacciSerisi(n));

//***********************************************************************************************************

                //***Extension(genişletilmiş) Methodlar:Extension class'lar ve extension methodlar static olmalıdır.
                string ifade="Okan Arık";
                bool sonuc=ifade.CheckSpaces();
                Console.WriteLine(sonuc);
                if(sonuc)
                {
                    Console.WriteLine(ifade.RemoveWhiteSpaces());
                }
                Console.WriteLine(ifade.MakeUppercase());
                Console.WriteLine(ifade.MakeLowercase());

                int[] sayiDizisi={9,2,6,5,0};
                sayiDizisi.EkranaYazdir();
                Console.Write("\n");//Burada bir alt satıra geçişi sağladık.
                sayiDizisi.SortArray().EkranaYazdir();
                Console.Write("\n");//Burada bir alt satıra geçişi sağladık.

                Console.Write("Çift sayı olup olmadığını kontrol etmek istediğiniz sayıyı giriniz:");
                if(int.TryParse(Console.ReadLine(),out int number))
                   Console.WriteLine(number.IsEventNumber());

                Console.Write("Siz birşeyler yazın biz size ilk karakterini verelim:");
                string kontrolYazi=Console.ReadLine();
                if(!string.IsNullOrEmpty(kontrolYazi))
                  Console.WriteLine(kontrolYazi.GetFirstCharacter());
            }
        }

//***********************************************************************************************************
        public class Islemler
        {
            public int Expo(int sayi,int us)
            {
                if (us<2)
                   return sayi; 
                return Expo(sayi,us-1)*sayi ;
            }
            //Expo(3,4);              
            //Expo(3,3)*3;      (Expo(3,4)=Expo(3,3)*3)
            //Expo(3,2)*3*3;    (Expo(3,4)=Expo(3,3)*3=Expo(3,2)*3*3)
            //Expo(3,1)*3*3*3;  (Expo(3,4)=Expo(3,3)*3=Expo(3,2)*3*3=Expo(3,1)*3*3*3)
            //3*3*3*3;          (Expo(3,4)=Expo(3,3)*3=Expo(3,2)*3*3=Expo(3,1)*3*3*3=3*3*3*3)

            public int Faktoriyel(int sayi)
            {
                if(sayi<=1)
                  return 1;
                return sayi*Faktoriyel(sayi-1);
            }
            //Faktoriyel(5)
            //5*Faktoriyel(4)
            //5*4*Faktoriyel(3)
            //5*4*3*Faktoriyel(2)
            //5*4*3*2*Faktoriyel(1)
            //5*4*3*2*1

            public int FibonacciSerisi(int param)
            {
                if(param==0 )
                  return 0;
                else if(param==1)
                  return 1;
                else
                  return FibonacciSerisi(param-1)+FibonacciSerisi(param-2);
            }
        }

//**********************************************************************************************************

        public static class Extensions//Extension Class
        {
            public static bool CheckSpaces(this string param)//Extension Method
            {
                
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpaces(this string param)//Extension Method
            {
                string[] dizi=param.Split(" ");//param string'ini white space'lere göre ayırdım ve dizi adında string veri tipinde eleman saklayan diziye atadım.
                string result=string.Join("" , dizi);//Burada dizi adındaki dizideki elemanları aralarına "" koyarak string'e dönüştürdüm ve result değişkenine atadım.
                return result;
            }

            public static string MakeUppercase(this string veri)//Extension Method
            {
                return veri.ToUpper();
            }

             public static string MakeLowercase(this string veri)//Extension Method
            {
                return veri.ToLower();
            }
            
            public static int[] SortArray(this int[] param)//Extension Method
            {
                Array.Sort(param);
                return param;
            }

            public static void EkranaYazdir(this int[] param)//Extension Method
            {
                foreach (var item in param)
                {
                    Console.Write(item+" ");
                }
            }

            public static bool IsEventNumber(this int sayi)//Extension Method
            {
                return sayi%2==0;
            }

            public static string GetFirstCharacter(this string yazi)//Extension Method
            {
                return yazi.Substring(0,1);
            }
        }

    }
//Extension:genişletilmiş
//rekürsif:öz yinelemeli
//implement:uygulamak,yerine getirmek
//generate:üretmek,meydana getirmek,var etmek,dünyaya getirmek
//*******************************************************************************************
  //***Extension ve Rekürsif Metotlar:
   //Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
   //Extension metot yazarken dikkat etmemiz gereken bir kaç kural vardır. Şu şekilde :
   //-->Static bir class içerisinde static bir metot olarak yazılmalılar.
   //-->Extension metod da tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.

   //Küçük bir örnek ile kullanımını görelim:
     //    public static class MyExtensionClass
     // {
     //     public static bool IsEventNumber(this int value)
     //     {
     //         if(value%2==0)
     //             return true;
     //         else
     //             return false;
     //     }
     // }
   //Yukarıdaki örnekte static class içerisinde IsEventNumber adında bir extension metot görüyoruz. Metodun kendisi de static keywordü ile tanımlandı. this keywordünün uygulandığı parametreye bakarsak, integer ver tipindeki değişkenlere uygulanabilir extension metot olduğunu görüyoruz. Sayısının çift olup olmaması durumuna göre de geriye bool bir değer dönüyor.
   //Extension metotların kullanımını oturtmanın en kolay yolu öncelikle işi yapacak olan metodu istenileni karşılayacak şekilde yazmaktır. Daha sonradan class ve metodu static yaparak ve genişletilecek veri tipine bağlı parametrenin başına this anahtar kelimesi ekleyerek kullanabilirsiniz.
   //Yukarıdaki extension metodun örnek kullanımı ise şu şekildedir:
     //int deger = 123; bool isEven = deger.IsEvenNumber();
//*******************************************************************************************
  //***Rekürsif(Yinelemeli) Metot Kullanımı:
   //Rekürsif metotlar ilk öğrenildiğinde içselleştirilmesi ve kullanılması zor metotlardır. Ama yazılımın ilerleyen yıllarında kullanımı oturur ve bir çok soruna rekürsif metotları kullanarak çözüm getirebilirsiniz. O nedenle acele etmemek gerek :)
   //Çok sık olmasa da bazen fonksiyonun kendi kendini çağırmasına ihtiyaç duyarız. For döngüsü ile karmaşık bir kod yazarak da bu ihtiyacı karşılamak mümkün. Rekürsif fonksiyonlar ise tam da bu ihtiyaç için ortaya koyulmuştur.
   //Rekürsif fonksiyon kendi kendini çağırma yeteneğine sahip olduğu için kullanırken çok dikkatli olmak gerek. En büyük sorunlardan biri sonsuz döngüye neden olmaları. Bu da System.StackOverflowException olarak bilinen hataya neden olur. Yani belleğin stack bölgesinde bu fonksiyon çağrımı için ayrılan alan tükenmiştir. Yinelemeli olarak yaptığınız işe bağlı olarak  risk de artar.
   //Aşağıdaki örneği inceleyerek ve hatta kağıt üzerinde yazarak yinelemeli fonksiyonların kullanımını daha iyi oturtabilirsiniz:
     //    static int FibonacciSerisi(int sayi)
     // {  
     //     if (sayi==0)
     //         return 0;
     //     elseif (sayi==1)
     //         return 1;
     //     else
     //         return FibonacciSerisi(sayi-1)+FibonacciSerisi(sayi-2);
     // }
//*******************************************************************************************
     