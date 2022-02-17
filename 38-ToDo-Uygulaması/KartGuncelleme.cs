public class KartGuncelle
{
    public static void kartGuncelle()
    {
        Console.Write("Lütfen güncellemek istediğiniz kartın başlığını giriniz:");
        string guncellenecekKartBaslik=Console.ReadLine();
        int kontrol=0;
        foreach (var item in Board.doneList)
        {
            if(item.Baslik==guncellenecekKartBaslik)
              {
                  KartGuncellemeMethodu(item);
                  kontrol++;
              }
        }
        foreach (var item in Board.inProgressList)
        {
            if(item.Baslik==guncellenecekKartBaslik)
              {
                  KartGuncellemeMethodu(item);
                  kontrol++;
              }
        }
        foreach (var item in Board.toDoList)
        {
            if(item.Baslik==guncellenecekKartBaslik)
              {
                  KartGuncellemeMethodu(item);
                  kontrol++;
              }
        }
        if(kontrol==0)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Kart güncelleme işlemini sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            Console.Write("Seçim  :");
            int SECIM=int.Parse(Console.ReadLine());
            if(SECIM==2)
              kartGuncelle();
        }   
    }

    private static void KartGuncellemeMethodu(Kart item)
    {
        Console.WriteLine("Başlık     : {0}",item.Baslik);
        Console.WriteLine("İçerik     : {0}",item.Icerik);
        Console.WriteLine("Atanan Kişi: {0}",item.AtananKisi);
        Console.WriteLine("Büyüklük   : {0}",item.Buyukluk);
        Console.WriteLine("  -   ");
        Console.Write("Güncellemek istediğniz veri için yukarıdan aşağıya doğru sırası ile 1 , 2, 3 veya 4 değerini giriniz:");
        if (int.TryParse(Console.ReadLine(),out int sec))
        {
            Console.WriteLine("Güncel veriyi giriniz:");
            switch (sec)
            {
                case 1:
                item.Baslik=Console.ReadLine();
                break;
                case 2:
                item.Icerik=Console.ReadLine();
                break;
                case 3:
                foreach (var takimyesi in TakimUyeleri.takimUyeleri1)
                {
                    Console.WriteLine(takimyesi);
                }
                Console.Write("ID ile atancak kişiyi seç:");
                item.AtananKisi=TakimUyeleri.takimUyeleri1[int.Parse(Console.ReadLine())];
                break;
                case 4:
                item.Buyukluk=Convert.ToString((BUYUKLUK)(int.Parse(Console.ReadLine())));
                break;
            }
        }
    }
}