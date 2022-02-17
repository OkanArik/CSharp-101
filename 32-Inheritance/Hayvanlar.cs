using System;


    namespace Inheritance 
    {
        public class Hayvanlar:Canlilar
        {
           protected void Adaptsayon()
           {
               Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
           }
        }

        public class Surungenler:Hayvanlar//Burada Surungenler:Hayvanlar yaparak Surungenler sınıfının hayvanlar sınıfından kalıtım almasını yani miras almasını sağladık.Hayvanlar sınıfı sürüngenler sınıfının üst sınıfıdır ve surungenlerde hayvan olduklarından hayvanların özelliklerini gösterirler bu kalıtım alma yöntemiyle sürüngenler için Hayvanlar sınıfında bulunan Adaptasyon özelliğini kullanacağız.
        {
            public Surungenler()
            {
                base.Solunum();
                base.Beslenme();
                base.Basaltim();
                base.Adaptsayon();
            }
            public void SurunerekHareketEderler()
            {
                Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
            }
        }

         public class Kuslar:Hayvanlar
        {
            public Kuslar()
            {
                base.Solunum();
                base.Beslenme();
                base.Basaltim();
                base.Adaptsayon();
            }

            public void UcarakHareketEderler()
            {
                Console.WriteLine("Kuşlar uçarak hareket ederler.");
            }
        }
    }