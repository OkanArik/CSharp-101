using System;

  
    namespace Interface
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Bu dersimizde arayüzlere bakacağız yani interface'ler.Interface'ler nesneye dayalımlı programlamanın en önemli özelliklerinden bir tanesidir.Interface'ler sınıfların içermesi gereken metotların imzalarının yer aldığı, özelliklerin tanımladığı bir taslak gibi düşünülebilir.Kesin belirlenmiş bir kural yok bu konuyla alakalı fakat interfaceler genellikle büyük I harfiyle başlarlar.
                //*******************************************************************************

                FileLogger fileLogger=new FileLogger();
                fileLogger.WriteLog();

                DataBaseLogger dataBaseLogger=new DataBaseLogger ();
                dataBaseLogger.WriteLog();

                SmsLogger smsLogger=new();//Burada SmsLogger class'ının smsLogger adında nesnesini yarattık.
                smsLogger.WriteLog();

                LogManager logManager=new LogManager (new FileLogger());
                logManager.WriteLog();
            }
        }
    }
//***********************************************************************************************
//Interface (Arayüzler):
//Interface yani arayüzler nesneye dayalı programlamanın önemli özelliklerinden biridir. Sınıfların içermesi gereken metotların imzalarının yer aldığı, özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.
//Kesin belirlenmiş bir kural olmamasıyla beraber interface isimleri "I" ile başlar. I ile başlayan bir isim gördüğümüzde kolaylıkla bunun bir arayüz olduğunu anlarız. Dolayısıyla standartlara bağlı kalmakta fayda var.
//Interface içerisindeki property'lere bir değer ataması yapılmaz, metotların ise gövdesi yazılmaz. Sadece implemente eden sınıfın ne iş yaptığının bir arayüzüdür interface'ler. Ve bir sınıf aynı anda birden fazla arayüzden kalıtım alabilir.
//Peki interface'lere neden ihtiyaç duyarız? Kalıtım alan sınıfın sorumluluğunun çerçevesinin çizilmesine yardımcı olur diyebilir. Aynı sorumluluğu başka bir yoğurt yiyiş tarzıyla yapması gereken bir sınıf geldiğinde aynı interface den kalıtım alır ama yapacağı işi farklı şekilde yapar.
//***********************************************************************************************
//Örnek interface tanımı:

    // public interface ILogger{
    //     //sadece imzası
    //     void WriteLog();
    // }

 //Implementasyon:

    // public class FileLogger : ILogger
    // {
    //     public void WriteLog()
    //     {
    //         Console.WriteLine("Dosyaya yazdım.");
    //     }
    // }
    
    // public class DatabaseLogger : ILogger
    // {
    //     public void WriteLog()
    //     {
    //         Console.WriteLine("Database'e yazdım.");
    //     }
    // }
//***********************************************************************************************