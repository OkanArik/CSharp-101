public  class Kart
        {
           private  string baslik;//Field
           private  string icerik;//Field
           private  string atananKisi;//Field
           private  string  buyukluk;//Field

           public  string Baslik { get => baslik; set => baslik = value; }//Encapsulation(property)
           public  string Icerik { get => icerik; set => icerik = value; }//Encapsulation(property)
           public  string AtananKisi { get => atananKisi; set => atananKisi = value; }//Encapsulation(property)
           public string Buyukluk { get => buyukluk; set => buyukluk = value; }//Encapsulation(property)

           public Kart(string baslik, string icerik, string atananKisi , string buyukluk )//Constructor
                {
                    this.baslik = baslik;
                    this.icerik = icerik;
                    this.atananKisi = atananKisi;
                    this.buyukluk = buyukluk;
                
                }
        }
        