    namespace Telefon_Rehberi_Uygulamasi
    {
        class Program
        {
            public static void Main()
            {
                Console.WriteLine("**********ANA EKRAN**********");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydet ");
                Console.WriteLine("(2) Varolan Numarayı Sil ");
                Console.WriteLine("(3) Varolan Numarayı Güncelle ");
                Console.WriteLine("(4) Rehberi Listele");
                Console.WriteLine("(5) Rehberde Arama Yap ");
                Console.WriteLine("(6) Telefon Rehberi Uygulamasını Kapat ");
                Console.Write("Seçim:");
                
                
                try
                { 
                    int secim=Convert.ToInt32(Console.ReadLine());
                    if(secim<=6&&secim>0)
                    {
                        switch (secim)
                        {
                            
                            case 1:
                            //Yeni Numara Kaydet sayfasına yönlendirme yapacağız.
                            YeniNumaraKayıt.NumaraKayıt();
                            break;
                            case 2:
                            //Varolan Numarayı Silmek sayfasına yönlendirme yapacağız.
                            TelefonNumarasiSilme.NumaraSilPanel();
                            break;
                            case 3:
                            //Varolan Numarayı Güncelleme sayfasına yönlendirme yapacağız.
                            TelefonNumarasiGuncelle.NumaraGuncellePanel();
                            break;
                            case 4:
                            //Rehberi Listelemek sayfasına yönlendirme yapacağız.
                            RehberListele.RehberListelePanel();
                            break;
                            case 5:
                            //Rehberde Arama Yapmak sayfasına yönlendirme yapacağız.
                            RehberdeAramaYapma.RehberdeAramaYapmaPaneli();
                            break;
                            case 6:
                            Console.WriteLine("Güle Güle:)");
                            Environment.Exit(0);//Programı tamamen kapatan komut satırım.
                            break;   
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz veri girişi yaptınız.Tekrar deneyiniz!");
                    }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine(ex.Message.ToString());//Burada System.FormatException'ı console yazdırdım user friendly(kullanıcı dostu) olması açısından.
                }

                Console.WriteLine("*****************************************************");
                Console.WriteLine("Ana Ekrana Dönüş Yaptınız!");
                Console.WriteLine("*****************************************************");
                Program.Main();//Telefon Rehberi Uygulaması console application'ımı kendim kapatmadıkça kapanmaması için Main metot sonunda başa dönmemi sağlıyor yani ana ekrana dönüyorum.Eğer console dan 6 veri girişini yaparsam console uygulamam kapanıyor.            
            }
        }
    }