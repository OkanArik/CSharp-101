using System;


    namespace Type_Conversion
    {
        class Program
        {
            public static void Main(string[] args)
            {
               //*****Type Conversion(Tip Dönüşümü)***** 
               //2 tip dönüşüm vardır:
               //(1)Implicit Conversion(Bilinçsiz Dönüşüm)
               //(2)Explicit Conversion(Bilinçli Dönüşüm)


               //*****(1)Implicit Conversion(Bilinçsiz Dönüşüm)*****
               Console.WriteLine("*****Implicit Conversion(Bilinçsiz Dönüşüm)*****");
               byte byt=5;
               Console.WriteLine("byt:{0}",byt);
               sbyte sbyt=30;
               Console.WriteLine("sbyt:{0}",sbyt);
               short shrt=10;
               Console.WriteLine("shrt:{0}",shrt);

               int i=byt+sbyt+shrt;//Burada integer(int) veri tipinin bellekte kapladığı alan yani kapasitesi, byte,sbyte ve short veri tiplerinin bellekte kapladığı alanlardan yani kapasitelerinden daha fazla olduğundan; byte,sbyte ve short veri tiplerindeki değişkenlerde bulunan verileri integer(int) veri tipindeki değişkene atarken herhangi bir dönüşüm kodu yazmamıza gerek kalmadan atadık ve kendiliğinden integer veri tipine dönüşerek atandılar.Bu işleme implicit conversion yani bilinçsiz dönüşüm denir.Eğer integer veri tipindeki değişkene atanan verilerin bulunduğu değişkenlerden birinin veri tipinin bellekte bapladığı alan yani kapasitesi integer veri tipinin bellekte kapladığı alandan yani kapasitesinden büyük olsaydı o zaman implicit conversion yapamazdık , hatayla sonuçlanırdı.
               Console.WriteLine("i=byt+sbyt+shrt:{0}",i);

               long lng=i;
               Console.WriteLine("lng:{0}",lng);


               float flt=lng;
               Console.WriteLine("flt:{0}",flt);

               string strng="Okan";
               Console.WriteLine("strng:{0}",strng);
               char chr='a';
               Console.WriteLine("chr:{0}",chr);
               object objct=strng+chr+flt;
               Console.WriteLine("objct:{0}",objct);

               //*****Explicit Conversion*****
                 //C Sharp'ın kendi kendi yapamadığı bizim Convert veya Parse kullanarak dönüşümü compiler'a söyleyerek yaptırdığımız dönüşümlerdir.
                 //Compiler:Derleyici
                 Console.WriteLine("*****Expilicit Converison*****");

                 int i1=4;
                 byte byt1=Convert.ToByte(i1);//byt1 adında byte veri tipinde tanımladığımız değişkene, i1 adında integer(int) tipindeki değişkenimizde bulunan veriyi atamak için excplicit coversion(bilinçli dönüşüm) yapmak durumundayız çünkü int veri tipinin kapasitesi , byte veri tipinin kapasitesinden büyüktür.Burada integer veri tipindeki i1 değişkenindeki veriyi Convert.ToByte(i1) kodunu yazarak byte veri tipine dönüştürdük ve byte veri tipindeki byt1 adındaki değişkene atadık bu dönüşümede excplicit conversion yani bilinçli dönüşüm denmektedir.
                 Console.WriteLine("byt1:{0}",byt1);

                 int i2=100;
                 byte byt2=(byte)i2;
                 Console.WriteLine("byt2:{0}",byt2);

                 float flt2=10.3f;
                 byte byt3=(byte)flt2;
                 Console.WriteLine("byt3:{0}",byt3);//Burada flt2 adında float veri tipindeki değişkendeki veriyi byte veri tipinde dönüştürürek byt3 adında byte veri tipindeki değişkene atadık bu dönüşüme excplicit conversion yani bilinçli dönüşüm denir.Bu dönüşüm sırasında 10.3 reel sayısı byte veri tipine dönüştürülürken 10 şeklinde yuvarlanarak dönüşmüştür ve veri kaybı yaşanmıştır.Dönüşümlerde veri kaybı yaşanabilir bu göz önünde bulundurulmalıdır.


                 //***ToString Methodu : Bu method aldığı veriyi string veri tipine dönüştürür.BU method ile explicit conversion yani bilinli dönüşümler yaparız.
                 Console.WriteLine("***ToString Methodu : Bu method aldığı veriyi string veri tipine dönüştürür.");

                 int i3=6;
                 string strng1=i3.ToString();
                 Console.WriteLine("strng1:{0}",strng1);
              
                 float flt3=12.5f;
                 string strng2=flt3.ToString();
                 Console.WriteLine("strng2:{0}",strng2);
                 decimal dcml=Convert.ToDecimal(strng2);
                 Console.WriteLine("dcml:{0}",dcml);
                 float flt4=(float)dcml;
                 Console.WriteLine("flt4:{0}",flt4);

                 //***System.Convert Sınıfı:Bu sınıfın methodlarıyla excplicit conversion yani bilinçli dönüümler yaparız.
                 Console.WriteLine("***System.Convert Sınıfı");

                 string s1="10",s2="20";//Bir satırda string veri tipinde s1 ve s2 adlarında iki adet değişken tanımladık ve değerlerini atadık.
                 int number1, number2;//Bir satırda integer(int) veri tipinde number1 ve number2 adlarında integer veri tipinde iki adet değişken tanımladık.
                 int sum;
                 number1= Convert.ToInt32(s1);
                 number2= Convert.ToInt32(s2);
                 sum=number1+number2;
                 Console.WriteLine("sum:{0}",sum);

                 //sum: toplam
                 //number:sayı

                 //***Parse:Parse methodu string ifadeleri dönüştürmek için kullanılır.
                   //Parse methodunu ayrı bir fonksiyon(method) oluşturarak örneklendireceğiz ve bu methodu main methodda çağırarak çalıştıracağız.
                   Console.WriteLine("***Parse:");
                   Program instance =new Program ();//Program class'ının bir örneğini(nesnesini,misalini,instance'ını) yarattık yani Program class'ını örnekledik ve bu örnekleme(nesne) üzerinden main method içerisinden Program class ındaki erişilebilir olarak yaptığımız methodlara erişebiliriz.
                   instance.ParseMethod();//Program class ının instance adında yarattığımız nesnesi(örneği) üzerinden ParseMethod methodumu çağırdım yani çalıştırdım(eriştim).



                   StaticGosterim();//Burada Program class'ının yarattığımız nesnesi(örneği) üzerinden değil de direk olarak StaticGosterim methofuna eriştik.Bunu sağalayan şey StaticGosterim methodunu static olarak tanımlamamızdır.Static olarak tanımladığımız methodlara erişim için bulunduğu sınıfın nesnesini yaratmak gerekmez.

            }
            
            public  void ParseMethod()
            {
                string text1="10";
                string text2="10,25";
                int numeral;
                double double1;
                //text:metin
                //numeral:rakam


                numeral=Int32.Parse(text1);//Parse methodu string ifadeleri dönüştürmek için kullanılır ve her zaman Parse() ifadesindeki parantezin içerisi string ifade alır.Burada string veri tipindeki text1 adındaki değişkendeki veriyi Int32.Parse(text1) koduyla integer veri tipine dönüştürdük ve integer veri tipindeki numeral adındaki değişkene atadık.
                Console.WriteLine("numeral:{0}",numeral);
                double1=double.Parse(text2);
                Console.WriteLine("double1:{0}",double1);




            }


            public static void StaticGosterim()
            {
                //Komut bloğu
                Console.WriteLine("StaticGosterim methoduna eriştiniz.");
            }
        }
    }
//********************************************************************
//*****Type Conversion(Tip Dönüşümü)*****
   //2 tip dönüşüm vardır:
   //(1)Implicit Conversion(Bilinçsiz Dönüşüm)
   //(2)Explicit Conversion(Bilinçli Dönüşüm)
//*****Implicit Conversion(Bilinçsiz dönüşüm)*****
   //Bilinçsiz dönüşüm düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemidir.Bizim burada herhangi bir şey yapıyor olmamıza gerek kalmıyor.Bir dönüşüm kodu ve benzeri herhangi bir şey yapıyor olmamıza gerek yok,bu dönüşüm kendiliğinden yapılabilmektedir.
//********************************************************************
   //    Tip Dönüşümleri
   // Bir değişken tanımlaması yaptığımızda bellekten o değişkenin    tipine bağlı olarak bir alan tesis etmiş oluruz. Dolayısıyla    tanımladığımız bu değişkene farklı veri tipinde bir değer atanması bellekte işlerin karışmasına neden olabilir.
   
   // Çoğu zaman uygulama yazarken farklı veri tipleri ile çalışmak    durumunda kalabiliriz. Bellekte işleri yoluna koyabilmek için bu tip durumlarda tip dönüşümü yapmamız gerekir.
   
   // Tip dönüşümleri 2 şekilde yapılabilir.
   
   //(1)Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
   //(2) Explicit Conversion (Bilinçli ya da açık dönüşüm)
   //(1)Implicit Conversion
   // Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene    atanmasıdır. Hedef değişkenin veri tipi bellekte yeterli alana sahip olacağından, bu dönüşümde bir veri kaybı söz konusu olmayacaktır.Dolayısıyla bu dönüşüm kendiliğinden yapılabilir.
   
   // Örnek:
   
   // float a; int b = 25; a = b;
   // Örnek:
   
   // short x = 10; int y; y = x;
   // Yukarıdaki örnek sorunsuz çalışır. Çünkü float integer'a, integer da short veri tipine göre daha büyük sayıları saklayabiliyor.
   
   //(2)Explicit Conversion
   // Bu yöntemde dönüşümleri developer'ın yapıyor olması gerekiyor. Dönüşüm için farklı yöntemler mevcut.