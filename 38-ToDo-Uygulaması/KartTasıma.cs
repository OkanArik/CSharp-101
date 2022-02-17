public class KartTasima
{
    public static void kartTasima()
    {
        Console.Write("Lütfen taşımak istediğiniz kartın başlığını giriniz:");
        string tasınacakKartBaslik=Console.ReadLine();
        int kontrol=0;
        foreach (var item in Board.doneList.ToList())
        {
            if(item.Baslik==tasınacakKartBaslik)
              {
                  ConsoleKartBilgileriYazdir(item);
                  int secim=TasimakIstediginLineSec();
                  if(secim<=3&&secim>=1)
                  {
                          switch (secim)
                        {
                            case 1:
                            Board.toDoList.Add(item);
                            break;
                            case 2:
                            Board.inProgressList.Add(item);
                            break;
                            case 3:
                            Board.doneList.Add(item);
                            break;
                        }
                     Board.doneList.Remove(item);
                     BOARDLISTELEMEK.BoardListelemek();
                  }
                  
                  kontrol++;
              }
        }
        foreach (var item in Board.inProgressList.ToList())
        {
            if(item.Baslik==tasınacakKartBaslik)
              {
                  ConsoleKartBilgileriYazdir(item);
                  int secim=TasimakIstediginLineSec();
                  if(secim<=3&&secim>=1)
                  {
                          switch (secim)
                        {
                            case 1:
                            Board.toDoList.Add(item);
                            break;
                            case 2:
                            Board.inProgressList.Add(item);
                            break;
                            case 3:
                            Board.doneList.Add(item);
                            break;
                        }
                     Board.inProgressList.Remove(item);
                     BOARDLISTELEMEK.BoardListelemek();
                  }
                  
                  kontrol++;
              }
        }
        foreach (var item in Board.toDoList.ToList())
        {
            if(item.Baslik==tasınacakKartBaslik)
              {
                  ConsoleKartBilgileriYazdir(item);
                  int secim=TasimakIstediginLineSec();
                  if(secim<=3&&secim>=1)
                  {
                          switch (secim)
                        {
                            case 1:
                            Board.toDoList.Add(item);
                            break;
                            case 2:
                            Board.inProgressList.Add(item);
                            break;
                            case 3:
                            Board.doneList.Add(item);
                            break;
                        }
                     Board.toDoList.Remove(item);
                     BOARDLISTELEMEK.BoardListelemek();
                  }
                  
                  kontrol++;
              }
        }
        if(kontrol==0)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Kart taşıma işlemini sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            Console.Write("Seçim  :");
            int SECIM=int.Parse(Console.ReadLine());
            if(SECIM==2)
              kartTasima();
        }   
    }

    private static void ConsoleKartBilgileriYazdir(Kart kisi)
    {
            Console.WriteLine("Başlık     : {0}",kisi.Baslik);
            Console.WriteLine("İçerik     : {0}",kisi.Icerik);
            Console.WriteLine("Atanan Kişi: {0}",kisi.AtananKisi);
            Console.WriteLine("Büyüklük   : {0}",kisi.Buyukluk);
            Console.WriteLine("  -   ");
    }

    private static int TasimakIstediginLineSec()
    {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
            Console.WriteLine("(1) TODO ");
            Console.WriteLine("(2) IN PROGRESS ");
            Console.WriteLine("(3) DONE ");
            Console.Write("Secim : ");
            if(int.TryParse(Console.ReadLine(),out int secim))
            {
                if(secim<1||secim>3)
                  {
                        Console.WriteLine("Hatalı seçim yaptınız! İşlem sonlandırılıyor.");  
                  }
            }
            
            return secim;

    }       
}