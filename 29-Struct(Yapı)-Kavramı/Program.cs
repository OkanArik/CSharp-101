using System;



    namespace Struct_Kavrami
    {
        class Program
        {
            public static void Main(string[] args)
            {
               //Bu dersimizde struct'ları konuşacağız.Struct'lar yapısı itibari ile sınıflara çok benzerler.Structların bir diğer adı aslında Türkçe 'side yapılardır.Aynı sınıflar gibi tanımlanabilirler, kebndi fieldları ,propertyleri ,methodları vardır.Yapıcı fonksiyonları vardır.Buna karşın bazı temel farklarda var structlar ile sınıflar arasında.Bu farklar bunları kullanırken çok önemlidir.Özellikle performans noktasında bir çok farkları vardır.Sınıflar referans türündedir.C# iki tip vardır bunlar value type (int ,long vb.), referance type(string ,class vb.).Referance type değişkenler belleğin heap bölgesinde tutulmaktadır.Value type değişkenler belleğin stack bölgesinde tutulur.Referans tiplerinin sahip olduğu veriler belleğin heap bölgesinde tutulurken ,referansın adı aslında stack bölgesinde tutuluyor ve heap bölgesinde verilerin bulunduğu adresi işaret ediyor.Value type da ise direk belleğin stack bölgesinde verileri tutar.Struct'lar value type'dır.Class'lar ise referance type'dır.
               //****************************************************************************************************

               Dikdortgen alanhesabı=new Dikdortgen();//Class ları kullanmak için bir tane nesnesini(instance) oluştururuz.Burada yaptığımız budur.//class ta property lerini atamadan alanhesaplamayı çağırsak bile bize kızmaz ve initial value ile default olarak çağırır ve devam eder.
               alanhesabı.KisaKenar=5;
               alanhesabı.UzunKenar=10;
               alanhesabı.EkranaYazdır(alanhesabı.AlanHesapla());
               //****************************************************************************************************
               Dikdortgen_Struct dikdortgen_Struct=new Dikdortgen_Struct ();//Dikdortgen_Struct struct'ının dikdortgen_Struct adında nesnesini yarattık.
               dikdortgen_Struct.KisaKenar=5;
               dikdortgen_Struct.UzunKenar=10;
               dikdortgen_Struct.EkranaYazdır(dikdortgen_Struct.AlanHesapla());
               //****************************************************************************************************
               Dikdortgen_Struct dikdortgenStruct;//Dikdortgen struct'ın dikdortgenStruct adında nesnesini yarattık.Bu nesne yaratmada intial değerleri gidip kendisi atayamaz nesne için yani bu kullanım için struct'ın  kurucusu çalışmaz.Verileri bizim nesne üzerinden ulaşıp assign etmemiz gerekmektedir.
               dikdortgenStruct.KisaKenar=3;
               dikdortgenStruct.UzunKenar=5;
               dikdortgenStruct.EkranaYazdır(dikdortgenStruct.AlanHesapla());


            }
        }
//*******************************************************************************************************************
        class Dikdortgen
        {  
            //Class'ların bir default constructor' var ve biz constructor tanımlayarak onu ezebiliyoruz.
            public int KisaKenar;//property

            public int UzunKenar;//property

            public long AlanHesapla()//Method
            {
                return this.KisaKenar*this.UzunKenar;
            }

            public void EkranaYazdır(long item)//Method
            {
                Console.WriteLine("Class ile  dikdörtgenin alanı   :{0}",item);
            }

        }
//*******************************************************************************************************************

        struct Dikdortgen_Struct
        {
            //Struct'larda parametresiz constructor tanımlayıp default kurucuyu ezemeyiz, lakin parametreli kurucu tanımlayıp default kurucuyu ezebiliriz.
            public int KisaKenar;//property

            public int UzunKenar;//property


            public Dikdortgen_Struct(int kisaKenar, int uzunKenar = 0) //Constructor
            {
                KisaKenar = kisaKenar ;
                UzunKenar = uzunKenar ;
            }

            public long AlanHesapla()//Method
            {
                return this.KisaKenar*this.UzunKenar;
            }
            public void EkranaYazdır(long item)//Method
            {
                Console.WriteLine("Struct ile dikdörtgenin alanı   :{0}",item);
            }
            

        }
    }
//*******************************************************************************************************************
//Neden Struct'ları kullanmalıyım? veya Neden Class'ları kullanmalıyım?:
//Class'lar çok güçlü, referans türünde olması nedeniyle ,heapte tutulması nedeniyle performans açısından bize bazı yararlar sağlıyor ve büyük verilidir.
//Struct'lar value türünden olduğundan stackte tutulması açısından performan olarak bize hız avantajı sağlıyor.
//Şöyle bir uzman görüşü var :16 Byte a kadar olan verilerinizi saklamak için struct kullanmak daha uygunken , 16 Byte'dan daha büyük verilerinizi saklamak için class kullanıyor olmanız referans tipinin gücünü kullanıyor olmanız daha uygundur diyor.
//*******************************************************************************************************************
//Struct(Yapı) Nedir ?
//Struct'lar yani yapılar sınıflara çok benzerler. Struct ile yapıp sınıf ile yapamayacağız bir işlem yoktur diyebiliriz. Peki o halde struct yani yapılara neden ihtiyaç duyulur?
//Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa ve verileri kapsüllemek işinizi görecekse yapıları tercih edebilirsiniz.
//*******************************************************************************************************************
  //Yapıların özellikleri:
    //Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
    //Diğer struct yada sınıflardan kalıtım almazlar.
    //Interface'lerden kalıtım alabilirler.
    //new anahtar sözcüğü ile nesneleri yaratılabilir.
    //Sınıflar gibi metot, property ve field'lardan oluşurlar.
    //Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
    //Static üye barındırabilirler.
//*******************************************************************************************************************
   //Yapıların söz dizimi:
     //struct Ogrenci {
     //     public string Isim;
     //     public string Soyisim {get;set;}
     //     public static int OgrenciSayısı=0;
     // }
//*******************************************************************************************************************
     