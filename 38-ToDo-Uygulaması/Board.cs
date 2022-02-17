public  class  Board//Board(yazı tahtası)'umdaki Line'latr için yarattıığım Generic Listlerimin bulunduğu class.
       {
           public static List<Kart> toDoList=new List<Kart>();
           public static List<Kart> inProgressList=new List<Kart>();
           public static List<Kart> doneList=new List<Kart>();
           static Board()//Static Constructor.Programım başladığında ilk Board class'ına erişildiğinde bir seferliğine çalışır ve bir daha çalışmaz bu özellik static kurucu olmasından gelir.
           {
               toDoList=new List<Kart>()
               {
                   new Kart("C#","C#101",TakimUyeleri.takimUyeleri1[1],Convert.ToString((BUYUKLUK)2)),
                   new Kart("Java","Java101",TakimUyeleri.takimUyeleri1[2],Convert.ToString((BUYUKLUK)3)),
                   new Kart("C++","C++101",TakimUyeleri.takimUyeleri1[3],Convert.ToString((BUYUKLUK)4)),
               };
           }


       }
