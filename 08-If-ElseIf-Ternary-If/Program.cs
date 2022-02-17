using System;


    namespace If_ElseIf_Ternary_If
    {
        class Program
        {
            public static void Main(string[] args)
            {
               int time= DateTime.Now.Hour;//time adında integer(int) veri tipinde belirlediğimiz değişkenimize DateTime.Now.Hour komutu ile kodu çalıştırdığımız zamanki saati atadık.
                
               //**If-ElseIf:
               if (time>=6 && time<11)
               {
                   Console.WriteLine("Günaydın!");
               }
               else if (time<=18)
               {
                   Console.WriteLine("İyi Günler!");
               }
               else 
               {
                   Console.WriteLine("İyi Geceler");
               }

               //***Ternary-If: Basit if-else bloklarının yerine ternary-if operatörlerini kullanabiliriz.
               string result=time<=18 ? "İyi Günler!" : "İyi Geceler!";//Burada result adında string veri tipinde belirlediğimiz değişkenimize atama yaptık , atama yönetmimiz; condition(koşul,şart) ? koşul doğru ise burayı atar : koşul yanlış ise burayı atar
               Console.WriteLine(result);

               result=time<11 && time>=6 ? "Günaydın!" : time<=18 ? "İyi Günler!" : "İyi Geceler!";//Burada result adında string veri tipindeki değişkenimize atama yaptık , atama yöntemimiz ; koşul kontrolü yaptık ? koşul doğru ise burayı atadık : koşul yanlış ise yeni bir koşul kontrolü yaptık ? yeni koşul doğru ise burayı atadık : yeni koşul yanlış ise burayı atadık
               Console.WriteLine(result);
            }
        }
    }
//****************************************************************
   //condition:şart,durum,koşul
   //true:doğru
   //false:yanlış
   //Ternary:üçlü,üçerli,üç parçalı
   //***If-Else Yapısı ve Ternary If:
   //Örnek bir if else kullanımı aşağıdaki gibidir.
   //bool condition=true;
   //if (condition)
   //{
       //Console.WriteLine("Değişken:true");
   //}
   //else
   //{
       //Console.WriteLine("Değişken:false");
   //}
//****************************************************************