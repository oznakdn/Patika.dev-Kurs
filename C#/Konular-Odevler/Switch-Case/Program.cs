using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Birinci tamsayıyı giriniz");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci tamsayıyı giriniz");
            int y=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen sembol giriniz (+,-,*,/)");
            char sembol=char.Parse(Console.ReadLine());
            switch(sembol)
            {
                case '+' : Console.WriteLine(x+y); break;
                case '-' : Console.WriteLine(x-y); break;
                case '*' : Console.WriteLine(x*y); break;
                case '/' : Console.WriteLine(x/y); break;
                default  : Console.WriteLine("Yanlış sembol girdiniz"); break;
            }
            
        }
    }
}
