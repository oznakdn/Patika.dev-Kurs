using System;

namespace Arayuzler
{
    public class FileLogger:ILogger
    {
       public void WriteLog()
       {
           Console.WriteLine("Dosyaya Log yazar.");
       }
    }
}