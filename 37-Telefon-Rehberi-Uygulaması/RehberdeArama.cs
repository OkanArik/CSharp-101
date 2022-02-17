namespace Telefon_Rehberi_Uygulamasi
{
    public class RehberdeAramaYapma
    {
        public static void RehberdeAramaYapmaPaneli()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsme göre arama yapmak için: (1)");
            Console.WriteLine("Soyisme göre arama yapmak için: (2)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (3)");
            Console.Write("Seçim:");
    
            string? secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                AdIleBulma();
                break;
                case "2":
                SoyadIleBulma();
                break;
                case "3":
                TelNoIleBulma();
                break;
            }
        }
    
        private static void AdIleBulma()
        {   
            Console.Write("Bulmak istediğiniz kişi bilgileri için kişi adını giriniz:");
            string? veri=Console.ReadLine();
            bool section=true;
            foreach (var item in RehberDeposu.RehberList)
            {
                if (veri==item.Ad)
                {
                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("İsim: {0}",item.Ad);
                    Console.WriteLine("Soyisim: {0}",item.Soyad);
                    Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                    Console.WriteLine("-----------"); 
                    section=false;
                    break;
                }
            } 
             if (section)
                RehberdeBulunamadi();
        }
    
        private static void SoyadIleBulma()
        { 
            Console.Write("Bulmak istediğiniz kişi bilgileri için kişi soyadını giriniz:");
            string? veri=Console.ReadLine();
            bool section=true;
            foreach (var item in RehberDeposu.RehberList)
            {
                if (veri==item.Soyad)
                {
                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("İsim: {0}",item.Ad);
                    Console.WriteLine("Soyisim: {0}",item.Soyad);
                    Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                    Console.WriteLine("-----------"); 
                    section=false;
                    break;
                }
            } 
    
            if (section)
               RehberdeBulunamadi();
        }
    
        private static void TelNoIleBulma()
        { 
            Console.Write("Bulmak istediğiniz kişi bilgileri için kişi telefon numarasını giriniz:");
            string? veri=Console.ReadLine();
            bool section=true;
            foreach (var item in RehberDeposu.RehberList)
            {
                if (veri==item.TelNo)
                {
                    Console.WriteLine("Arama Sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("İsim: {0}",item.Ad);
                    Console.WriteLine("Soyisim: {0}",item.Soyad);
                    Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                    Console.WriteLine("-----------"); 
                    section=false;
                    break;
                }
            } 
             if (section)
                RehberdeBulunamadi();
        }
    
        private static void RehberdeBulunamadi()
        {
            Console.WriteLine("Veri girişinize uygun kişi bulunamadı!");
            Console.WriteLine("Tekrar denemek için : (1)");
            Console.WriteLine("Ana ekrana dönmek için : (2)");
            Console.Write("Seçim:");
            switch (Console.ReadLine())
            {
                case "1":
                RehberdeAramaYapmaPaneli();
                break;
                case "2":
                break;
                default:
                Console.WriteLine("Geçersiz veri girişi yaptınız.Tekrar deneyiniz!");
                RehberdeBulunamadi();
                break;
            }
            
        }
    }
}