using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************Inheritance (Kalıtım)******************/
            /*
                                        Canlılar
                                           |
                        Bitkiler                          Hayvanlar
                            |                                 |                       
                Tohumlı         Tohumsuz         Surungenler      Kuşlar
            */

            TohumluBitkiler tohumluBitkiler=new TohumluBitkiler();

            Kuslar marti=new Kuslar();
            marti.Beslenme();
            marti.Bosaltim();
            marti.Adaptasyon();
            marti.Solunum();
           

        }
    }


}
