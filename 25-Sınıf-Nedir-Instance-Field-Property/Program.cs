using System;


    namespace Sınıf_Nedir_Field_Property
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Bu dersimizde class'ları konuşacağız.Class'lar nesne yönelimli programlamanın en temel ögesi olarak düşünülebilir.C# yüzde yüz bir nesne yönelimli programlama (Object Oriented Programming(OOP)) dilidir.Method'lar , field'lar ,property'ler dediğimiz class ögeleri bir class içerisinde var olmak durumundadır.Class'lara ihtiyaç duyulmasının sebebi,methodlarla ilgili dersimizde bahsettiğimiz gibi programımızı komple bir method içerisinde yazmak yerine programımızı görevine göre kod parçalarına ayırarak bunu görevlerine göre anlaşılabilir adlandırmalarla yarattığımız methodlarla yazmak daha doğru bir yaklaşımdır , bu biz daha okunabilir , daha teniz kod verir bu olay class'lar içinde geçerlidir.Bu yaklaşım test driven development(test tabanlı yazılım geliştirme) 'dada çok faydalıdır.Bir kod bloğu ne kadar küçük ise , bir class ne kadar küçük ise,ne kadar az sorumluluğu varsa o kadar okunabilir, o kadar genişleyebilir , o kadar tekrar kullanılabilir hale gelir.Bir programı birden fazla class'a , birden fazla method'a böldüğümüzde her class'ın  sorumluluğu ayrı olmuş oluyor değişime kapalı değişime açık class'lar ,programlar , kod parçaları yazmış oluyoruz.Bu şekilde ilerliyor olmak programlama pratikleri arasında bir best practice yani uygun olan yöntem olarak düşünülebilir. 
                //************************************************************************************************
                //Örnek class söz dizimi(syntax);
                    //class SinifAdi
                    //{
                        //ErişimBelirteci VeriTipi OzellikAdi; //-->Property
                        //ErişimBelirteci GeriDonusTipi MethodAdi(ParametreListesi) //-->Method
                        //{
                            //Method Komutları
                        //}
                    //}
                //************************************************************************************************
                  //Erişim belirleyiciler:
                    // 1-->public:Her yerden erişilebilir.
                    // 2-->private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
                    // 3-->internal : Sadece bulunduğu proje içerisinden erişilebilir.
                    // 4-->protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
                //************************************************************************************************

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
            }
        }

        class Calısan
        {
            public string ad;//-->property
            public string soyad;//-->property

            public int no;//-->property

            public string departman;//-->property


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
  //Sinif Sözdizimi, Field ve Metot Tanımlama, Erişim Belirleyiciler
  //Sınıf Nedir, Neden İhtiyaç Duyarız ?:
  //Sınıflar Nesne Yönelimli Programlamanın en öneeli öğesidir. C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.
  //Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine, parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır demiştik. Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.
  //Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.
  //Bir sınıfın temelde 2 tipte öğesi vardır; field/özellik ve metotlar. Aşağıda örnek bir sınıf tanımının söz dizimini görebilirsiniz.
        //     class SinifAdi
        //     {
        //         [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
        //         [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
        //         {
        //             //Metot Gövdesi
        //         }
        //     }  
//****************************************************************************************************************
//Erişim Belirleyiciler:
  //Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.
    // 1-->Public : Her yerden erişilebilir.
    // 2-->Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
    // 3-->Internal : Sadece bulunduğu proje içerisinden erişilebilir.
    // 4--> Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
//****************************************************************************************************************