//Loglama:Öncelikle log kelimesi kayıt anlamına gelmektedir. Loglama işlemi ise bu kayıtlar ile dijital hareketlerin tutulma işlemine denir. Gelişen teknoloji ile yazılımlar, işletim sistemleri, IOT(Internet Of Things) cihazları gibi elektronik sitemler üzerinde yapılan her işin kayıtlarının tutulmasıdır.

using System;

  
    namespace Interface
    {
        public interface ILogger
        {
            void WriteLog();
        }
    }