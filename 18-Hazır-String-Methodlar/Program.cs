using System;
  
  
   namespace Hazır_String_Methodlar
   {
       class Program
       {
           public static void Main(string[] args)
           {
               //Bu dersimizde hazır method'lardan string kütüphanesinin method'larına ve property'lerine bakacağız.String kütüphanesinin detaylarını bilmek sayesinde normalde birden fazla kod satırında yapabileceğimiz kod işlemlerini, string kütüphanesinin güçlü özelliklerinden faydalanarak çok daha kısa kod satırlarıyla , çok daha okunabilir şekilde gerçekleştirebiliriz.
               //*****************************************************************************************************************************************************************************************
               string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
               string degisken1= "Dersimiz CSharp";
               string degisken2= "Dersimiz CSharp, abcdefglmnp!";
               string degisken3= "Dersimiz CSharp, Hoşgeldiniz!";
               string degisken4= "Dersimiz CSharp, Şimdi Dersimize Başlayalım!";
               string degisken5= "Dersimiz CSharp, hoşgeldiniz!";
               string degisken6= "CSharp";
               string degisken7=string.Concat(degisken," ",degisken1);//degisken ve degisken1 degiskenlerini aralarında bir adet whitespace bırakarak birleştirdik ve degisken7 degiskenine atadık.
               //******************************************************************************************************************************************************************************************
               Console.WriteLine(degisken);
               Console.WriteLine(degisken1);
               Console.WriteLine(degisken2);
               Console.WriteLine(degisken3);
               Console.WriteLine(degisken4);
               Console.WriteLine(degisken5);
               Console.WriteLine(degisken6);
               Console.WriteLine(degisken7);//Output: Dersimiz CSharp, Hoşgeldiniz! Dersimiz CSharp
               //*******************************************************************************************************************************************************************************************
               

               //***Length:string bir değişkenin karakter sayısına ulaşmak için kullanırız.//Length:uzunluk
               //karakterSayisiniOgrenmekIstedigimDegisken.Length
               Console.WriteLine("*****Length*****");
               Console.WriteLine(degisken.Length);//Burada degisken.Length ile degisken degiskeninin karakter(character) sayısına ulaştık.//Output: 29
               Console.WriteLine(degisken1.Length);//Output: 15
               Console.WriteLine(degisken2.Length);//Output: 29
               Console.WriteLine(degisken3.Length);//Output: 29
               Console.WriteLine(degisken4.Length);//Output: 44
               Console.WriteLine(degisken5.Length);//Output: 29
               Console.WriteLine(degisken6.Length);//Output: 6
               Console.WriteLine(degisken7.Length);//Output: 45
               //*******************************************************************************************************************************************************************************************

               //***ToUpper/ToLower:string bir değişkenin tüm karakterlerini büyük yapmak için ToUpper'ı , tüm karakterlerini küçük yapmak için ToLower'ı kullanırız.
               //tumKarakterleriniBuyukKarakterYapmakIstedigimizDegisken.ToUpper()
               //tumKarakterleriniKucukKarakterYapmakIstedigimizDegisken.ToLower()
               Console.WriteLine("*****ToUpper/ToLower*****");
               Console.WriteLine(degisken.ToUpper());//Output: DERSİMİZ CSHARP, HOŞGELDİNİZ!
               Console.WriteLine(degisken.ToLower());//Output: dersimiz csharp, hoşgeldiniz!
               //*******************************************************************************************************************************************************************************************

               //***Concat:
               Console.WriteLine("*****string.Concat*****");
               Console.WriteLine(string.Concat(degisken," Merhaba"));//Output: Dersimiz CSharp, Hoşgeldiniz! Merhaba
               Console.WriteLine(string.Concat("Merhaba ",degisken));//Output: Merhaba Dersimiz CSharp, Hoşgeldiniz!
               Console.WriteLine(string.Concat("Merhaba ",degisken," Başlayalım."));//Output: Merhaba Dersimiz CSharp, Hoşgeldiniz! Başlayalım.
               //*******************************************************************************************************************************************************************************************

               //***Compare/CompareTo: //Compare:Karşılaştırmak
               //CompareTo:*Birinci değişken , ikinci değişkene eşit ise(yani aynısı ise) 0 döndürür./*Birinci değişkenin karakter sayısı , ikinci değişkenin karakter sayısından büyük veya eşit ise 1 döndürür./*Birinci değişkenin karakter sayısı , ikinci değişkenin karakter sayısından küçük ise -1 döndürür.
               //birincidegisken.CompareTo(ikincidegisken)
               Console.WriteLine("*****CompareTo*****");
               Console.WriteLine(degisken.CompareTo(degisken1));//Output: 1
               Console.WriteLine(degisken.CompareTo(degisken2));//Output: 1
               Console.WriteLine(degisken.CompareTo(degisken3));//Output: 0
               Console.WriteLine(degisken.CompareTo(degisken4));//Output:-1
               Console.WriteLine(degisken.CompareTo(degisken5));//Output: 1
               Console.WriteLine(degisken.CompareTo(degisken6));//Output: 1
               Console.WriteLine(degisken.CompareTo(degisken7));//Output:-1
               //********************************************************************************************************************************************************************************************

               //string.Compare(birincidegisken,ikincidegisken,ignorecase) 
               //ignorecase'e true dersek  karşılaştırma yaparken büyük küçük harf duyarsız duruma gelir , false dersek  karşılaştırma yaparken büyük küçük harf duyarlı hale gelir.
               Console.WriteLine("*****string.Compare*****");
               Console.WriteLine(string.Compare(degisken,degisken5,true));//Output: 0
               Console.WriteLine(string.Compare(degisken,degisken5,false));//Output: 1
               Console.WriteLine(string.Compare(degisken,degisken3,true));//Output: 0
               Console.WriteLine(string.Compare(degisken,degisken3,false));//Output: 0
               //*********************************************************************************************************************************************************************************************
               
               //Contains //contains:içerir
               Console.WriteLine("*****Contains*****");
               Console.WriteLine(degisken.Contains(degisken6));//birincidegiskenin ,ikinci değişkeni içerip içermediğini soruguluyoruz bu örnekte,birinci değişkenin içerisinde ikinci değişken olduğundan True geri dönüşü alacağız.
               //*********************************************************************************************************************************************************************************************
               
               //EndsWith/StartsWith
               Console.WriteLine("*****EndsWith/StartsWith");
               Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));//Output: True
               Console.WriteLine(degisken.EndsWith("!"));//Output: True
               Console.WriteLine(degisken.EndsWith("z!"));//Output: True
               Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));//Output: False
               Console.WriteLine(degisken.StartsWith("Dersimiz"));//Output: True
               Console.WriteLine(degisken.StartsWith("Der"));//Output: True
               Console.WriteLine(degisken.StartsWith("Dersimize"));//Output: False
               Console.WriteLine(degisken.StartsWith("CSharp"));//Output: False
               //*********************************************************************************************************************************************************************************************

               //IndexOf
               Console.WriteLine("*****IndexOf*****");
               Console.WriteLine(degisken.IndexOf("CSh"));//degisken de CSh ı bulacak ve bulmasını istediğim verinin başladığı  index i  geri dönecek yani C nin bulunduğu index i dönecek.//Output: 9
               Console.WriteLine(degisken.IndexOf("C"));//Output: 9
               Console.WriteLine(degisken.IndexOf("!"));//Output: 28
               Console.WriteLine(degisken.IndexOf("Hoşgeldsiniz!"));//degişken de böyle bir veri bulamadığı için -1 geri dönüşü yaptı.
               Console.WriteLine(degisken.IndexOf("Okan"));//degişken de böyle bir veri bulamadığı için -1 geri dönüşü yaptı.
               Console.WriteLine(degisken.IndexOf("Hoşgeldiniz!"));//Output: 17
               Console.WriteLine(degisken.IndexOf(" "));//Output: 8
               Console.WriteLine(degisken.LastIndexOf("i"));//Bu şekilde string tipindeki degisken değişkenimizin verisinde i verisinin son bulunduğu indexi sorugularız ve bize i verisinin son bulunduğu index numarasını döner.
               Console.WriteLine(degisken.IndexOf("i"));//Output: 4
               //**********************************************************************************************************************************************************************************************

               //Insert //insert:eklemek
               Console.WriteLine("*****Insert*****");
               Console.WriteLine(degisken.Insert(0,"Merhaba! "));//Bu şekilde string tipindeki degisken değişkenimizdeki veriye 0. indexten başlayarak Merhaba!  verisini ekleriz.//Merhaba! Dersimiz CSharp, Hoşgeldiniz!
               //*********************************************************************************************************************************************************************************************

               //Padleft/Padright
               Console.WriteLine("*****PadLeft*****");
               Console.WriteLine(degisken + degisken2.PadLeft(30));//Burada string tipi degisken2 değişkeninin index sayısını 30 tamamladık bunu degisken2 değişkeninin soluna boşluk ekleyerek yaptık ve degisken+degisken.PadLeft(30) u konsolda yazdırdık.
               Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));//Burada string tipi degisken2 değişkeninin index sayısını 30 tamamladık bunu degisken2 değişkeninin soluna * ekleyerek yaptık ve degisken+degisken.PadLeft(30) u konsolda yazdırdık.
               Console.WriteLine("*****PadRight*****");
               Console.WriteLine(degisken.PadRight(40)+degisken2);//Burada string tipi degisken değişkeninin index sayısını 40 tamamladık bunu degisken değişkeninin sağına boşluk ekleyerek yaptık ve degisken.PadRight(40)+degisken2 yi konsolda yazdırdık.Eğer 40 değilde bu sayıyı degisken değişkeninin index sayısından küçük verseydik o zaman degisken değişkeninde hiç bir değişiklik yapmayacaktı.
               Console.WriteLine(degisken.PadRight(40,'+')+degisken2);//Burada string tipi degisken değişkeninin index sayısını 40 tamamladık bunu degisken değişkeninin sağına + ekleyerek yaptık ve degisken.PadRight(40)+degisken2 yi konsolda yazdırdık.Eğer 40 değilde bu sayıyı degisken değişkeninin index sayısından küçük verseydik o zaman degisken değişkeninde hiç bir değişiklik yapmayacaktı.
               //*********************************************************************************************************************************************************************************************

               //Remove //remove:kaldırmak,çıkarmak
               Console.WriteLine("*****Remove*****");
               Console.WriteLine(degisken.Remove(10));//burada string tipindeki degisken değişkenindeki verinin 10. indexten itibaren kaldırır.
               Console.WriteLine(degisken.Remove(5,3));//5. indexten itibaren 3 karakter siler yani 5. , 6. ve 7. indexteki verileri kaldırır.
               Console.WriteLine(degisken.Remove(0,1));//İlk karakteri kaldırır.
               Console.WriteLine(degisken.Remove(degisken.Length-1));//Son karakteri kaldırır.
               //**********************************************************************************************************************************************************************************************

               //Replace //replace:yenisiyle değiştirmek,yer değiştirmek
               Console.WriteLine("*****Replace*****");
               Console.WriteLine(degisken.Replace("CSharp","C#"));//CSharp yerine C# yazar.
               Console.WriteLine(degisken.Replace(" ","*"));//whitespace leri * yapar.
               //**********************************************************************************************************************************************************************************************

               //Split  //split:parçalamak,ayırmak
               Console.WriteLine("*****Split*****");
               Console.WriteLine(degisken.Split(' ')[1]);//Burada string tipindeki degisken değişkenimizdeki veriyi birer index e parçalayarak dizi haline getirdik ve dizinin 1. indexini konsola yazdırdık.
               Program instance=new Program();
               instance.karakterKarakterDizi();
               instance.kelimeKelimeDizi();
               //**********************************************************************************************************************************************************************************************

               //Substring //substring:alt dize
               Console.WriteLine(degisken.Substring(4));//Burada string tipindeki degisken değişkenindeki verinin 4. indexinden itibaren konsola yazdırdık.
               Console.WriteLine(degisken.Substring(4,6));//Burada string tipindeki degisken değişkenindeki verininde 4. indexten başlayarak 6 indexini konsola yazdırdık,yani 4. , 5. ve 6. index'i konsola yazdırdık.
               //**********************************************************************************************************************************************************************************************

           }

           public void karakterKarakterDizi()
           {
               Console.WriteLine("Karakterler halinde diziye çevirmek istediğiniz cümleyi giriniz:");
               string cumle=Console.ReadLine();
               if(!string.IsNullOrEmpty(cumle))
               {   
                   while (cumle.Contains(' '))
                   {
                       cumle=cumle.Remove(cumle.IndexOf(' '),1);
                   }
                   char[] array=cumle.ToCharArray();
                   foreach (var item in array)
                   {
                       Console.WriteLine(item);
                   }
               }
           }

            public void kelimeKelimeDizi()
           {
               Console.WriteLine("Kelimeler halinde diziye çevirmek istediğiniz cümleyi giriniz:");
               string cumle=Console.ReadLine();
               if(!string.IsNullOrEmpty(cumle))
               {   
                   string[] array=cumle.Split(" ").ToArray();
                   foreach (var item in array)
                   {
                       Console.WriteLine(item);
                   }
               }
           }
       }
   }
//********************************************************************
   //    ignore: göz ardı etmek
   //    ignore case: vakayı yoksay , durumu yoksay
//********************************************************************