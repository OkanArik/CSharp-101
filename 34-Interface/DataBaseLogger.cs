using System;

  
    namespace Interface
    {
    public class DataBaseLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database'e yazar.");
        }
    }
}