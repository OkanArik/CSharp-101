public  class TakimUyeleri
       {
           private static Dictionary<int,string>takimUyeleri=new Dictionary<int, string>();//Field
           public static Dictionary<int, string> takimUyeleri1 { get => takimUyeleri; }//Encapsulation(Property)
           static TakimUyeleri()//Static Constructor
           {
               takimUyeleri1.Add(1,"Okan Arık");
               takimUyeleri1.Add(2,"Mehmet Arık");
               takimUyeleri1.Add(3,"Ömer Arık");
               takimUyeleri1.Add(4,"Caner Arık");
               takimUyeleri1.Add(5,"Gökbey Arık");
           }

    
}
