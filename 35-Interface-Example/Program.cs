using System;

 
    namespace Interface_Example
    {
        class Program
        {
            public static void Main(string[] args)
            {
                Mazda3 mazda3 =new();
                Console.WriteLine(mazda3.HangiMarkanınAracı().ToString());
                Console.WriteLine(mazda3.KacTekerlektenOlusur());
                Console.WriteLine(mazda3.StandartRengiNe().ToString());

                Civic civic=new Civic();
                Console.WriteLine(civic.HangiMarkanınAracı().ToString());
                Console.WriteLine(civic.KacTekerlektenOlusur());
                Console.WriteLine(civic.StandartRengiNe().ToString());



            }
        }
    }