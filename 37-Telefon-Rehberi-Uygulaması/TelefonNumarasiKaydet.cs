namespace Telefon_Rehberi_Uygulamasi
    {
        class YeniNumaraKayıt
        {
            public static void NumaraKayıt()
            {
                Console.Write("Lütfen isim giriniz             :");
                string? isim=Console.ReadLine();//Burada bu bilgiyide not düşelim string veri tipi tanımından sonraki ? işareti ile isim değişkenimi null atanabilir yapıyorum.
                Console.Write("Lütfen soyisim giriniz          :");
                string? soyisim=Console.ReadLine();
                Console.Write("Lütfen telefon numarası giriniz :");
                string? telefonNumarası=Console.ReadLine();
                
                if(isim==null||soyisim==null||telefonNumarası==null)
                {
                    Console.WriteLine("Eksik bilgi girişi yaptınız. Tekrar deneyiniz!");
                    NumaraKayıt();
                }
                else
                RehberDeposu.RehberList.Add(new Rehber(isim,soyisim,telefonNumarası));
            }
        }
    }