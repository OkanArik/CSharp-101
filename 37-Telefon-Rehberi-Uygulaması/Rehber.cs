namespace Telefon_Rehberi_Uygulamasi
    {
        class Rehber
        {
            private string ad;//Field
            private string soyad;//Field
            private string telNo;//Field    
            public string Ad { get => ad; set => ad = value; }//Encapsulation(Property)
            public string Soyad { get => soyad; set => soyad = value; }//Encapsulation(Property)
            public string TelNo { get => telNo; set => telNo = value; }//Encapsulation(Property)
            public Rehber(string ad, string soyad, string telNo)//Constructor
            {
                this.ad = ad;
                this.soyad = soyad;
                this.telNo = telNo;
            }
    
        }
    }