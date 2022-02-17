using System;

  
    namespace Interface
    {
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya yazar.");
        }
    }
}