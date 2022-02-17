public class BOARDLISTELEMEK
{
    public static void BoardListelemek()//Board'um daki Line(satır)'larımı ve Line'larımdaki kartlarımı console'a yazdırdığım method'um.
            {
                Console.WriteLine("***************************");
                Console.WriteLine("TODO Line:");
                Console.WriteLine("---------------------------");
                int sayici1=0;
                int sayici2=0;
                int sayici3=0;
                foreach (var item in Board.toDoList.ToList())
                {
                    Console.WriteLine("Başlık     : {0}",item.Baslik);
                    Console.WriteLine("İçerik     : {0}",item.Icerik);
                    Console.WriteLine("Atanan Kişi: {0}",item.AtananKisi);
                    Console.WriteLine("Büyüklük   : {0}",item.Buyukluk);
                    Console.WriteLine("  -   ");
                    sayici1++;
                }
                if(sayici1==0)
                  Console.WriteLine("  ~ BOŞ ~  ");
                Console.WriteLine("***************************");
                Console.WriteLine("IN PROGRESS Line:");
                Console.WriteLine("---------------------------");
                foreach (var item in Board.inProgressList.ToList())
                {
                    Console.WriteLine("Başlık     : {0}",item.Baslik);
                    Console.WriteLine("İçerik     : {0}",item.Icerik);
                    Console.WriteLine("Atanan Kişi: {0}",item.AtananKisi);
                    Console.WriteLine("Büyüklük   : {0}",item.Buyukluk);
                    Console.WriteLine("  -   ");
                    sayici2++;
                }
                if(sayici2==0)
                  Console.WriteLine("  ~ BOŞ ~  ");
                Console.WriteLine("***************************");
                Console.WriteLine("DONE Line:");
                Console.WriteLine("---------------------------");
                foreach (var item in Board.doneList.ToList())
                {
                    Console.WriteLine("Başlık     : {0}",item.Baslik);
                    Console.WriteLine("İçerik     : {0}",item.Icerik);
                    Console.WriteLine("Atanan Kişi: {0}",item.AtananKisi);
                    Console.WriteLine("Büyüklük   : {0}",item.Buyukluk);
                    Console.WriteLine("  -   ");
                    sayici3++;
                }
                if(sayici3==0)
                  Console.WriteLine("  ~ BOŞ ~  ");
                Console.WriteLine("***************************");
            }
}