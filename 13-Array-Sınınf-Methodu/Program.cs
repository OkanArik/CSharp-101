using System;


    namespace Array_Sınıfı_Methodları
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //***Array Sınıfı(class) Methodları:***************
                    //C Sharp'taki diziler array sınıfından türüyor aslında, dolayısıyla array sınıfı bize dizilerle kullanabiliceğimiz faydalı methodlar sunuyor.

                    //***Array.Sort:Array class'ının Sort(sıralama) Methodu
                    int[] sayiDizisi={23,12,4,86,72,3,11,17};//sayiDizisi adında integer veri tipinde veri alan bir dizi tanımladık ve  eleman atamasıylada bir diziyi kullanmadan önce büyüklüğü belirtme gereksinimi 8 eleman atayarak belirttik başka bir deyişle büyüklüğünü 8 olarak belirttik.

                    string[] animals={"Cat","Dog","Monkey"};
                    
                    Console.WriteLine("*****Sırasız Dizi*****");
                    foreach (var sayi in sayiDizisi)
                    {
                        Console.WriteLine(sayi);
                    }
                    
                    //***Array.Sort:
                    Console.WriteLine("*****Array.Sort*****");
                    Console.WriteLine("*****Sıralı Dizi*****");
                    Array.Sort(sayiDizisi);
                    Array.Sort(animals);
                    foreach (var sayi in sayiDizisi)
                    {
                        Console.WriteLine(sayi);
                    }
                    foreach (var animal in animals)
                    {
                        Console.WriteLine(animal);
                    }
                    
                    //***Array.Clear:Verdiğimiz dizi içerisinde verdiğimiz index'ten başlayarak vediğimiz sayıdaki elamanları siler.
                    Console.WriteLine("*****Array.Clear*****");
                    Array.Clear(sayiDizisi,2,2);//Burada sayiDizisi dizisinin 2. indexten başlayarak 2 elemanını sildik yani 2. ve 3. index'lerdeki elemanlarını sildik.Burada silme işlemi index'teki elemanı default'a çevirmektir , integer veri tipi içinde default değer 0'dır.
                    foreach (var sayi in sayiDizisi)
                            Console.WriteLine(sayi);
                    

                    //***Array.Reverse:Verdiğimiz diziyi ortadan itibaren aynalıyormuş gibi yer değiştiriyor yani diziyi tersine çeviriyor.
                    Console.WriteLine("*****Array.Reverse*****");
                    Array.Reverse(sayiDizisi);
                    foreach (var sayi in sayiDizisi)
                            Console.WriteLine(sayi);

                    //***Array.IndexOf:Verdiğimiz dizi içersinde verdiğimiz eleman var ise o elemanın sakladnığı index numarasını döner.
                    Console.WriteLine("*****Array.IndexOf*****");
                    Console.WriteLine(Array.IndexOf(sayiDizisi,23));//23 elemanı sayiDizisi dizisinin 2.indextinde olduğundan bu satır ile Console'a 2 yazdırmış olduk.
                    Console.WriteLine(Array.IndexOf(sayiDizisi,555));//555 elemanı sayiDizisi dizisinin elemanı olmadığından Console'a -1 yazdırmış olduk.
                    Console.WriteLine(Array.IndexOf(sayiDizisi,0));//0 elemanı sayıDizisi dizisinin 4. ve 5.indexlerinde saklanmaktadır ve burada bize 0.indexten hareket ederek ilk ulaştığı index'i yani 4.index'i gördü ve Console'a 4 yazdırmış olduk.

                    //***Array.Resize:Verdiğimiz diziye yeniden boyutlandırma yapmak için kullanırız.
                    Console.WriteLine("*****Array.Resize*****");
                    Array.Resize<int>(ref sayiDizisi,9);//Array.Resize<dizimizin tipi>(ref dizimiz,boyut):Burada sayiDizisi dizimizin boyutunu 9 olarak güncelledik.
                    sayiDizisi[8]=99;//Burada sayiDizisi dizisinin 8.index'ine yani 9. elamanına 99 değerini atadık.
                    foreach (var sayi in sayiDizisi)
                    {
                        Console.WriteLine(sayi);
                    }

                    Console.WriteLine("***************************");
                    Array.Resize<int>(ref sayiDizisi,5);
                    foreach (var sayi in sayiDizisi)
                    {
                        Console.WriteLine(sayi);
                    }
            }
        }
    }
//*******************************************************************************************

    //***Array Sınıfı ve Methodlari:
     //Diziler System.Array sınıfından türerler. Array sınıfı da dizilerle yapılan işlemleri kolaylaştırmak için bir takım static hazır metotlar sunar. Bu metotlardan en sık kullanılan birkaçına yakından bakalım.

    //***Array.Sort:
     //Diziler üzerinden sıralama işlemi yapar. Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar. Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.

    //***Array.Clear:
     //Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
    
    //***Array.Reverse:
     //Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

    //***Array.IndexOf:
     //Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.

    //***Array.Resize:
     //Dizileri yeniden boyutlandırmak için kullanılır.
       // int[] sayiDizisi = {1,3,4,9,8,7};
       // Array.Resize<int>(ref sayiDizisi,12);
       // sayiDizisi[6] = 10;
     // Yukarıdaki örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 12 elemanlı hale getirildi. Daha sonra 7. elemanına 10 değeri atandı. Diğer boş olan indexlerin değeri ise varsayılan olarak 0 atanır.
       // int[] sayiDizisi = {1,3,4,9,8,7};
       // Array.Resize<int>(ref sayiDizisi,3);
     // Yukarıdaki örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 3 elemanlı hale getirildi. sondaki 3 eleman kırpıldı. Artık dizi şu şekilde: {1,3,4}