using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var time=DateTime.Now.Hour;
            string timeMessage;

            // if-else 
            if(time>=6 && time<=18)
            {
                timeMessage="İyi günler";   
            }
            else if(time>18 && time<=23)
            {
                timeMessage="iyi akşamlar";
            }
            else
            {
                timeMessage="İyi geceler";
            }

            Console.WriteLine($" Saat:{time} {timeMessage}");

            //Ternary operatörü
            string otherMessage=time>=6 && time<=18 ? "İyi günler":time>18 && time<=23 ? "İyi akşamlar":"İyi geceler";
            Console.WriteLine($" Ternary:{otherMessage}");




        }
    }
}
