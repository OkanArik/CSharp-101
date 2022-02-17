using System;


    namespace Algoritma_Sorulari
    {
        class Program
        {
              public static void Main(string[] args)
            {
                //Algoritma Soruları:
                //(1)-->Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
                
                Solutions instance=new Solutions();

                Console.WriteLine("Siz bize n adet pozitif sayı verin biz size çift olanlarını dönelim:)");
                Console.Write("n:");
                if(int.TryParse(Console.ReadLine(),out int n))
                  instance.AlgoritmaSoruBir(n);


                //(2)-->Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.  
                Console.WriteLine("Siz bize pozitif iki sayı verin (n,m) , sonrasında n adet pozitif sayı verin , bizde size n adet pzoitif sayı içerisinde m'ye eşit yada tam bölünenleri verelim:");
                Console.WriteLine("n:");
                Console.WriteLine("m:");
                if(int.TryParse(Console.ReadLine(),out int na)&&int.TryParse(Console.ReadLine(),out int mb))
                  instance.AlgoritmaSoruIki(na,mb);

                
                //(3)-->Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
                Console.Write("Siz birşeyler yazın biz size onun tersini verelim:");
                string text= Console.ReadLine();
                if(!string.IsNullOrEmpty(text))
                {
                    instance.stringReverse(text);//string'i reverse ettiğim 1. method'um.
                    instance.stringReverse1(text);//string'i reverse ettiğim 2. method'um.
                    instance.stringReverse2(text);//string'i reverse ettiğim 3. method'um.                  
                }  


                //(4)-->Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
                Console.WriteLine("Siz bize bir cümle verin biz size cümledeki kelime ve harf sayısını vererlim:");
                string sentence=Console.ReadLine();
                if(!string.IsNullOrEmpty(sentence))
                   instance.sentenceProses(sentence); 



                
                
                


            }
        }

        class Solutions
        {
            public void AlgoritmaSoruBir(int n)
            {
                int[] sayiDizisi=new int[n];
                int a=0;
                for (int i = 0; i <n; i++)
                {   
                    Console.Write("Pozitif {0}. sayıyı giriniz:",i+1);
                    if (int.TryParse(Console.ReadLine(),out int sayi))
                    {
                        if(sayi%2==0)
                        {
                            sayiDizisi[a]=sayi;
                            a++;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Yanlış formatta veya boş veri girişi yaptınız.Tekrar deneyiniz!");
                        i-=1;
                    }
                }

                Array.Resize<int>(ref sayiDizisi, a);

                foreach (var item in sayiDizisi )
                        Console.Write(item+" ");
                Console.Write("\n");
            }

            public void AlgoritmaSoruIki(int n , int m)
            {   
                int[] sayiDizisi1=new int[n];
                 for (int i = 0; i <n; i++)
                {   
                    Console.Write("Pozitif {0}. sayıyı giriniz:",i+1);
                    if (int.TryParse(Console.ReadLine(),out int sayi1))
                    {
                        if(sayi1 % m == 0)
                        {
                            sayiDizisi1[i]=sayi1;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Yanlış formatta veya boş veri girişi yaptınız.Tekrar deneyiniz!");
                        i-=1;
                    }
                }

                    foreach (var item in sayiDizisi1 )
                    {
                        if(item!=0)
                          Console.Write(item+" ");
                    }
                 Console.Write("\n");
            }

            public void stringReverse(string text)
            {
                char[] karakterDizi=text.ToCharArray();
                Array.Reverse(karakterDizi);
                text=new string(karakterDizi);
                Console.WriteLine(text);
            }

            public void stringReverse1(string text)
            {
                Console.WriteLine(new string(text.Reverse().ToArray()));
            }

            public void stringReverse2(string text)
            {   
                string reverseText="";
                for (int i = text.Length - 1; i >= 0 ; i--)
                {
                    reverseText+=Convert.ToString(text[i]);
                }
                Console.WriteLine(reverseText);
            }

            public void sentenceProses(string cumle)
            {   
                if(cumle.Contains(" "))
                {   
                    int kelimeSayisi=0;
                    int harfSayisi=0;
                    string[] array=cumle.Split(" ").ToArray();
                    foreach (var item in array)
                    {
                        if(item!=string.Empty)
                        {
                            kelimeSayisi++;
                            harfSayisi+=item.Length;
                        }
                        
                    }
                    Console.WriteLine("Kelime sayısı:{0}",kelimeSayisi);
                    Console.WriteLine("Harf sayısı:{0}",harfSayisi);
                }
                else
                {
                    Console.WriteLine("Kelime sayısı:1");
                    Console.WriteLine("Harf sayısı:{0}",cumle.Length);
                }
            }
        }
    }
//*********************************************************************************************************************
  //sentence=cümle