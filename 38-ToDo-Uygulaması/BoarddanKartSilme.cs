public class KartSilme
{
    public static void kartSilme()
    {
        Console.Write("Lütfen silmek istediğiniz kartın başlığını giriniz:");
        string silinecekKartBaslik=Console.ReadLine();
        int kontrol=0;
        foreach (var item in Board.doneList.ToList())
        {
            if(item.Baslik==silinecekKartBaslik)
              {
                  Board.doneList.Remove(item);
                  kontrol++;
              }
        }
        foreach (var item in Board.inProgressList.ToList())//Burada .ToList() methodunu kullanmamın sebebi foreach döngüsünde inpRogressList generic koleksiyonunun elemanlarına erişimde generic koleksiyondan eleman remove edilmesi, null olması ve benzeri durumlarda hata vermesini engellemek.Bunu Generic koleksiyonunun ToList() methoduyla var olan elemanlarını list şeklinde listeleyerek sağlıyorum. 
        {
            if(item.Baslik==silinecekKartBaslik)
              {
                  Board.inProgressList.Remove(item);
                  kontrol++;
              }
        }
        foreach (var item in Board.toDoList.ToList())
        {
            if(item.Baslik==silinecekKartBaslik)
              {
                  Board.toDoList.Remove(item);
                  kontrol++;
              }
        }
        if(kontrol==0)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            Console.Write("Seçim  :");
            int SECIM=int.Parse(Console.ReadLine());
            if(SECIM==2)
              kartSilme();
        }   
    }
}