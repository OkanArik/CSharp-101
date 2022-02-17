namespace Telefon_Rehberi_Uygulamasi
{
    public  class RehberListele
{
    public static void RehberListelePanel()
    {
        RehberDeposu.RehberList.Sort((x,y)=>x.Ad.CompareTo(y.Ad));
        Console.WriteLine("Rehberi a-z sıralaması ile listelemek için : (1)");
        Console.WriteLine("Rehberi z-a sıralaması ile listelemek için : (2)");
        Console.Write("Seçim:");
        string? secim=Console.ReadLine();
        if (secim=="1")
        {
              RehberListesi();      
        }
        else if (secim=="2")
        {
            RehberDeposu.RehberList.Reverse();
            RehberListesi();

        }
        else 
        {
            Console.WriteLine("Geçersiz veri girişi tekrar deneyiniz!");
            RehberListelePanel();
        }
    }
    private static void RehberListesi()
    {
        
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
             foreach (Rehber item in RehberDeposu.RehberList)
            {
                Console.WriteLine("İsim: {0}",item.Ad);
                Console.WriteLine("Soyisim: {0}",item.Soyad);
                Console.WriteLine("Telefon Numarası: {0}",item.TelNo);
                Console.WriteLine("-----------");
            }
    }
}
}