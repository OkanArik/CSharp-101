//***********************************************
   //SDK:Software Development Kit:Yazılım Geliştirme Kiti(Ortamı)
//***********************************************
using System;


   namespace MainMethodu
   {
       class Program
       {
           public static void Main(string[] args)
           {
                Console.WriteLine("Hello World!");//Burada Console a Hello World! verisini yazdırdık.
                Console.Write("Enter your name:");//Burada Console a İsminizi Giriniz: verisini yazdırdık.
                string name=Console.ReadLine();// string data_type(veri_tipi) ında name(isim) adında bir variable(değişken) tanıladık ve Console dan okunacak değeri assign(atamak) ettik.
                Console.WriteLine(name);//name variable ını console yazdırdık.
                Console.Write("Enter your surname:");
                string surname=Console.ReadLine();
                Console.WriteLine("Your name and surname: "+name+" "+surname);
           }
       }
   }

//**************************************************
   //Console programlama .NET kullanarak oluşturabileceğimiz proje çeşitlerinden birtanesidir ve C# ile alakalı bu derslerimizde UI(User Interface=Kullanıcı Arayüzü) olarakta console'u bir araç olarak kullanacağız.
   //Debug:Hata Ayıklama
   //Developer:Geliştirici
   //Folder:Klasör
   //File:Dosya
   //CMD:CMD, İngilizcede komut anlamına gelen command kelimesinin kısaltmasıdır. Komut istemi ya da bizim burada kullanacağımız hali ile CMD, Windows işletim sistemlerinin komut satırı yorumlayıcısı aracılığıyla gerçekleştirilir. Yalnızca Windows işletim sisteminde kullanılan lokal bir uygulamadır.Komut satırı uygulaması olarak da bilinen bu kodlar, Windows işletim sistemini kullanan cihazlarda bulunan bir kod yazma konsoludur. Ayrıca bu konsol içerisine çeşitli kodlar yazarak bilgisayarınızda bulunan donanımların ayarları gibi çok sayıda bilgiye ulaşabilir veya hata kodları alabilirsiniz.
   //Command Line=Komut Satırı
//**************************************************
   //CMD de veya herhangi bir terminalde bu sers için oluşturduğumuz dosyaya(folder) erişip ,dotnet new console(dotnete bana yeni bir proje ver ve tipide console olsun dedik)komutu ile bu console uygulamamızı(application) yarattık.bin ve obj adında ikitane folder oluşturdu consle application, bunlar runtime da oluşturulan dosyalar için debug file ların tutulduğu folder lar olarak düşünülenilir. csproj uzantısı ile benim içinde oluşturuduğum folder ın adında bir file oluşturdu.csproj isimli file benim projemle aynı isimde.Default(varsayılan) olarak program.cs adında bir file oluşturdu bana console application.Bu console application için üretilen ana dosyadır.
   //***********************************************
   //csproj uzantılı file ın içeriğini inceleme:
   //İçeriği:

//<Project Sdk="Microsoft.NET.Sdk">//Projemin software development kitim belirtilmiş

//   <PropertyGroup>
//     <OutputType>Exe</OutputType>//Bu projenin çıktısının tipinin çalıştırılabilir uzantı exe uzantılı olduğunu belirtmiş 
//     <TargetFramework>net6.0</TargetFramework>TargetFramework (Hedef Yazılım İskeleti) olarakta net6.0 olduğunu belirtmiş
//     <RootNamespace>_3_MainMethodu_NamesapceKavramı_SystemUsingDirektifleri_Run</RootNamespace>//Buradada RootNamespace(kök dizin isim uzayı) imi belirtmiş
//     <ImplicitUsings>enable</ImplicitUsings>
//     <Nullable>enable</Nullable>
//   </PropertyGroup>

// </Project>

//**************************************************
   //Framework:Yazılım iskeleti:Bilgisayar programlamada yazılım iskeleti, yazılım çerçevesi ya da yazılım çatısı, standart fonksiyonların hazır olarak sunulduğu ancak programcı tarafından bu fonksiyonlardan arzu edilen kısımların ek kodlarla istenildiği şekilde güncellenebildiği sistemlerdir.
//**************************************************
   //namespace:isim uzayı
   //C# NameSpace Kavramı :Namespace'in Türkçe karşılığı isim uzayı dır.Programcılar için anlamı ise kütüphanelerdir.Ancak c sharp namespace kavramı sadece c sharp diline özgü bir şey değildir.Tüm programlama dillerinde var olan bir kavramdır.Namespace'ler programcıların işlerini kolaylaştırmak için üretilmişlerdir.Belirli başlıklar altına giren kodların toplandığı kütüphanelerden(namespace'lerden) hangisini kullanacaksak onu projemize import(içe aktarım) etmemiz gerekmektedir.Bu kütüphaneleri projemize import edebilmek için using anahtar sözcüğü(keyword) kullanırız.
//***************************************************
   //Root:Kök Dizin
//***************************************************
   //Program.cs file'ının incelemesi:
   //içeriği:


   //using System;//Burada projemize System namespace ini prjoemize import etmiş


   //namespace MainMethodu//MainMethodu adında namespace imiz yartmış
   //{
       //class Program//Program adında class ımızı yaratmış
       //{
           //public static void Main(string[] args)//public erişim_belirteçli static void geridönüş_tipli Main adında method yaratmış
           //{
               //Console.WriteLine("Hello Worl!");

           //}
       //}
   //}
//******************************************************
   //Main methodu yakından inceleyim(Main methoddan kastımız Main isimli methodumuz):
   //Main Methodu= public static void Main(string[] args)
   //Bir programın başladığı ve bittiği yer gibi düşünülebilir.DOTNET te bir console application çalıştırdığımızda ilk çalışaçak olan satır main'in ilk satırı, son çalışacak olan satırda main'in son satırıdır.Yani main ana fonksiyondur.Main methodu default(varsayılan) olarak public(genel,umumi)'tir.Pubic bie erişim_belirtecidir.Kısaca bahsedecek olursak main methodu public yaparak diyoruz ki bu method her yerden erişilinebilir olsun ben bu methodu kısıtlamıyorum diyoruz.Static keyword(anahtar kelime,anahtar sözcük) ile de main methoda bir nesnesi(örneğini,instance'ını) yaratılmadan ulaşılabilinmesini sağlıyor ve söylüyoruz.Void'de bu main methodun geridönüş_tipidir.Void geridönüş_tipi keyword lede bu methodun hiç bir şey geri dönmüyeceğini belirtiyoruz.Örneğin int(integer) geridönüş_tipinide kullanabilirdim ve bu method çalıştırıldığında çalıştırıldığı yere çıktı olarak integer tipinde geri dönecek olurdu tabiki eğer int yaparsam geridöüş_tipi komutlar bloğunun en alt satırında dönecek int value(değer)'yı return (dönüş,geri dönüş) yapmam gerekmektedir.

   //string[] args incelemesi:burada main methodun string dizi lipinde bir argüman listesi aldığı belirtişmiş.Bu komut satırı argümanlaranı içeriye almak için kullanılıyor.Komut satırından bu programı çalıştırırken bir input vermek istiyorsak, string[] args ifadesiyle bunları içeriye alabiliriz.

   //Console.WriteLine("Hello World!"); incelemesi:Burada Console aslında System namspace'i altında bir sınıftır ve WriteLine da bu sınıfın altında bir methoddur.Using keyword'ü ile projemize import ettiğimiz System namespace'i altındaki Console sınıfı altında bulunan WriteLine methoduna string tipindeki Hello World! verisini gönderiyoruz ve bu method bu veriyi ekrana yazdırıyor.Eğer System i import etmezsek yani using Sytem; satırını kaldırırsak o zaman Hello World! verisini console yazdırmak için System.Console.WriteLine("Hello World!"); şeklinde yazmamız gerekir.Yani System namespacesini projemize import etmediğimiz için önce WriteLine methoduna erişebilmek için ilk olarak System namespacesine sonra Console classına en son WriteLine method'una erişmek durumunda kalırız.Bu şekilde yapmak yerine using keyword'ü ile System namespace kütüphanesini projemize import ederiz ve içerisindeki method ve classlara kolayca erişim sağlarız.

//******************************************************
   //Customize:özelleştirme
   //Şimdi değineceğimiz nokta console applicationımızı çalıştırmak istediğimizde ilk çalıştırma için bize VsCode: To customize Run and Debug create a launch.json file(run ve debug'ı özelleştirmek için bir tane launch.json dsoyası yarat) dicek VsCode.Bu yazıya tıkladığımızda VsCode bzizim için default(varsayılan) olarak oluşturacak fakat bizim ona hangi environment(ortam)'ta çalıştığımızı söylememiz gerekir ve bizim environment'ımız .NET Core.
//******************************************************
   //launch.json file'ı inceleme:
   //içeriği:
//    {
//     "version": "0.2.0",
//     "configurations": [
//         {
//             // Use IntelliSense to find out which attributes exist for C# debugging
//             // Use hover for the description of the existing attributes
//             // For further information visit https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md
//             "name": ".NET Core Launch (console)",
//             "type": "coreclr",
//             "request": "launch",
//             "preLaunchTask": "build",
//             // If you have changed target frameworks, make sure to update the program path.
//             "program": "${workspaceFolder}/bin/Debug/net6.0/3-MainMethodu_NamesapceKavramı_SystemUsingDirektifleri_Run.dll",
//             "args": [],
//             "cwd": "${workspaceFolder}",
//             // For more information about the 'console' field, see https://aka.ms/VSCode-CS-LaunchJson-Console
//             "console": "internalConsole",
//             "stopAtEntry": false
//         },
//         {
//             "name": ".NET Core Attach",
//             "type": "coreclr",
//             "request": "attach"
//         }
//     ]
// }
    //configurations:yani run ve debug yaparken ihtiyaç duyduğu tüm settings(ayarlar) burada.
    //"program" :Bu kısıma bu programın çalıştırılabilir çıktılarının olduğu .dll uzantılı file'ın bulunduğu dizini veririz buraya.
    //"console":Bu kısım default olarak internalConsole olarak gelir.Bu programı çalıştırdığımızda yazmak için kullandığı yerin Debug Console olduğunu belirtiyor.!Debug Console dan veri alamayız!.Bu kısımda üçtane sçeneğimiz vardır.internalConsole(dahili konsol,Debug Console'dur),integratedTerminal(VsCode'a entegre yani VsCode'da açılan Console(terminal)'dur)ve externalTeminal(harici terminal yani VsCode dışında ayrı şekilde kendi başına açılcak olan Terminaldir.).Consoledan veri alacaksan(okuyacaksak) integratedTerminal veya externalTerminal olarak belirlemeliyiz burasını.

   
      
   

   
   
   


