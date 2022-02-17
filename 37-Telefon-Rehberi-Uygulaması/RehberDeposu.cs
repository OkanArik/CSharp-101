namespace Telefon_Rehberi_Uygulamasi
    {
        static class  RehberDeposu
        {
            public static List<Rehber> RehberList;//Field

            static RehberDeposu()//Static constructor yani RehberDeposu class'ına ilk erişildiğinde bir defa çalışacak RehberList generic koleksiyonuna ilk elaman atamaları olarak bir kereliğine 5 adet Rehber tipinde eleman atıyacak.
            {
                RehberList=new List<Rehber>()
                {
                    new Rehber("Okan","Arık","11111111111"),
                    new Rehber("Barış","Arık","11111111112"),
                    new Rehber("Mehmet","Arık","11111111113"),
                    new Rehber("Ceylan","Arık","11111111114"),
                    new Rehber("Ayhan","Arık","11111111114")
                };
            }
        }
    }