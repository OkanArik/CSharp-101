// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System;

    namespace Cumle 
    {
        class Program
        {
            static void Main(string[] args)
            {
                


                Console.Write("Cümle Giriniz: ");
                string cumle = Console.ReadLine();
                char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü','A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
                int i = 0;
                foreach(char karakter in cumle)
                foreach(char sesli in sesliler)
                if(karakter == sesli)
                {   
                    char [] sesliharf= new char[cumle.Length];
                    sesliharf[i]= sesli ; 
                    i++;
                    Console.Write(sesli+" ");
                }                
            }
            
        }
        
    }