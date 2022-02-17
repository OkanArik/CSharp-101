using System;
  
   
    namespace Hazır_DateTime_ve_Math_Sınıfları
    {
        class Program
        {
            public static void Main(string[] args)
            {
            //*******************************************************************************
              //***DateTime ve Math Kütüphanesi:
              //DateTime bizim günlük yazılım geliştirirken çok fazla kullandığımız bir kütüphanedir.DateTime ve Math class'larının property ve methodlarını bilmek bize mükemmel bir güç sağlar.

            //*******************************************************************************
                Console.WriteLine("*****DateTime Kütüphanesi*****");
                Console.WriteLine(DateTime.Now);//DD.MM.YYYY  hh.mm.ss //DateTime.Now ile kodu çalıştırdığımız andaki tarih(date) ve zamana(time) erişiriz.
                Console.WriteLine(DateTime.Now.Date);//DD.MM.YYYY 00.00.00
                Console.WriteLine(DateTime.Now.Day);//DD(day)
                Console.WriteLine(DateTime.Now.Month);//MM(month)
                Console.WriteLine(DateTime.Now.Year);//YYYY(year)
                Console.WriteLine(DateTime.Now.Hour);//hh(hour)
                Console.WriteLine(DateTime.Now.Minute);//mm(minute)
                Console.WriteLine(DateTime.Now.Second);//ss(second)
                Console.WriteLine(DateTime.Now.Millisecond);//milisecond
            //*******************************************************************************
                Console.WriteLine(DateTime.Now.DayOfWeek);//Kodu çalıştırdığğımız andaki haftanın gününü string haline gitirir ve konsola yazdırır.
                Console.WriteLine(DateTime.Now.DayOfYear);//kodu çalıştırdığımız andaki içinde bulunduğumuz yılın kaçıncı gününde olduğumuzu konsola yazdıdır.
            //*******************************************************************************
                Console.WriteLine(DateTime.Now.ToLongDateString());//instance:2 Ocak 2022 Pazar
                Console.WriteLine(DateTime.Now.ToShortDateString());//instance:2.01.2022
                Console.WriteLine(DateTime.Now.ToLongTimeString());//instance:15:48:38 // hh.mm.ss
                Console.WriteLine(DateTime.Now.ToShortTimeString());//instance:15:48  //hh.mm
            //*******************************************************************************
                Console.WriteLine(DateTime.Now.AddDays(2));//Su anki tarihe 2 gün ekler.
                Console.WriteLine(DateTime.Now.AddHours(3));//Su anki saate 3 saat ekler.
                Console.WriteLine(DateTime.Now.AddMinutes(21));//Su anki dakikaya 21 dakika ekler.
                Console.WriteLine(DateTime.Now.AddSeconds(35));//Su anki saniyeye 35 saniye ekler.
                Console.WriteLine(DateTime.Now.AddMonths(5));//Su anki aya 5 ay ekler.
                Console.WriteLine(DateTime.Now.AddYears(10));//Su anki yıla 10 yıl ekler.
                Console.WriteLine(DateTime.Now.AddMilliseconds(2000));//Su anki saniyeye  2 saniye  ekler.
            //*******************************************************************************
              //***DateTime Format:
                Console.WriteLine(DateTime.Now.ToString("dd"));//Ayın kaçıncı gününde olduğumuzu integer olarak döner.//instance:24
                Console.WriteLine(DateTime.Now.ToString("ddd"));//Haftanın hangi gününde olduğumuzu string olarak 3 karakter halinde döner.//instance:Sat(Saturday)
                Console.WriteLine(DateTime.Now.ToString("dddd"));//Haftanın hangi gününde olduğumuzu string olarak  döner.//instance:Saturday
                Console.WriteLine(DateTime.Now.ToString("MM"));//Yılın kaçıncı ayında olduğumuzu integer olarak  döner.//instance:04
                Console.WriteLine(DateTime.Now.ToString("MMM"));//Yılın hangi ayında olduğumuzu string olarak 3 karakter halinde döner.//instance:Apr(April)
                Console.WriteLine(DateTime.Now.ToString("MMMM"));//Yılın hangi ayında olduğumuzu string olarak  döner.//instance:April
                Console.WriteLine(DateTime.Now.ToString("yy"));//Hangi yılda  olduğumuzu integer olarak son iki degerini  döner.//instance:22
                Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022
            //*******************************************************************************
              //***Math Kütüphanesi:
                Console.WriteLine("*****Math Kütüphanesi*****");
                Console.WriteLine(Math.Abs(-13));//13 //Abs:abslute:mutlak//Mutlak değerini aldık ve konsola yazdırdık.
                Console.WriteLine(Math.Sin(10));//Sin:sinüs//Sinüs değerini aldık ve konsola yazdırdık.
                Console.WriteLine(Math.Cos(10));//Cos:Cosinüs
                Console.WriteLine(Math.Tan(10));//Tan:Tanjant
                Console.WriteLine(Math.Ceiling(22.3));//Küsüratlı sayıda sayıyı en yakın büyük tam sayıya çevirdik ve konsola yazdırdık.//23
                Console.WriteLine(Math.Round(22.3));//Küsüratlı sayıda sayıya en yakın tam sayıya çevirdik ve konsola yazdırdık.//22 
                Console.WriteLine(Math.Round(22.5));//22
                Console.WriteLine(Math.Round(22.6));//23
                Console.WriteLine(Math.Floor(22.7));//Küsaratlı sayıda sayıya en yakın küçük tam sayıya çevirdik ve konsola yazdırdık.//22
                Console.WriteLine(Math.Max(2,6));//6
                Console.WriteLine(Math.Min(2,6));//2
                Console.WriteLine(Math.Pow(3,4));//3^4=81//pow:power:kuvvet,üs
                Console.WriteLine(Math.Sqrt(9));//3//Karekök alır.//sqrt:square root:karekök
                Console.WriteLine(Math.Log(9));//9'un e tabanındaki logoritmik karşılığını getirir.
                Console.WriteLine(Math.Exp(3));//e üzeri 3'ü verir.
                Console.WriteLine(Math.Log10(100));//100 sayısının 10 tabanındaki logoritmik karşılığını getirir.           
            }
        }
    }