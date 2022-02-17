using System;
using System.Collections;
using System.Collections.Generic;


   namespace ToDoApp
    {
        public class Program
        {
            public static void Main()
            {   
                ToDoAppMonitor();//To Do Uygulamasının ekranını yazdığım method'u çağırdım.
                try//try-catch methodunu kullanmamın sebebi  integer tipinde veri girişi alcam eğer veri girişi integer olmazsa catch te exception'ı yakalayıp kullanıcıyı bu konu hakkında bilgilendircem. 
                {   
                    Console.Write("    Seçim    :");
                    int secim=int.Parse(Console.ReadLine());
                        switch (secim)
                        {  
                            case 1:
                            //Kart ekleme işlemine yönlendirme yapacağız.
                            KartEkleme.kartEkleme();
                            break;
                            case 2:
                            //Kart güncelleme işlemine yönlendirme yapacağız.
                            KartGuncelle.kartGuncelle();
                            break;
                            case 3:
                            //Kart silme islemine yönlendirme yapacağız.
                            KartSilme.kartSilme();
                            break;
                            case 4:
                            //Kart taşıma işlemine yönlendirme yapacağız.
                            KartTasima.kartTasima();
                            break;
                            case 5:
                            //Board listeleme işlemine yönlendirme yapacağız.
                            BOARDLISTELEMEK.BoardListelemek();
                            break;
                            case 6:
                            //To Do Uygulamasını kapatacağız.
                            Console.WriteLine("    Güle Güle:)");
                            Environment.Exit(0);//Environment'ın Türkçesi ortam demek .Burada Environment class'ının Exit methoduna 0 verisi ile erişerek uygulamamı sonlandırıyorum.
                            break;
                            default:
                            Console.WriteLine("{0} tuşlaması yaptınız ve bu tuşlamada işlemimiz yok.Tekrar deneyiniz!");//Secim değişkenimdeki veri 1,2,3,4 veya 5 değilse switch bloğumda default(varsayılan) case(durum)'imi yürütüyorum ve kullanıcıyı giriş yaptığı değer hakkında uyarıyorum.
                            break;
                        }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Uygunsuz formatta veri girişi yaptınız.Tekrar Deneyiniz!");
                    Console.WriteLine("ENGLİSH EXCEPTİON EXPLANATION : {0}",ex.Message);//ex.Message bana FormatException exceptionın ingilizce açıklamasını verir.
                }
                Program.Main(); 
            }
 
            public static void ToDoAppMonitor()//To Do Uygulamasının ana ekranını console'a yazdırdığım method'um.
            {
                 Console.WriteLine("******************************");
                 Console.WriteLine("To Do Uygulaması Seçim Paneli:");
                 Console.WriteLine("------------------------------");
                 Console.WriteLine("(1) Board'a Kart Ekle");
                 Console.WriteLine("(2) Board'da Kart Güncelle");
                 Console.WriteLine("(3) Board'dan Kart Sil");
                 Console.WriteLine("(4) Board'da Kart Taşı");
                 Console.WriteLine("(5) Board Listele");
                 Console.WriteLine("(6) To Do Uygulamasını Kapat!");
            }
        }
    }