using System;
  

    namespace Try_Catch_Finally
    {
        class Program
        {
            public static void Main(string[] args)
            {
               Console.WriteLine("Bir sayı giriniz:");
               int sayi=Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Girmiş olduğunuz sayi:"+sayi);
                  //Yukarıdaki 3 satırlık kod parçam hataya açık çünkü burada numeric olsun olmasın girilen veriyi integer veri tipine çevirip sayi değişkenine atamaya çalışıyorum fakat numeric veri girişi haricindeki veri girişlerinde hata olacak numeric harici veri girişleri integer veri tipine dönüştürülemediği için kodum runtime error verecek.Bu şekilde hata ya açık kodları tyr-catch-finally yapısında kullanırsak,hataya açık kodu try kod bloğunun içerisine yazarız ve hata vermezse try dan sonra finally kod bloğundan devam eder eğer hata verirsede catch kod bloğundan ardından finally kod bloğundan devam eder. Bu arada finally kod bloğu optional yani isterseniz kullanabilirsiniz istemezseniz kullanmazsınız.
            //**********************Try-Catch-Finally****************************************

                  try
                  {
                      //Hataya neden olabilecek kod yazılır.Eğer kodda hata olursa yani hata fırlatırsa catch bu hatayı yani exception(sıradışı durum,kuraldışılık)'ı yakalayacak.
                        Console.WriteLine("Bir sayı giriniz:");
                        int sayi1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Girmiş olduğunuz sayi:"+sayi1);                   
                  }
                  catch (Exception ex)//Burada Exception class'ından gelecek olan hataya ex ismini verdik.(Burada Exception class'tır ve ex de hatayı (hata nedenini ve hatanın açıklamasını) atadığımız bizim belirlediğimiz isimdeki objedir.)
                  {
                      Console.WriteLine("Hata:{0}",ex.Message.ToString()); //Burada ex benim hatam , bu bir obje aslında ,ex.Message bana hata mesajını(hatanın açıklamasını) döner ve ex.Message.ToString() şeklindede string veri tipine dönüştürdüm.//Output:   Hata:Input string was not in a correct format.         
                      Console.WriteLine("Hata:{0}",ex); //Output:    Hata:System.FormatException: Input string was not in a correct format.            
                  }
                  finally
                  {
                      //Try'da yazdığımız kod bloğu hata fırlatsın veya fırlatmasın çalıştırılmasını istediğimiz başka bir kod bloğu varsa o kod bloğunu buraya yazarız.Finally bloğu zorunlu değildir , eğer istemezsek kullanmayabiliriz yani finally bloğu optional(isteğe bağlı)'dır.
                      Console.WriteLine("İşlem tamamlandı.");

                  }

            //*******************************************************************************
               //exception=kuraldışılık,sıradışı durum
               //Belli exception tipleri vardır, özel exception tipleri yakaladığımızda tipi belli olan ve hangi koşulda fırlatıldığını bildiğimiz exception'lar.Buna görede kullanıcıya bilgi vermek istiyor olabiliriz , her seferinde bir hata oluştu yerine örneğin hata null kaynaklı oluştuysa null kaynaklı bir hata oluştu gibi.Bu ifadelerle daha user friendly (kullanıcı dostu) hata mesajı dönmek istiyor olabiliriz.
               //Hatırlatma--- Parse Methodu:string ifadeleri ,integer değerlere dönüştürmek için kullanırız.
               
               //***System.ArgumentNullException:Value cannot be null.
               try
               {
                   int a=int.Parse(null);
                   
               }
               catch (ArgumentNullException ex)//Try bloğundaki kodumun fırlatacağı exception'ın ArgumentNullException olduğunu bildiğimden specific olarak user friendly olması için burada exception'ımı ArgumentNullException olarak belirttim.
               {
                   Console.WriteLine("Boş değer girdiniz!");  
                   Console.WriteLine(ex);//Output:  System.ArgumentNullException: Value cannot be null. (Parameter 's')   at System.Int32.Parse(String s)  at Try_Catch_Finally.Program.Main(String[] args) in    C:\Users\DELL\OneDrive\Masaüstü\BaşlangıçSeviyesi.   NETPatikası\C#101\7-Try_Catch_Finally\Program.cs:line 42        
               }

               //***System.FormatException:Input string was not in a correct format.
                try
               {
                   int a=int.Parse("test");
                   
               }
               catch (FormatException ex)//Try bloğundaki kodumun fırlatacağı exception'ın FormatException olduğunu bildiğimden specific olarak user friendly olması için burada exception'ımı FormatException olarak belirttim.
               {
                   Console.WriteLine("Girdinizin veri tipi uygun değil!");  
                   Console.WriteLine(ex);//Output:  System.FormatException: Input string was not in a correct format.  at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)   at System.Int32.Parse(String s)  at Try_Catch_Finally.Program.Main(String[] args) in C:\Users\DELL\OneDrive\Masaüstü\BaşlangıçSeviyesi. NETPatikası\C#101\7-Try_Catch_Finally\Program.cs:line 55
               }

               //***Systeö.OverFlowException:(Girilen değerin minimum ve maximum değerleri dışında olması durumunda kodun fırlattığı exception(hata,kuraldışılık,sıradışı durum)'dır.Yani girilen değer ya atanacak değişkenin veri tipinin alacağı değer aralığından ya küçüktür yada büyüktür. ) Value was either too large or too small for an Int32.
                try
               {
                   int a=int.Parse("-20000000000000");
                   
               }
               catch (OverflowException ex)//Try bloğundaki kodumun fırlatacağı exception'ın OverflowException olduğunu bildiğimden specific olarak user friendly olması için burada exception'ımı OverflowException olarak belirttim.
               {
                   Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz!");  
                   Console.WriteLine(ex);//Output:  System.OverflowException: Value was either too large or too small for an Int32.        at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)   at  System.Int32.Parse(String s)  at Try_Catch_Finally.Program.Main(String[] args) in   C:\Users\DELL\OneDrive\Masaüstü\BaşlangıçSeviyesi.    NETPatikası\C#101\7-Try_Catch_Finally\Program.cs:line 68
               }              
            }
        }
    }
//********************************************************************
   //*****Exception Handling(Hata Yönetimi)*****
   //exception:istisna,sıradışı durum,kuraldışılık
   //handle:işlemek,ele almak,idare etmek,başa çıkmak
   //Hatalar oluşma zamanına göre ikiye ayrılıyor:
   //(1)Compile Time Error:Compile Time Error biz kodu yazarken derleyici(compiler)'nin bize fırlattığı hatalardır.Misal biz bir değişken tanımlamışızdır ve bu değişkene ilk değer ataması yapmadan kullanmaya çalışıyoruzdur ve derleyici(compiler) bize kızar yada değişken tanımlama standartlarına uygun değişken tanımlamıyoruzdur derleyici bize kızar bunun gibi hatalardır ve bu compile time error'ları yani derleme zamanı hatalarını kodu yazarken farkedebiliriz.
   //(2)Run Time Error:Run Time Error'ları mümkün olduğunca handle etmek yani yakalıyor olmak gerekiyor ki programı beklenmedik bir anda kırmasın , başka bir probleme yol açmasın.Run Time Error yani çalışma zamanı hatası demektir.
//********************************************************************
   // Try-Catch-Finally ve Mantıksal Hatalar
   // Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.

   // try{ Hataya sebebiyet verme ihtimali olan kod }
   
   // catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır}
   
   // finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }

   // Örnek:
   
   // try
   // {
   //     int a = int.Parse(Console.ReadLine());
   
   //     int b = int.Parse(Console.ReadLine());
   
   //     int c = a+b;
   
   //     Console.WriteLine(c);
   // }
   // catch(Exception ex)
   // {
   //     Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
   // }
   // finally
   // {
   //     Console.WriteLine("İşlem tamamlandı.");
   // }
   // Yukarıdaki örnekte console dan alınan string ifade int.Parse metodu ile integer a dönüştürülüyor. Ama Console dan girilen veri sayıya dönüştürülebilen bir string olmayabilir. Bu durumda bu kod hataya düşecektir. try catch bloğu içerisinde alınması gerekir.

   // Uygulama geliştirirken bu tarz hataya neden olabilecek noktaları yakalıyor olmak gerekiyor. Bunun için de kod üzerinde zaman geçirmek ve düşünmek gerekiyor. Hızlıca kodu yazıp geçmek doğru bir yaklaşım değildir. Yazdığımız kod bloğunun açıklarını düşünmemiz ve bu açıklar için önlemler alıyor olmamız gerekiyor.
//*******************************************************************************************
   //***Debugging,Watch And Variables Windows(Hata Ayıklama, İzleme ve Değişkenler Pencereleri):
   //VsCode da line (satır) numaraların oraya kırmızı nokta koyabiliriz  bu noktalara breakpoint noktası denilir, kod çalışırken breakpoint'in bulunduğu line(satır)'a geldiğinde o satırdaki kodu çalıştırmadan durur ve bekler.
   //expression:ifade,ibare,ifade etme
   