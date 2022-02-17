using System;


    namespace Polymorphism 
    {
        public class Canlilar
        {
            protected void Beslenme()
            {
                Console.WriteLine("Canlılar beslenir.");
            }
           protected void Solunum()
           {
               Console.WriteLine("Canlılar solunum yapar.");
           }
           protected void Basaltim()
           {
               Console.WriteLine("Canlılar boşaltım yapar.");
           }
           public virtual void UyaranlaraTepki()
           {
               Console.WriteLine("Canlılar uyaranlara tepki verir.");
           }
        }
    }