//Polymorphism:Çok Biçimcilik
using System;


    namespace Polymorphism
    {
        class Program
        {
            //Bu dersimizde OOP'nin önemli prensiplerinden birisi olan polymorphism'i konuşacağız.Polymorphism çok biçimcilik demek , çok biçimcilik hayatımıza sanal yani virtual keyword'ü giriyor.Nesneye yönelimli programlama yaparken çok biçimcilik özelliğini virtual keyword'ü ile sağlıyoruz.Virtual anahtar kelimesini methodlarda kullanıyoruz.Virtual anahtar kelimesi ile sanal methodlar yaratıyoruz.Sanal methodlar miras veren üst sınıf içerisinde yazılan ve altsınıflar içerisinde yeniden yazılabilen ,biçimi değiştirilerek , biçimine yeni birşeyler katılarak yada biçimi tamamen değiştirilerek yazılabilen methodlardır.Üst sınfıtaki virtual methoduma alt sınıfta ovirride keyword'ü  ile poliymorphism uygularım.
            public static void Main(string[] args)
            {
                Console.WriteLine("*****TohumluBitkiler*****");
                TohumluBitkiler tohumluBitki=new TohumluBitkiler();
                tohumluBitki.TohumlaÇoğalma();

                Console.WriteLine("*****Kuslar*****");
                Kuslar martı=new Kuslar();
                martı.UcarakHareketEderler();
            }
        }
    }
//***********************************************************************************************
//Polymorphism (Çok Biçimcilik):
//Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır. Bunu da virtual ve override anahtar kelimeleri sağlar.
//***********************************************************************************************
//Virtual metot tanımı :

// public virtual void UyaranlaraTepki(){
//     Console.WriteLine("Canlılar uyaranlara tepki verir.");
// }
//***********************************************************************************************

//Alt sınıf içerisinde override metot kullanımı:

// public override void UyaranlaraTepki()
// {
//     base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
//     Console.WriteLine("Bitkiler güneşe tepki verir.");
// }
//***********************************************************************************************
//*******************SEALED KEYWORD'Ü************************************************************
//Seald anahtar kelimesi class'lar ile kullanılır.Eğer bir sınıfın başka sınıflar tarafından türetilmesini engellemek istiyorsak yani kalıtım vermesini engellemek istiyorsak bunu sealed anahtar kelimesi ile yapıyoruz.Sealed keyword'ü erişim belirtecinden sonra  kullanılır.
//***********************************************************************************************