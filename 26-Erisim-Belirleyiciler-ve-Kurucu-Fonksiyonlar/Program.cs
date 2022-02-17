using System;


    namespace Erisim_Belirleyiciler_ve_Kurucu_Methodlar
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Kurucu Methodlar:Kurucu methodlar bir sınıfın nesnesi oluşturulduğunda yani new ile yeni bir nesnesini oluşturduğumuzda arka planda otomatik olarak çalıştırılan methodlardır ve biz bunlara kurucu methodlar, yapıcı methodlar veya constructor methodlar diyoruz.Bir nesne oluşturduğumuzda başlangıç olarak otomatikmen arka planda yapılmasını istediğimiz işlemler var ise bunları kurucu methodlar içerisinde yaparız.
                //Constructor methodların isimleri mutlaka class ismiyle aynı olmalıdır , erişim belirleyicileri mutlaka public olmalıdır ,geri dönüş tipi parametresi yazılmaz yani yoktur ve parametre alabilir ,almayabilir veya bir kaç parametre alabilir.

//*************************************************************************************************
                Calısan calısan1=new Calısan();
                calısan1.ad="Ayşe";
                calısan1.soyad="Kara";
                calısan1.no=23425634;
                calısan1.departman="İnsan Kaynakları";
                
                Console.WriteLine("*****calısan1 bigileri*****");
                calısan1.CalısanBilgileri();

                Calısan calısan2=new Calısan();
                calısan2.ad="Deniz";
                calısan2.soyad="Arda";
                calısan2.no=25646789;
                calısan2.departman="Software Development";
                
                Console.WriteLine("*****calısan2 bigileri*****");
                calısan2.CalısanBilgileri();
//**************************************************************************************************              
                //Nesneye değer atama yani bir nesneyi ayağa kaldırma işlemini kurucu fonksiyona(methoda) yaptırcaz.
                Calısan calısan3=new Calısan("Okan","Arık",23456789,".NET Developer");
                Console.WriteLine("*****calısan3 bigileri*****");
                calısan3.CalısanBilgileri();

                Calısan calısan4=new Calısan("Ahmet","Cemal");
                Console.WriteLine("*****calısan4 bigileri*****");
                calısan4.CalısanBilgileri();

                //Kurucu methodu biz yazmasak bile ilk nesne tanımlandığında yani nesne ayağa kaldırırken arka planda default kurucu method çalışır veri verilere intial value olarak default değerleini atar.
            }
        }

        class Calısan
        {
            public string ad;//-->property
            public string soyad;//-->property

            public int no;//-->property

            public string departman;//-->property
//****************************************************************************************************************
            public Calısan(string AD,string SOYAD,int NO,string DEPARTMAN)//Kurucu methodum.
            {
                this.ad=AD;//Burada this bu class'ın elemanı demek.
                this.soyad=SOYAD;
                this.no=NO;
                this.departman=DEPARTMAN;
            }
//****************************************************************************************************************
            public Calısan(string AD,string SOYAD)//Kurucu methodumu overload ettim bunun sayesinde sadece ad, soyad vererek nesne yaratabilirim.
            {
                this.ad=AD;//Burada this bu class'ın elemanı demek.
                this.soyad=SOYAD;
            }
//****************************************************************************************************************
            public Calısan(){}//Kurucu methodumu overload ettim.Bunu yapmamnın sebebi yukarııdaki calısan1 ve calısan2 nesne atamalarının calışmaya devam etmesini sağlamak.
//****************************************************************************************************************


            public void CalısanBilgileri()//-->Method
            {
                Console.WriteLine("Çalışanın adı:{0}",ad);
                Console.WriteLine("Çalışanın soyadı:{0}",soyad);
                Console.WriteLine("Çalışanın numarası:{0}",no);
                Console.WriteLine("Çalışanın departmanı:{0}",departman);

            }
        }
    }
//****************************************************************************************************************
//refactoring:kod düzenlenmesi, yazılan bir kodun zamanla değiştirilerek optimize edilmesi.
//****************************************************************************************************************
//Constructor Kavramı:
//Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
//Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:
  // 1-->Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
  // 2-->Public olarak bildirilmeleri gerekir.
  // 3-->Geri dönüş değerleri yoktur.
//Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz.
//******************************************************************************************************************
//Varsayılan Kurucu Metot:
//Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.
//Default constructor'ın görevi sınıfın içerisindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.
//******************************************************************************************************************

