//template:şablon
//sequence:dizi,seri,art arda sıralama
//customize:özelleştirmek
using System;


   namespace Tanımlama_Erişim_ve_Döngülerle_Dizi_Kullanımı
   {
        class Program
        {
            public static void Main(string[] args)
            {
                //Dizi:Aynı tipteki verileri bellekte arka arkaya saklamak istediğimizde dizileri kullanırız.Bir dizinin elemanlarının veri tipleri aynı olmak durumundadır , yani başka bir deyişle tanımladığımız diziyi hangi veri tipinde tanımladıysak diziye atacağımız verilerde o veri tipinde olmalıdır.Örneğin bir integer(int) bir dizi tanımladığımızda onun içerisine string bir veri atayamayız.
                //Dizilerle bir çok karmaşık işlemi çözmek mümkündür,diziler ve döngüleri bir arada kullandığımızda büyük bir güç elde ediyoruz.
                //Dizilerde bulunan ilk eleman dizinin 0. index'indeki elemandır bu konuya dikkat kesilmek lazım, yani 7 elemanlı olarak tanımladığımız bir dizide son eleman dizinin 6. index'indedir ve ilk eleman dizinin 0. index'indedir.

                //***Dizi Tanımlama:*********************************************************

                string[] colors=new string[5];//Burada colors adında string veri tipinde boyutu 5 elemanlık bir dizi tanımladık.Diziler tanımlanırken boyutuda tanımlama içerisinde olmak zorunda değildir ancak bir dizinin büyüklüğü yani bellekte ne kadar yer kaplayacağı dizi kullanılmadan önce mutlaka belirlenmelidir.

                string[] animals={"Cat","Dog","Bird","Monkey"};//Burada animals adında string veri tipinde dizi tanımladım ve diziye direk string veri tipinde 4 adet eleman ataması yaptım.Burada diziye 4 eleman ataması yaparak boyutununda 4 elemanlı olduğunu belirtmiş oldum birnevi.

                int[] sequence;//Burada integer(int) veri tipinde eleman tutan sequence(dizi) adında dizi tanımladım.Burada görüldüğü dizi tanımlarken boyutunu belirtmek zorunda değilim lakin diziyi kullanmadan önce büyüklüğünü yani bellekte kapladığı alanı belirtmek durumundayım.
                sequence=new int[5];//Burada integer veri tipinde eleman tutan sequence adındaki dizinin boyutunu belirledim.

                //***Dizilere Değer Atama ve Erişim:*****************************************

                colors[0]="Blue";//colors dizisinin 0.index'ine Blue elemanını(verisini) atadım.

                Console.WriteLine(animals[0]);//Burada animals dizisinin 0.index'indeki elamanı yani Cat verisini Console'a yazdırdım.

                sequence[3]=10;//Burada sequence dizisinin 3.index'ine 10 sayısını(verisini) atadık.  

                Console.WriteLine(colors[0]);// Output: Blue
                Console.WriteLine(sequence[3]);// Output: 10

                //***Döngülerle Dizi Kullanımı:**********************************************
                  //Döngülerle dizi kullanımı oldukça önemlidir.Algoritmalarda filan en çok kullanılan yöntemlerden birisidir döngülerle dizi kullanımı.Sorulan sorular döngülerle ve dizilerle kolaylıkla çözülebilecek sorulardır.Dizilerle çözebileceğimiz soruları farklı yöntemlerlede çözebiliyor olabilir fakat diziler çok daha hızlı, çok daha temiz bir kodla  çözüm imkanı sağlar.

                  Console.WriteLine("Klavyeden girilen n tane sayının ortalamasını alan program.");
                  Console.Write("Lütfen dizinin eleman sayısını giriniz(n):");
                  if (int.TryParse(Console.ReadLine(),out int diziUzunlugu))
                  {
                     Console.WriteLine("n sayısı için geçerli veri girişi yaptınız");
                  }
                  else 
                  {
                      Console.WriteLine("n sayısı için geçersiz veri girişi yaptınız");
                  }
                  int[] sayiDizisi=new int[diziUzunlugu];

                  for (int i = 0; i < diziUzunlugu; i++)
                  {
                      Console.Write("Lütfen {0}. elemanı giriniz:",i+1);
                      if (int.TryParse(Console.ReadLine(), out  sayiDizisi[i]))
                      {
                          continue;
                      }
                      else
                      {
                          Console.WriteLine("Geçersiz veri girişi yaptınız tekrar deneyiniz!");
                          i--;
                      }
                  }

                  double toplam=0;
                  foreach (var sayi in sayiDizisi)
                           toplam+=sayi;

                  Console.WriteLine("Ortalama:{0}",toplam/diziUzunlugu);               
            }
        }
   }
//*******************************************************************************************
   //Dizi Nedir, Dizi Tanımlama, Dizilere Erişim ve Döngülerle Kullanımı:
   //Aynı tipteki verileri bellekte yan yana saklamak istediğimizde dizilerden faydalanırız. Değişkenler kullanılarak karmaşık şekilde çözülebilecek problemler diziler yardımıyla çok daha kolay bir şekilde çözülebilir.

   //Dizi index'i 0'dan başlar. Yani 5 elemanlı bir dizinin ilk elemanı 0. indexte sonuncu elemanı 4. indextedir.

   //int[] sayilar = new int[10];
   //sayilar[2] = 12;
   //Yukarıda örnek bir dizi tanımlaması görüyoruz. Integer tipinde veri tutan 10 elemanlı bir dizi tanımladık. Ve dizinin 3. elemanına yani 2. indexine 12 değerini atadık.

   //string[] renkler = {"Mavi","Kırmızı","Sarı","Yeşil"};
   //Dizilerin elemanlarını dizi tanımı yapılırken verebiliriz. Yukarıdaki örnekte göreceğiniz üzere string tipinde bir dizi tanımladık. Ve elemanları bize bunun 4 elemanlı bir dizi olduğunu söylüyor.

   //Dizi tanımlandığı anda eleman sayısı belirlenmek zorunda değildir. Önce tanımı yapıp daha sonradan eleman sayısı da atanabilir. Ama bir dizinin büyüklüğü yani bellekte ne kadar yer kaplayacağı dizi kullanılmadan önce mutlaka belirlenmelidir.

   //int[] dizi;
   //dizi = new int[4];
   //Yukarıdaki örnekte önce integer tipinde "dizi" adında bir dizi tanımı yaptık. Alt satırda da bu dizinin 4 elemanlı bir dizi olacağını söyledik.

   //Dizilere Erişim
   //Aşağıdaki örnekte de görebileceğiniz gibi dizilere index numaraları ile erişilebilir.

   //string[] renkler = {"Mavi","Kırmızı","Sarı","Yeşil"};
   //string renk = renkler[1]; // Kırmızı rengi getirir.
   //Döngülerle Dizi Kullanımı
   //int[] sayiDizisi = new int[20];
   //int toplam = 0;
   //for (int i = 0; i < sayiDizisi.Length; i++)
   //  {
   //    Console.Write("Lütfen {0}. sayıyı girin:", i+1);
   //    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
   //    toplam += sayiDizisi[i];
   //  }
   //double ortalama = toplam / 20;
   //Console.WriteLine("Sayıların ortalaması: " + ortalama);
   //Console.ReadLine();
   //Yukarıdaki örnekte bir for döngüsü içerisinde dizi kullanımını görüyoruz. Öncelikle 20 elemanlı bir dizi tanımladık. Ve bu 20 elemanın değerlerini kullanıcıdan console aracılığıyla aldık. For döngüsü kullanmasaydık 20 defa Console.ReadLine() yazmamız gerekiyordu. Bunun yerine döngülerin ve dizilerin gücünü birleştirerek sadece bir kaç satırda, okunabilir bir kod ile problemimizi çözdük.