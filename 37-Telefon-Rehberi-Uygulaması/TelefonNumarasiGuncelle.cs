namespace Telefon_Rehberi_Uygulamasi
{
    public class TelefonNumarasiGuncelle
    {
        public static void NumaraGuncellePanel()
        {
            Console.WriteLine("Numarasını güncellemek istediğiniz kişinin adı ile arama yapmak için : (1)");
            Console.WriteLine("Numarasını güncellemek istediğiniz kişinin soyadı ile arama yapmak için : (2)");
            Console.Write("Seçim:");
            try
                    { 
                        int secim=Convert.ToInt32(Console.ReadLine());
                        if (secim==1) 
                            AdIleNumaraGuncelle();
                        else if(secim==2)
                            SoyAdIleNumaraGuncelle();
                        else 
                        {
                            Console.WriteLine("Geçersiz bir seçim yaptınız tekrar deneyiniz!");
                            NumaraGuncellePanel();
                        }    
                    }
                    catch (System.FormatException ex)
                    {
                        Console.WriteLine("Uygunsuz formatta veri girişi yaptınız:{0}",ex);
                        Console.WriteLine("Numara güncelleme paneline aktarılıyorsunuz.Tekrar deneyiniz!");
                        NumaraGuncellePanel();
    
                    }
    
        }
    
        private static void AdIleNumaraGuncelle()
        {   
            Console.Write("Numarasını güncellemek istediğinz kişinin adını giriniz:");
            string? metin=Console.ReadLine();
            bool section=true;
            foreach (var item in RehberDeposu.RehberList)
            {
                if(item.Ad==metin)
                {
                    GuncellemeOnayPanel(metin,item);
                    section=false;
                    break;
                }
            }
            if (section)
               GuncellenecekKisiYok();
        }
    
         private static void SoyAdIleNumaraGuncelle()
        {
            Console.Write("Numarasını güncellemek istediğinz kişinin soyadını giriniz:");
            string? metin=Console.ReadLine();
            bool section = true;
            foreach (var item in RehberDeposu.RehberList)
            {
                if(item.Soyad==metin)
                {
                    
                    GuncellemeOnayPanel(metin,item);
                    section=false;
                    break;
                }
            }
            if (section)
               GuncellenecekKisiYok();
        }
    
        private static void GuncellenecekKisiYok()
        {
            Console.WriteLine("Giriş yaptığınız veriye uygun kişi rehberde bulunamadı.");
            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            Console.Write("Seçim:");
            string? secim= Console.ReadLine();
            if (secim=="1")
            {
                Console.WriteLine("Güncelleme işlemi sonlandırılıyor ve ana ekrana yönlendiriliyorsunuz!");
            }
            else if(secim=="2")
            {
                Console.WriteLine("Yeniden denemen için numara silme paneline yönlendiriliyorsunuz!");
                NumaraGuncellePanel();
            }
            else 
            {
                Console.WriteLine("Geçersiz veri girişi yaptınız.Tekrar deneyiniz!");
                GuncellenecekKisiYok();
            }
        }
    
        private static void GuncellemeOnayPanel(string metin,Rehber item)
        {
            Console.Write("{0} {1} kişisinin numarasını rehberde güncellemek üzere onaylıyor musunuz? y/n:",item.Ad,item.Soyad);
            string? onay= Console.ReadLine();
    
            switch (onay)
            {   
                case "y":
                Console.Write("Güncel telefon numarasını giriniz:");
                item.TelNo=Console.ReadLine();
                Console.WriteLine("{0} {1} kişisinin numarası rehberde  başarıyla güncellenmiştir.",item.Ad,item.Soyad);
                break;
                case "n":
                Console.WriteLine("Numara güncelleme işlemi iptal edilmiştir!");
                break;  
                default:
                Console.WriteLine("Geçersiz veri girişi yaptınız. Tekrar deneyiniz!");
                GuncellemeOnayPanel(metin,item);
                break;
            }
        }
    }
}