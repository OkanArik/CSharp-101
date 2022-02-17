 namespace Telefon_Rehberi_Uygulamasi
    {
        public class TelefonNumarasiSilme
        {
            public static void NumaraSilPanel()
            {
                Console.WriteLine("Numarasını silmek istediğiniz kişinin adı ile arama yapıp silmek için : (1)");
                Console.WriteLine("Numarasını silmek istediğiniz kişinin soyadı ile arama yapıp silmek için : (2)");
                Console.Write("Seçim:");
                try
                    { 
                        int secim=Convert.ToInt32(Console.ReadLine());
                        if (secim==1) 
                            AdIleNumaraSilme();
                        else if(secim==2)
                            SoyAdIleNumaraSilme();
                        else 
                        {
                            Console.WriteLine("Geçersiz bir seçim yaptınız tekrar deneyiniz!");
                            NumaraSilPanel();
                        }    
                    }
                catch (System.FormatException ex)
                    {
                        Console.WriteLine("Uygunsuz formatta veri girişi yaptınız:{0}",ex);
                        Console.WriteLine("Numara silme paneline aktarılıyorsunuz.Tekrar deneyiniz!");
                        NumaraSilPanel();
        
                    }
            }
        
            private static void AdIleNumaraSilme()
            {
                Console.Write("Rehberde silmek istediğiniz kişi bilgileri için kişinin adını giriniz:");
                string? metin=Console.ReadLine();
                bool section=true;
                foreach (var item in RehberDeposu.RehberList)
                {
                    if(item.Ad==metin)
                    {
                        SilmeOnayPaneli(metin,item);
                        section=false;
                        break;
                    }
                }
                if(section)
                  KisiYok();
            }
        
             private static void SoyAdIleNumaraSilme()
            {
                Console.Write("Rehberde silmek istediğiniz kişi bilgileri için kişinin soyadını giriniz:");   
                string? metin=Console.ReadLine();
                bool section=true;
                foreach (var item in RehberDeposu.RehberList)
                {
                    if(item.Soyad==metin)
                    {
                        
                        SilmeOnayPaneli(metin,item);
                        section=false;
                        break;
                    }
                }
                if(section)
                  KisiYok();
            }
        
            private static void KisiYok()
            {
                Console.WriteLine("Giriş yaptığınız veriye uygun kişi rehberde bulunamadı!");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");
                Console.Write("Seçim:");
                string? secim= Console.ReadLine();
                if (secim=="1")
                {
                    Console.WriteLine("Silme işlemi sonlandırılıyor ve ana ekrana yönlendiriliyorsunuz!");
                }
                else if(secim=="2")
                {
                    Console.WriteLine("Yeniden denemen için numara silme paneline yönlendiriliyorsunuz!");
                    NumaraSilPanel();
                }
            }
        
            private static void SilmeOnayPaneli(string metin,Rehber item)
            {
                Console.Write("{0} {1} kişisi rehberden silinmek üzere onaylıyor musunuz? y/n :",item.Ad,item.Soyad);
                string? onay= Console.ReadLine();
        
                switch (onay)
                {   
                    case "y":
                    RehberDeposu.RehberList.Remove(item);
                    Console.WriteLine("{0} {1} kişisi rehberden  başarıyla silinmiştir.",item.Ad,item.Soyad);
                    break;
                    case "n":
                    Console.WriteLine("Rehberden kişi silme işlemi iptal edilmiştir!");
                    break;  
                    default:
                    Console.WriteLine("Geçersiz veri girişi yaptınız!");
                    break;
                }
            }
        }
    }