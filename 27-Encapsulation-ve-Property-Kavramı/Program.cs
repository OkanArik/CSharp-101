using System;


    namespace Encapsulation
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //**************************************************************************************************
                //Bu dersimizde encapsulation'ı konuşacağız yani kapsülleme işlemini konuşacağız.Daha öncede bahsettiğimiz gibi C# object oriented programming dilidir.Encapsulation kavramıda OOP 'nin temel kavramlarından biridir.Encapsulation bir nesnenin bazı özelliklerini veya işlevlerini, methodlarını diğer class'lardan ve diğer nesnelerden korumak anlamına geliyor.Bir field'ımı korumak için sadece bulunduğu class'tan erişilinebilir yapmak için private yaparız.Bu field'a başka bir sınıfta field'ımın bulunduğu sınıfın nesne'si oluşturulduğunda erişilenemez olur.Peki ben bu field'a erişmek istiyorum ama koşullu şekilde erişilinsin istiyorum ,kontrollü olsun istiyorum , field'a atanmak istenen değer istemediğim bir değerse bir exception(hata) fırlatmak istiyorum gibi durumlar için tamda bu noktada encapsulation kavramı ortaya çıkıyor.Propertyler yardımıyla encapsulation kavramını kullanarak sınıfın üyelerinin, fieldlarının değişimini engelliyebiliriz ,koruyabiliriz ve ya bunu kontrol altına alabiliriz dolayısıyla bunun içinde property'leri kullanırız.Property'ler get ve set'lerden oluşuyor bunu getter ve setter olarakta duyabilirsiniz.Get kısmında o property'nin private field'ının değerini get eden , set kısmında da o property'nin private field'ına bir şey set eden bir method gibi düşünebilirsiniz.
                //**************************************************************************************************

                Ogrenci ogrenci=new Ogrenci();
                ogrenci.Isim="Okan";
                ogrenci.Soyisim="Arık";
                ogrenci.OgrenciNo=393;
                ogrenci.Sinif=12;
 
                ogrenci.SinifAtlat();
                ogrenci.OgrenciBilgileriniGetir();

                ogrenci.SinifDusur();
                ogrenci.OgrenciBilgileriniGetir();

                Ogrenci ogrenci1=new Ogrenci("Deniz","Arda",256,1);
                ogrenci1.SinifDusur();
                ogrenci1.SinifDusur();
                ogrenci1.OgrenciBilgileriniGetir();

            }
        }

        class Ogrenci
        {
            private string isim;//-->field
            private string soyisim;//-->field
            private int ogrenciNo;//-->field
            private int sinif;//-->field

            public string Isim { get => isim; set => isim = value; }//-->property
            public string Soyisim //-->property
            { 
                get  { return soyisim;} 
                set  {soyisim = value;} 
            }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }//-->property
            public int Sinif//-->property
            { 
                get => sinif; 
                set 
                {   
                    if(value<1)
                    {
                        Console.WriteLine("Sınıf En Az 1 Olabilir!");
                    }
                    else
                    sinif = value; 
                }
            }

           public Ogrenci(){}//-->Constructor

            public Ogrenci(string isim, string soyisim = null, int ogrenciNo = 0, int sinif = 0)//-->overload constructor
            {
                Isim = isim;
                Soyisim = soyisim;
                OgrenciNo = ogrenciNo;
                Sinif = sinif;
            }

            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("*****Öğrenci Bilgileri*****");
                Console.WriteLine("Öğrenci Adı     :{0}",this.Isim);
                Console.WriteLine("Öğrenci Soyadı  :{0}",this.Soyisim);
                Console.WriteLine("Öğrenci No      :{0}",this.OgrenciNo);
                Console.WriteLine("Öğrenci Sınıfı  :{0}",this.Sinif);
            }

            public void SinifAtlat()
            {
                this.Sinif+=1;
            }

            public void SinifDusur()
            {
                this.Sinif-=1;
            }

        }
    }
//***********************************************************************************
//Encapsulation Kavramı ?
//C#'ın %100 nesne yönelimli bir dil olduğundan bahsetmiştik. Encapsulation yani Kapsülleme kavramı bir özeliği başka sınıflardan saklamak yada korumaktır.
//Örneğin siz bir property yani özellik tanımı yaptınız ve diğer sınıflar içerisinden erişilsin ama sadece okumak için erişilsin değeri dışarıdan değiştirilemesin istiyorsunuz bunu kapsülleme yaparak sağlayabilirsiniz. Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.
//Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur. Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir. Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get) ve yeni bir değer(Set) atamaya olanak sağlar.
//***********************************************************************************
  //Örnek bir property kullanımı aşağıdaki gibidir:
      // class Ogrenci
      // {
      //     private string name; //field
      //     public string Name //property
      //     {
      //         get { return name; }
      //         set { name = value; }
      //     }
      // }
//***********************************************************************************
//Yukarıda Ogrenci sınıfı içerisinde "name" isminde private bir field tanımı görüyorsunuz. Yani bu field'a sınıf dışında bir yerden erişilemez. Altındaysa "Name" isminde "name" field'ını geri döndüren Get metodu ve "name" field ına yeni değer atamasını yapabilen bir Set metodu barındıran bir property tanımı görüyoruz.
//Burda property tanımlayarak "name" field'ını sınıf dışından yapılabilecek bilinçsiz atamalardan koruduk. Public property nin set metodu içerisinde bu field'a atanabilecek verileri kontrol edebilir ve müdahale edebiliriz.
//***********************************************************************************
  //Aşağıdaki örnekte yaş olarak negatif bir değer atamasına engel olan property tanımını görebilirsiniz.
    // class Person
    // {
    //     private int age=0;
    //     public int Age
    //     {
    //         get { return age; }
    //         set {
    //             if (value > 0)
    //             age = value;
    //         }
    //     }
    // }
//***********************************************************************************

