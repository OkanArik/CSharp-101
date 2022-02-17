public class KartEkleme
{
    public static void kartEkleme()
    {
        Console.Write("Başlık Giriniz                                  :");
        string BASLIK=Console.ReadLine();
        Console.Write("İçerik Giriniz                                  :");
        string ICERIK=Console.ReadLine();
        Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        int enumSecim=int.Parse(Console.ReadLine());
        Console.WriteLine("Kişi Seçiniz                                    :");
        Console.WriteLine("ID(1) Okan");
        Console.WriteLine("ID(2) Mehmet");
        Console.WriteLine("ID(3) Ömer");
        Console.WriteLine("ID(4) Caner");
        Console.WriteLine("ID(5) Gökbey");
        Console.Write("Kişi seçimi :");
        int kisiSecim=int.Parse(Console.ReadLine());
        if (kisiSecim<1||kisiSecim>5)
           Console.WriteLine("Hatalı griş yaptınız! İşlem iptal edildi.");
        else 
           Board.toDoList.Add(new Kart(BASLIK,ICERIK,TakimUyeleri.takimUyeleri1[kisiSecim],Convert.ToString((BUYUKLUK)enumSecim)));
           
    }
}