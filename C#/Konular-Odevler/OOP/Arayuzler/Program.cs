using System;

namespace Arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
           FileLogger fileLogger=new FileLogger();
           fileLogger.WriteLog();


           LogManager logManager=new LogManager(new FileLogger());
           logManager.WriteLog();
           
        }
    }
}
