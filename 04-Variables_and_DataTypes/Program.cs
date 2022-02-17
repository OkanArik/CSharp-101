using System;


    namespace Variables_and_DataTypes
    {
        class Program
        {
            public static void Main(string[] args)
            {
                int value;//value adında integer tipinde variable tanımladık.
                value=2;//value adında integer tipindeki variable ımıza 2 değerini assign(atamak) ettik.
                string variable="";//variable adında string tipinde variable(değişken) tanımladık ve boş değer assign(atamak) ettik.
                Console.WriteLine(value+"+"+variable);//value adındaki integer tipindeki değişkeni ve variable adındaki string tipindeki değişkeni console'a yazdırdık.
                string variable1=" ";//variable1 adında string tipinde bir değişken tanımladık ve değişkenimize bir white space(beyaz boşluk) atadık.
                Console.WriteLine(variable1=="");//Output(Çıktı):False
                
                //*****Tam Sayılar İçin Kullanılan Data Types(Veri Tipleri)*****
                byte b=5;//b adında ve byte tipinde değişken tanımladık ve içerisine 5 değerini atadık.Byte tipindeki değişkenler bellekte 1 Byte yer kaplar.byte:0 ile (2^8-1=255) arasındaki değerleri tutabilir.(alır).
                //***1 Byte=8 Bit ***Bit=Binary Digit=İkili Hane(Basamak) ***1 Bit içerisinde 1 veya 0 değerlerinden birisini tutar.
                Console.WriteLine("b: "+b);
                sbyte sb=6;//sb adında ve sbyte tipinde değişken tanımladık ve içerisine 6 değerini atadık.sbyte bellekte 1 Byte yer kaplar.sbyte:(-2^7=128) ile (2^7-1=127) arasındaki değerleri tutabilir.
                //***sbyte:signed byte
                Console.WriteLine("sb: "+sb);
                short shrt=22;//shrt adında short tipinde değişken tanımladık ve içerisine 22 değerini atadık. short tipindeki shrt değişkeni bellekte 2 byte yer kaplar.short:(-2^15) ile (2^15-1) arasında değer tutabilir.
                Console.WriteLine("shrt: "+shrt);
                ushort ushrt=23;//ushrt adındaki ushort tipindeki değişkenimiz bellekte 2 byte yer kaplar.ushort:0 ile (2^16-1) arasında değer alabilir(tutabilir).
                //***ushort=unsigned short
                Console.WriteLine("ushrt: "+ushrt);
                int i=3;//int tipindeki değişken bellekte 4 byte yer kaplar.int:(-2^31) ile (2^31-1) arasında değer alabilir.
                Console.WriteLine("i: "+i);
                Int16 i16=2;//Int16 tpindeki değişken bellekte 2 byte yer kaplar.Int16:(-2^15) ile (2^15-1) arasında değer alabilir.
                Console.WriteLine("i16: "+i16);
                Int32 i32=12;//Int32 tipindeki değişken bellekte 4 byte yer kaplar.Int32:(-2^31) ile (2^31-1) arasında değer alabilir.
                Console.WriteLine("i32: "+i32);
                Int64 i64=-122;//Int64 tipindeki değişken bellkete 8 byte yer kaplar.Int64:(-2^63) ile (2^63-1) arasında değer alabilir.
                Console.WriteLine("i64: "+i64);
                long l=444;//long tipindeki değişken bellekte 8 byte yer kaplar.long:(-2^63) ile (2^63-1) arasında değer alabilir.
                Console.WriteLine("l: "+l);
                uint ui=8;//uint tipindeki değişken bellekte 4 byte yer kaplar.uint:0 ile (2^32-1) arasında değer alabilir.
                //***uint=unsigned integer
                Console.WriteLine("ui: "+ui);
                ulong ul=233;//ulong tipideki değişken bellekte 8 byte yer kaplar.ulong:0 ile (2^64-1) arasında değer alabilir.
                //***ulong=unsigned long
                Console.WriteLine("ul: "+ul);

                //*****Reel Sayılar İçin Kullanılan Veri Tipleri*****
                float fl=5.1F;//fl adında float tipinde değişken tanımladık ve 5.1 değerini atamak için 5.1F şeklinde atama(assign) yaptık.Bunun sebebi C# ortamında noktalı sayıların varsayılan değeri double'dır. Biz virgüllü bir sayıyı float olarak tanımladığımızı sonuna gerekli eklemeyi yaptıktan sonra belirtiriz.float tipindeki değişken bellekte 4 byte yer kaplar.
                Console.WriteLine("fl: "+fl);
                double db=5.2;//double tipindeki değişken bellekte 8 byte yer kaplar.
                Console.WriteLine("db: "+db);
                decimal de=-2.32M;//de adında decimal tipinde değişken tanımladık ve içerisine -2.32 reel sayısını -2.32M yazarak atadık.Bunun sebebi C# ortamında noktalı sayıların varsayılan değeri double'dır.decimal tipindeki değişken bellekte 16 byte yer kaplar.
                Console.WriteLine("de: "+de);

                //*****Tek Karakter Tutmak İçin Kullanılan Veri Tipleri*****
                char ch='a';//ch adında char tipinde değişken tanımladık ve a karakterini 'a' şeklinde yazarak içerisine atadık.char tipindeki değişken bellekte 2 byte yer kaplar.
                Console.WriteLine("ch: "+ch);
                char ch1='2';
                Console.WriteLine("ch1: "+ch1);
                //***char:character:karakter

                //*****String*****
                string str="Hello World!";//string tipindeki değişken bellekte sınırsız yer kaplar.Bundan dolayı string tipindeki değişkenler ile işlem yapmak bellekte mailiyetli işlerdir.Eğer tek karakter atanacaksa string tipinde değişken tanımlamak yerine char tipinde değişken tanımlayarak işlem yapmak önemlidir.
                Console.WriteLine("str: "+str);

                //*****bool*****
                bool bl=true;//bl adında bool tipinde değişken tanımladık ve içerisine true değerini atadık.
                Console.WriteLine("bl: "+bl);
                bool bl1=false;//bl1 adında bool tipinde değişken tanımladık ve içerisine false değerini atadık.
                //***bool:boolean
                Console.WriteLine("bl1: "+bl1);

                //*****DateTime Kütüphanesi*****
                DateTime dt=DateTime.Now;//dt adındaki DateTime tipindeki değişkene DateTime.Now(çalıştırdığımız anın saat ve tarihi) değerini atadık.
                Console.WriteLine("dt(DateTime.Now): "+dt);

                //*****object*****
                object o1='x';//o1 adında object türünde değişken tanımladık ve içerisine x verisini atadık(assign).
                Console.WriteLine("o1: "+o1);
                object o2="Hi";
                Console.WriteLine("o2: "+o2);
                object o3=4;
                Console.WriteLine("o3: "+o3);
                object o4=4.3;
                Console.WriteLine("o4: "+o4);
                object o5=true;
                Console.WriteLine("o5: "+o5);
                //***object : Yukarıda görüldüğü gibi object tipinde tanımladığımız değişkene her türden veri atayabiliriz yani her türden veriyi tutabilir.Tüm değişken türleri object türünden türetilmiştir, yani object türü kapsayıcı,genel bir türdür.Object'i aslında üst tür gibi düşünebiliriz.

                //*****string ifadeler*****
                string str1= string.Empty;//str1 adında string tipindeki değişkenimize string.Empty ile boş değer ataması yaptık.
                //***string.Empty=""=null
                Console.WriteLine("str1: "+str1);
                str1="Okan Arik";
                string name="Okan";
                string surname="Arik";
                Console.WriteLine(name+" "+surname);

                //*****Integer Tanımlama Şekilleri*****
                int integer1=5;
                int integer2=3;
                int integer3=integer1*integer2;
                Console.WriteLine("{0}*{1}={2}",integer1,integer2,integer3);

                //*****Boolean*****
                bool boolean1=10<2;
                bool boolean2=10>2;
                Console.WriteLine("boolean1:{0}",boolean1);//Output:false
                Console.WriteLine("boolean2:{0}",boolean2);//Output:true

                //*****Variable Conversion(Değişken Dönüşümü)*****
                string str20="20";
                int integer20=20;
                string newValueString=str20+integer20.ToString();//integer20.Tostring() ile integer20'nin veri tipini stringe dönüştürdük.
                int newValueInteger1=integer20+int.Parse(str20);//Burada int.Parse(str20) ile str20'yi string tipinden integer tipine dönüştürdük.
                int newValueInteger=integer20+Convert.ToInt32(str20);
                Console.WriteLine("str20:{0}",str20);
                Console.WriteLine("integer20:{0}",integer20);
                Console.WriteLine("newValueString:{0}",newValueString);//newValueString:2020
                Console.WriteLine("newValueInteger:{0}",newValueInteger);//newValueInteger:40
                Console.WriteLine("newValueInteger1:{0}",newValueInteger1);//newValueInteger1:40
                //***Parse string veri tipinden integer veri tipine dönüşümde kullanılır ve dönüşüm yapacağımız string tipindeki değişkende sayı değilde başka ir veri varsa FormatException(Format Sıradışı Durumu(İstisna Durumu)(Kuraldışılık Durumu)) hatası alırız.

                //*****TryParse()*****
                //TryParse():Metodun kullanım amacı gönderilen değerin ilgili türe dönüşüp dönüşemeyeğini belirlemektir. TryParse metodu geriye bool tipinde değer döndürmektedir. Eğer parametre olarak gönderilen değer dönüştürülmek istenilen değere dönüşürse out parametresi ile gönderilen parametreye sonucu aktarmaktadır.
                int number=0;
                string str21="222";
                string str22="Okan";
                if (int.TryParse(str21,out number))
                {
                    Console.WriteLine("number:{0}",number);
                }
                else 
                {
                    Console.WriteLine("Integer veri tipine dönüştürmek istediğiniz string veri tipindeki str21 değişkeni, uygun formatta değildir!");
                }
                 if (int.TryParse(str22,out number))
                {
                    Console.WriteLine("number:{0}",number);
                }
                else 
                {
                    Console.WriteLine("Integer veri tipine dönüştürmek istediğiniz string veri tipindeki str22 değişkeni, uygun formatta değildir!");
                }

                //*****DateTime Kütüphanesi*****
                string datetime =DateTime.Now.ToString("dd.MM.yyyy");//Burada datetime kütüphanesinin DateTime.Now metdodu ile kodlarımızı çalıştırdığımız andaki tarih ve saati elde ederiz.DateTime.Now.ToString("dd.MM.yyyy") ilede veriyi string tipine dönüştürdük ve dönüştürürken sadece tarihi aldık ve bu veriyi gün.ay.yıl şeklinde alırken aralarına . koymasını söyledik.*d:day:gün,*M:Month:ay, *y:year:yıl 
                Console.WriteLine(datetime);
                string datetime1 =DateTime.Now.ToString("dd-MM-yyyy");//Burada datetime kütüphanesinin DateTime.Now metdodu ile kodlarımızı çalıştırdığımız andaki tarih ve saati elde ederiz.DateTime.Now.ToString("dd.MM.yyyy") ilede veriyi string tipine dönüştürdük ve dönüştürürken sadece tarihi aldık ve bu veriyi gün-ay-yıl şeklinde alırken aralarına - koymasını söyledik.*d:day:gün,*M:Month:ay, *y:year:yıl
                Console.WriteLine(datetime1);
                string hour=DateTime.Now.ToString("HH:mm");////Burada datetime kütüphanesinin DateTime.Now metdodu ile kodlarımızı çalıştırdığımız andaki tarih ve saati elde ederiz.DateTime.Now.ToString("HH:mm") ilede veriyi string tipine dönüştürdük ve dönüştürürken sadece saati aldık ve bu veriyi saat:dakika şeklinde alırken aralarına : koymasını söyledik.*H:Hour:saat,*m:minute:dakika
                Console.WriteLine(hour);
                string hour1=DateTime.Now.ToString("HH-mm");////Burada datetime kütüphanesinin DateTime.Now metdodu ile kodlarımızı çalıştırdığımız andaki tarih ve saati elde ederiz.DateTime.Now.ToString("HH:mm") ilede veriyi string tipine dönüştürdük ve dönüştürürken sadece saati aldık ve bu veriyi saat-dakika şeklinde alırken aralarına - koymasını söyledik.*H:Hour:saat,*m:minute:dakika
                Console.WriteLine(hour1);
                string hour2=DateTime.Now.ToString("HH-mm-ss");////Burada datetime kütüphanesinin DateTime.Now metdodu ile kodlarımızı çalıştırdığımız andaki tarih ve saati elde ederiz.DateTime.Now.ToString("HH:mm") ilede veriyi string tipine dönüştürdük ve dönüştürürken sadece saati aldık ve bu veriyi saat-dakika-saniye şeklinde alırken aralarına - koymasını söyledik.*H:Hour:saat,*m:minute:dakika,*s:second:saniye
                Console.WriteLine(hour2);
            }
        }
    }

//*********************************************************
   //Variables and Data Types(Değişkenler ve Veri Tipleri)
   //Variables(değişkenler): Variables bizim veri tutucularımız ,verilerimizi sakladığımız koddaki yapılarımız.Dolayısıyla her birinin bellekte bir karşılığı var.Bir değişken tanımladığımız zaman bellekten bir yer istemiş,yer elde etmiş oluyoruz bundan dolayı değişken tanımlarken doğru verileri doğru veri tiplerinde tutmak bellek kullanımı için önemlidir çünkü ilerleyen kod sürecinde performans sorunlarına veya hataya açık kodlar yazmamıza neden olabilir.Buradan yapacağımız çıkarım bir veriyi hangi veritipinde ve neden o veritipinde saklıyacağımızı biliyor olmamız ve değişken tanımlarken veri tiplerii bilinçli şekilde oluşturmak gerekmektedir.
//*********************************************************
   //Değişken tanımlarken dikkat edilmesi gereken kurallar(hususlar):
   //-Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
   //-Aynı kod bloğu içerisinde aynı değişken birden fazla tanımlanamaz.
   //-Değişken isimleri rakamlarla başlayamaz.
   //-Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
   //-Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
   //-Class namespace gibi özel isimler kullanılamaz.
   //-Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.
//*********************************************************
   //Değişken Nedir?:
   //Değişkenler bizim uygulama geliştirirken kullandığımız veri tutucularımızdır. Kullandığımız verinin tipine ve büyüklüğüne bağlı olarak doğru veri tipini seçiyor olmak önemli. Örneğin sadece tek bir karakter tutmaya ihtiyacımız varsa o veri için Char veri tipinizi tanımlamak yeterli olacaktır. String tipinde bir değişken kullanmak gereksizdir. Uygulamanın performansı açısından doğru veri tiplerine karar verebilmek önemlidir.

   //DEĞİŞKEN TANIMLAMA YAPISI:
   //Değişken tanımlama yapısı : (Değişken Türü/Variable Type) (Değişken Adı/Variable Name) = (Değeri/Value)
//*********************************************************
   //Compiler(Derleyici):Derleyici, yüksek seviye bir programlama dilinde (high-level programming language) yazılmış bir kaynak kodun, başka bir hedef dile veya bilgisayarın/işlemcinin anlayabileceği makine diline tercümesini yapan bir programdır.
   //Compile Time: Derleme Zamanı
   //Run Time: Çalışma Zamanı
//*********************************************************
  

