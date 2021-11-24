using System;

namespace Arayuzler
{
    public class DataBaseLogger:ILogger
    {
        public void WriteLog()
        {
           Console.WriteLine("Veritabanına Log yazar.");
        }
    }
}