using System;
using System.Collections;
using System.Collections.Generic;




    namespace Koleksiyonlar_ArrayList
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Bu dersimizde ArrayList' leri öğreneceğiz.ArrayList'ler bir koleksiyon tipidir.Koleksiyonlardan bahsederken tek bir veri tipini değil birden fazla veri tipini kendi içerisinde barındırabilen dinamik yapılar olarak bahsetmiştik ,tam olarak bu bahisin karşılığı ArrayList'tir.ArrayList'tin içerisinde birden fazla veri tipini aynı anda saklayabiliriz ve dinamik olarak büyüyüp küçülen yapılar olarak düşünülebilir.Namespace olarakta System.Collections namespace'i altında bulunur.

                //*********************************************************************************************
                ArrayList myFirstArrayList=new ArrayList();//myFirstArrayList adında ArrayList oluşturdum.
                myFirstArrayList.Add("Ayşe");//MyFirstArrayList adındaki ArrayList'imin içerisine string veri tipinde eleman ataması yaptım
                myFirstArrayList.Add(2);//MyFirstArrayList adındaki ArrayList'imin içerisine int(integer) veri tipinde eleman ataması yaptım
                myFirstArrayList.Add(true);//MyFirstArrayList adındaki ArrayList'imin içerisine bool(boolean) veri tipinde eleman ataması yaptım
                myFirstArrayList.Add('A');//MyFirstArrayList adındaki ArrayList'imin içerisine char(character) veri tipinde eleman ataması yaptım
                
                //*********************************************************************************************
                //***ArrayList içerisindeki verilere erişim;
                Console.WriteLine(myFirstArrayList[1]);//myFirstArrayList adındaki ArrayList'imin 1. index'indeki elamanı(veriyi) console'a yazdırdım.
                foreach (var item in myFirstArrayList)
                        Console.WriteLine(item);
                
                //*********************************************************************************************
                //***ArrayList class'ında kullanacabileceğimiz bazı özel methodlar var:
                //***AddRange:Birden fazla elemanı ArrayList'e eklemek için kullandığımız methoddur:
                Console.WriteLine("*****AddRange*****");
                string[] colors={"kırmızı","beyaz","turkuaz"};//colors adında string tipinde dizi yarattık ve içerisine 3 eleman(veri) ataması(assignment) yaptık.
                List<int> numbers=new List<int>(){1,3,8,7,9,92,5};//numbers adında int(integer) tipinde elaman(veri) tutan bir GenericList tanımladık ve 7 adet değer assign ettik.
                myFirstArrayList.AddRange(colors);//colors adında string tipinde eleman tutan dizimi myFirstArrayList adındaki ArrayList'ime assign ettim.
                myFirstArrayList.AddRange(numbers);//number adında integer tipinde eleman tutan GenericList'imi myFirstArrayList adındaki ArrayList'ime assign ettim.
                foreach (var item in myFirstArrayList)
                        Console.WriteLine(item);

                //*********************************************************************************************
                //**Sort:Sıralama 
                //ArrayList'lerin içerisine her tipten value(değer) atabiliyor olmamız ve büyüyebiliyor olması bazı noktalarda kontrolsüz bir durum şu anda myFirstArrayList ArrayList'imi direk sort(sıralama)'lamaya kalkarsam compiletime'da hata vermez lakin runtime'da patlar.Çünkü sıralamak için elemanları kendi içerisinde compare(karşılaştırma) yapması gerekecek farklı türdeki elamanları compare demez exception(sıradışı durum) döner yani hata verir.O yüzden sort'lama method'nu sadece aynı veri tipinde eleman tutan ArrayList'lerde kullanabiliriz.
                Console.WriteLine("*****Sort*****");
                ArrayList colorsArrayList=new ArrayList();
                ArrayList numbersArrayList=new ArrayList();
                colorsArrayList.AddRange(colors);
                numbersArrayList.AddRange(numbers);
                colorsArrayList.Sort();
                numbersArrayList.Sort();
                foreach (var item in colorsArrayList)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in numbersArrayList)
                {
                    Console.WriteLine(item);
                }
  
                //*********************************************************************************************
                //***BinarySearch:ArrayList içerisinde aradığımız elemanın index'ine erişim sağlarız BinearySearch ile ancak BinearySearch'ü kullanmadan önce ArrayList'i sort etmemiz gerekmektedir.
                Console.WriteLine("*****BinearySearch*****");
                Console.WriteLine(colorsArrayList.BinarySearch("kırmızı"));
                Console.WriteLine(numbersArrayList.BinarySearch(9));

                //*********************************************************************************************
                //***Reverse:tam olarak ortadan aynalama,ters çevirme
                Console.WriteLine("*****Reverse*****");
                colorsArrayList.Reverse();
                numbersArrayList.Reverse();
                foreach (var item in colorsArrayList)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in numbersArrayList)
                {
                    Console.WriteLine(item);
                }

                //*********************************************************************************************
                //***Clear:ArrayList'i temizlemek için kullanırız.
                Console.WriteLine("*****Clear*****");
                myFirstArrayList.Clear();
                if(myFirstArrayList.Count==0)
                {
                    Console.WriteLine("MyFirstArrayList adındaki ArrayList Clear edildi!");
                }
            }  
        }
    }
//*************************************************************************************************************
//***ArrayList Nedir ?:
//Standart dizilerde aynı tipte verileri bir arada tutabileceğimizi ve dizinin boyutunun belirtilmesi gerektiğinden bahsetmiştik. Arraylist tam olarak bu noktada farklılaşıyor. Farklı veri tiplerini array list içerisinde saklayabilirsiniz. Ve eleman ekleyerek ve çıkararak boyutunu dinamik olarak değiştirebilirsiniz.
//Varsayılan boyutu başlangıç olarak 4'tür. Aşıldığından otomatik olarak 2 katına çıkarılır. Yani bir array liste 5. elemanı eklemeye calıştıgınızda arka planda boyutunun 8'e çıkarır.
//Değişken veri tipi kullanımı kulağa ilk etapta çok konforlu gelse de risk barındırır. Listeden okudugunuz verinin tipinin ne olduğunu bilmemek güvenli bir yaklaşım değildir. Tip dönüşümleri sırasında hata ihtimalini arttırır.