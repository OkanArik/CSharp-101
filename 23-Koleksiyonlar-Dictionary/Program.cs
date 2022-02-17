using System;
using System.Collections.Generic;


    namespace Koleksiyonlar_Dictionary
    {
        class Program
        {
            public static void Main(string[] args)
            {
                //Bu dersimizde collections(koleksiyonlar) altında Dicitonary'lere bakacağız.Dictionaryler elemanları(verileri) anahtar(key) ve değer(value) olarak tutarlar.Bir Dictionary'yi tanımlarken onun key'i hangi tipte value'su hangi tipte onu söylüyor olmamız gerekmektedir ve kullanırkende key ve value'sına ayrı ayrı erişebiliriz.Key'ler unique(eşşiz) olmak durumundadır.Aynı key'i kullanırsanız birden fazla value için compiletime'da hata vermez lakin runtime'da hata verir o yüzden atadığımız key'lerin unique(eşşiz) olmasını dikkat etmeliyiz.Dictionary collections System.Collections.Deneric namespace'i altındadırlar.

                //*********************************************************************************************
                //***Dictionary collection syntax'ı:
                //Dictinary <keyDataType , valueDataType> dictionaryCollectionName = new Dictionary <keyDataType , valueDataType>();
                Dictionary<int,string> kullanıcılar=new Dictionary<int, string> ();//kullanıcılar adında int veri tipinde key alan string veri tipinde value alan Dictionary collection'ımızı tanımladık.
                kullanıcılar.Add(10,"Ayşe Yılmaz");
                kullanıcılar.Add(12,"Ahmet Yılmaz");
                kullanıcılar.Add(18,"Deniz Yılmaz");
                kullanıcılar.Add(20,"Özcan Coşar");

                //*********************************************************************************************
                //***Dictionary collection'ın elemanlarına erişim:
                //
                Console.WriteLine("*****Elemanlara Erişim*****");
                Console.WriteLine(kullanıcılar[12]);
                foreach (var item in kullanıcılar)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in kullanıcılar)
                {
                    Console.WriteLine(item.Key);
                }
                foreach (var item in kullanıcılar)
                {
                    Console.WriteLine(item.Value);
                }
                
                //*********************************************************************************************
                //***Count:
                Console.WriteLine("*****Count*****");
                Console.WriteLine(kullanıcılar.Count);

                //*********************************************************************************************
                //***Contains:
                Console.WriteLine("*****Contains*****");
                Console.WriteLine(kullanıcılar.ContainsKey(12));
                Console.WriteLine(kullanıcılar.ContainsValue("Okan Arık"));

                //*********************************************************************************************
                //***Remove:
                Console.WriteLine("*****Remove*****");
                kullanıcılar.Remove(12);
                foreach (var item in kullanıcılar)
                {
                    Console.WriteLine(item);
                }
                
                //*********************************************************************************************
                //***Keys:
                Console.WriteLine("*****Keys*****");
                foreach (var item in kullanıcılar)
                    Console.WriteLine(item.Key);  

                //*********************************************************************************************
                //***Values:
                Console.WriteLine("*****Values*****");
                foreach (var item in kullanıcılar)
                    Console.WriteLine(item.Value);
            }
        }
    }
//*************************************************************************************************************
//Dictionary:Sözlük
//Execute:uygulamak , gerçekleştirmek , yerine getirmek
//*************************************************************************************************************
//Dictionary Nedir ?:
//Dictionary koleksiyonunda key-value yani anahtar-deger denen 2 kavram ile karşılaşıyoruz. Dizilere eklediğimiz elemanları value, index lerini ise key olarak düşünebilirsiniz.
//Dictionary lerin elemanlarının anahtarları birbirinden farklı olmalıdır. Aynı anahtar kullanılarak 2 değer saklanamaz.

//Örnek söz dizimi şu şekildedir:
//Dictionary<Key_Veri_Tipi, Value_Veri_Tipi> dictionary_adi = new Dictionary<Key_Veri_Tipi, Value_Veri_Tipi>();
//*************************************************************************************************************
