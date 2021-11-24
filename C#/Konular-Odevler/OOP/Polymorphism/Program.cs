using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Koyun koyun=new Koyun();
            koyun.Beslenme();

            Kopek kopek=new Kopek();
            kopek.Beslenme();


            /*Sealed keyword'ü sınıfa verildiğinde o sınıf başka sınıflara kalıtım veremez.
                public sealed class Name
                {
        
                }
            */
            
        }
    
    }
}
