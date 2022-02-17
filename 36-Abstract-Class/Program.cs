using System;

 
    namespace Abstract_Class
    {   
        //Abstract Class'lar sadece kalıtım için kullanılan sınıflar gibi düşünülebilir.Bazı özellikleri ile sınıflara çok benzerlerken bazı özellikleri ile interfacelere çok benzerler.Normal sınıflar gibi new anahtar kelimesi ile türetilemezler, bir nesneleri yaratılamazlar.İnterfaceler ve abstractlar tek başlarına anlamları olan yapılar değillerdir, mutlaka bir sınıf üzerinden türetilmeleri gerekmektedir.İnterfaceler gibi abstractlardada gövdesini yazmadan method bildirimi yapabiliriz.Virtual methodları override eder gibi abstract methodlar override edilebilir.Bir sınıf sadece tek bir abstract sınıftan kalıtım alabilir.Abstract sınıf başka sınıftan kalıtım alabilir ve bu başka sınıftan kalıtım alan abstract sınıftandan normal sınıf kalıtım alırsada bu normal sınıf iki abstract sınıftan kalıtım almış olur bu çözüm çok tercih edilmez lakin gerekirse kullanılır.
        class Program
        {
            public static void Main(string[] args)
            {
                
                NewMazda3 newMazda3=new();
                Console.WriteLine(newMazda3.HangiMarkanınAracı().ToString());
                Console.WriteLine(newMazda3.KacTekerlektenOlusur());
                Console.WriteLine(newMazda3.StandartRengiNe().ToString());

                Console.WriteLine("****************************");

                NewCivic newCivic=new NewCivic();
                Console.WriteLine(newCivic.HangiMarkanınAracı().ToString());
                Console.WriteLine(newCivic.KacTekerlektenOlusur());
                Console.WriteLine(newCivic.StandartRengiNe().ToString());

                Console.WriteLine("****************************");

                NewCorolla newCorolla=new NewCorolla();
                Console.WriteLine(newCorolla.HangiMarkanınAracı().ToString());
                Console.WriteLine(newCorolla.KacTekerlektenOlusur());
                Console.WriteLine(newCorolla.StandartRengiNe().ToString());


            }
        }
    }
//***********************************************************************************************
// Abstract Class:
// Abstract class ları sadece kalıtım için kullanılan sınıflar gibi düşünebilirsiniz. Bazı özellikleri ile sınıflara benzerlerken bazı özellikleriyle arayüzlere benzerler. Abstract sınıfları arayüz ve virtual metotların birleşimi gibi davranış gösterirler.

  // Kısaca abstract sınıfların özelliklerine bakacak olursak:
     // Normal sınıflar gibi new() anahtar kelimesi ile türetilemezler.
     // Interface ler gibi metot bildirimi yapabilirsiniz.
     // Sanal metotları override eder gibi abstract metotlar override edilebilir.
     // Abstract metotların gövdesi yazılamaz.
     // Bir abstract class bir abstract metot içeriyorsa, abstract sınıftan türeyen tüm sınıflar bu metodu override etmek zorundadır.
     // Bir sınıf sadece tek abstract sınıftan kalıtım alabilir.
     // Abstract sınıf başka bir abstract sınıftan kalıtım alabilir. Dolaylı olacak türeyen sınıfta birden fazla abstract dan kalıtım almış olur. Ve bağlantılı olduğu tüm abstract sınıfların bildirimi yapılmış olan abstract metotlarını override etmek zorundadır.

// ÖNEMLI: Abstract sınıf içerisinde metot bildirimi yapabilmek için metodun erişim belirtecinden sonra "abstract" anahtar kelimesi mutlaka yazılmalıdır.

// ÖNEMLI: Abstract metotdan türetilmiş sınıf içerisinde abstract metodun kullanılabilmesi için de override anahtar kelimesinin kullanılması gerekir.
//***********************************************************************************************