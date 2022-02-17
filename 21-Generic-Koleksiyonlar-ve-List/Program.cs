using System;
using System.Collections.Generic;


    namespace Generic_Collections
    {
        class Program
        {
            public static void Main(string[] args)
            {
               //Bu dersimizde List class'ına bakacağız , bu class  System.Collections.Generic namespace'i altından geliyor ve bu namespace'in altından gelmesi bize bir çok kullanılabilir method sunuyor.
               //Syntax'ı: List<T> //Buradaki T bize aslında bunun generic(genel) olduğunu söylüyor.T-->object türündedir nesne alabilir yani listelerin içindeki nesnelerin tipini(türünü) belirtiriz. T nin olduğu yerde oluşturduğumuz nesnelerin tipini belirtiriz veya T yaparak object olarak belirtiriz.
               //Altında bulunduğu namespace: System.Collections.Generic(Bu collection(koleksiyon)'ı kullanmak için System.Collections.Generic namespace'ini using direktifi ile programımıza import etlemeliyiz).
               
               //******************************************************************************************************
               List<int> sayiListesi=new List<int>();

               sayiListesi.Add(23);
               sayiListesi.Add(10);
               sayiListesi.Add(4);
               sayiListesi.Add(5);
               sayiListesi.Add(92);
               sayiListesi.Add(34);
               sayiListesi.Add(2);
               
               foreach (var item in sayiListesi)
               {
                   Console.Write(item+" ");
               }
               Console.Write("\n");

               sayiListesi.Sort();//sayiListesi koleksiyonunun elemanlarını numeric olarak küçükten büyüğe doğru sıraladık.
               foreach (var item in sayiListesi)
               {
                   Console.Write(item+" ");
               }
               Console.Write("\n");
               

               //******************************************************************************************************
               List<string> renkListesi=new List<string>();

               renkListesi.Add("Kırmızı");
               renkListesi.Add("Mavi");
               renkListesi.Add("Turuncu");
               renkListesi.Add("Sarı");
               renkListesi.Add("Yeşil");
               renkListesi.Add("Beyaz");

               foreach (var item in renkListesi)//foreach döngülerini koleksiyonların elemanları üzerinde işlemler yapmak için kullanabilriz.
               {
                   Console.Write(item+" ");
               }
               Console.Write("\n");

               renkListesi.Sort();//renListesi koleksiyonunun elemanlarını alfabetik sıraya göre sıraladık.
               foreach (var item in renkListesi)
               {
                   Console.Write(item+" ");
               }
               Console.Write("\n");
               
               //******************************************************************************************************
               
               //***Count:sayı,saymak//Count ile koleksiyon(liste) içerisindeki eleman sayısına ulaşırız.
               Console.WriteLine("*****Count*****");
               Console.WriteLine(sayiListesi.Count);
               Console.WriteLine(renkListesi.Count);

               //****************************************************************************************************

               //***foreach loop:foreach loops'ları koleksiyonların elemanları üzerinde işlem yapmak için kullanabiliriz.foreach ile elemanlara erişim:
               foreach (var sayi in sayiListesi)
               {
                   Console.WriteLine(sayi);
               }
               foreach (var renk in renkListesi)
               {
                   Console.WriteLine(renk);
               }

               //****************************************************************************************************

               //***.foreach ile elemanlara erişim:
               sayiListesi.ForEach(sayi=> Console.WriteLine(sayi+" "+sayi));
               renkListesi.ForEach(renk=> Console.WriteLine(renk+" "+renk));

               //****************************************************************************************************

               //***Listeden eleman çıkarmak:
               //***.Remove:listeden çıkarmak istediğimiz elemanla kullanırız:
               sayiListesi.Remove(4);
               renkListesi.Remove("Yeşil");
               sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
               renkListesi.ForEach(renk=> Console.WriteLine(renk));
               //***.RemoveAt:Listeden çıkarmak istediğimiz elemanın index'i ile kullanırız:
               sayiListesi.RemoveAt(0);
               renkListesi.RemoveAt(1);
               sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
               renkListesi.ForEach(renk=> Console.WriteLine(renk));

               //****************************************************************************************************

               //***Liste içerisinde arama:
               //***.Contains:
               if(sayiListesi.Contains(10))
               {
                   Console.WriteLine("10 sayısı sayiListesi içerisinde {0} indexte bulundu.",sayiListesi.IndexOf(10));//Burada IndexOf ilede 10 sayısının sayiListesindeki index numarasını öğrendim.
               }

               //****************************************************************************************************

               //***Eleman ile index'e erişme:
               //***.BinarySearch:
               Console.WriteLine("Sarı rengi renkListesi listesinde {0}. indextedir.",renkListesi.BinarySearch("Sarı"));

               //****************************************************************************************************

               //Diziyi List tipindeki bir listeye çevirme:
               string[] animals={"Kedi","Köpek","Kuş"};
               List<string> animalsList=new List<string>(animals);//Burada animals dizisini animalsList adında bir listeye çevirdik. 
               animalsList.ForEach(animal=> Console.WriteLine(animal));

               //****************************************************************************************************
               
               //***Listeyi temizlemek:
               //***.Clear:
               animalsList.Clear();
               if(animalsList.Count==0)
               {
                   Console.WriteLine("animalsList listesi temizlendi!");
               }

               //*********************************************************************************************

               //*****Buraya kadar listelerimizin T generic tipine string yada int(integer) vererek kullandık peki biz burada bir class tutmak istiyorsak yani bir nesne atamak istiyorsak listeye (liste içerisinde nesne tutmak istiyorsak) bunu nasıl yaparız ona bakalım:*****
               //***Liste içerisinde nesne tutmak:
               List<Kullanıcılar>kulllanıcıListesi=new List<Kullanıcılar>();//kullanıcıListesi adında class(nesne) tipinde yani Kullanıcı class'ının listesini oluşturduk .Bu listeye Kullanıcılar class'ının oluşturduğumuz nesnelerini atacağız.
               Kullanıcılar kullanıcı1=new Kullanıcılar();//Burada Kullanıcılar class'ının kullanıcı1 adında nesne(instance(örnek))'sini yarattık.
               kullanıcı1.Isim="Ayşe";
               kullanıcı1.Soyisim="Yılmaz";
               kullanıcı1.Yas=26;

               Kullanıcılar kullanıcı2=new Kullanıcılar();
               kullanıcı2.Isim="Özcan";
               kullanıcı2.Soyisim="Çalışkan";
               kullanıcı2.Yas=43;

               kulllanıcıListesi.Add(kullanıcı1);//Kullanıcılar class'ımın nesnelerinden oluşan kullanıcıListesi adındaki Kullanıcılar tipindeki listeme  kullanıcı1 adındaki nesnemi ekledim ve kullanıcı1 bir nesnemin kendi içerisinde üç tane property'si var bunlar Isim, Soyisim ve Yas.
               kulllanıcıListesi.Add(kullanıcı2);//Kullanıcılar class'ımın nesnelerinden oluşan kullanıcıListesi adındaki Kullanıcılar tipindeki listeme  kullanıcı2 adındaki nesnemi ekledim ve kullanıcı2 bir nesnemin kendi içerisinde üç tane property'si var bunlar Isim, Soyisim ve Yas.

               List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();//yeniListe adında Kullanıcılar tipinde nesne listemi yarattım.
               yeniListe.Add(new Kullanıcılar()//Burada Kullanıcılar tipindeki yeni listeme nesne ataması yaptım.Bunu new Kullanıcılar ile Kullanıcılar class'nın nesnesini yaratarak ardında süslü parantez içerisinde, Isim , Soyisim ve Yas property'lerime value(değer)  atayarak yaptım.
               {
                   Isim="Deniz",
                   Soyisim="Arda",
                   Yas=24
               });
 
               foreach (var kullanıcı in kulllanıcıListesi)
               {
                   Console.WriteLine("Kullanıcı adı:"+kullanıcı.Isim);
                   Console.WriteLine("Kullanıcı soyadı:"+kullanıcı.Soyisim);
                   Console.WriteLine("Kullanıcı yaş:"+kullanıcı.Yas);
               }         
               

               foreach (Kullanıcılar item in yeniListe)//Burada var yerine Kullanıcılar yaptık çünkü yeniListe Kullanıcılar tipinde bir nesne listeisidir.(Burası Kullanıcılar yerine var da olabilirdi farketmezdi burada farkındalık yaratması açısından yaptım.)
               {
                   Console.WriteLine("Kullanıcı adı:"+item.Isim);
                   Console.WriteLine("Kullanıcı soyadı:"+item.Soyisim);
                   Console.WriteLine("Kullanıcı yaş:"+item.Yas);
               }
               
               yeniListe.Clear();
               if(yeniListe.Count==0)
               {
                   Console.WriteLine("yeniListe adındaki liste temizlendi!");
               }
               

         

            } 
        }

        public class  Kullanıcılar //Bu class'ımızı Liste içerisinde nesne tutmak konumuzdaki nesneler için açtık.
        {
            private string isim;

            private string soyisim;

            private int yas;

            public string Isim { get => isim; set => isim = value; } //private string isim field(alan)'ını encapsulate(kapsülleme) işlemi yaptık yani getter ve setter'larını yazdık.Kapsülleme(encapsulation) işlemi ile private string isim alanıyla alakalı işlem yapılacağı zaman public string Isim kapsülü private field'ı get eder ve değer atanacaksada set eder, aslında kapsülleme işlemi ile private string isim alanını korumuş kontrol altına almış oluyoruz.İstersek bu kapsülün bloklarının içerisine set etmesi için koşullar yazabiliriz tyani kontrol mekanizması kurabiliriz.Bu kapsülleme işlemi ile istersek get'i dışarıya kapatabiliriz , istersek set'i dışarıya kapatabiliriz yada get çağırıldığında isim'i değiştirip gönderebiliriz filan gibi kontrol sağlar bize encapsulation(kapsülleme).
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
//************************************************************************************************************
//insert:eklemek
//remove:kaldırmak,çıkarmak
//contains:içermek
//************************************************************************************************************
  //***Generic Koleksiyonlar
  //Generic list System.Colections.Generic isim uzayı altında bulunan bir list sınıfı koleksiyonudur. Generic List bir list sınıfı tanımlarken T olarak tip değişkenini alır. Generic olmasını sağlayan da burdaki T veri tipidir. T listenin hangi türden veri tutacağını belirler. Bu tanımlama sonunda farklı türden bir veri tipini generic list ile saklayamazsınız.

   