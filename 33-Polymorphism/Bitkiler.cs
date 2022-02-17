using System;


    namespace Polymorphism 
    {
        public class Bitkiler:Canlilar 
        {
           protected void Fotosentez()
           {
               Console.WriteLine("Bitkiler fotosentez yapar.");
           }

           public override void UyaranlaraTepki()
           {
               Console.WriteLine("Bitkiler güneşe tepki verir.");
           }
        }
        
        public class TohumluBitkiler:Bitkiler
        {
            public TohumluBitkiler()
            {
                base.Solunum();
                base.Beslenme();
                base.Basaltim();
                base.Fotosentez();//Base ile buraya miras veren üst sınıfların methodlarına erişim sağlarım ve bunu kurucu methodda kullanarak her nesne ayağa kaldırmada erişirim ve çalıştırırım.
                base.UyaranlaraTepki();
                 
            }
            public void TohumlaÇoğalma()
            {
                Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
            }
        }

        public class TohumsuzBitkiler:Bitkiler
        {
             public TohumsuzBitkiler()
            {
                base.Solunum();
                base.Beslenme();
                base.Basaltim();
                base.Fotosentez();//Base ile buraya miras veren üst sınıfların methodlarına erişim sağlarım ve bunu kurucu methodda kullanarak her nesne ayağa kaldırmada erişirim ve çalıştırırım.
                base.UyaranlaraTepki();
            }
            public void SporlaÇoğalma()
            {
                Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
            }
        }
    }