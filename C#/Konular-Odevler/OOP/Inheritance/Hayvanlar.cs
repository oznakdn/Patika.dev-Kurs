using System;

namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
        
    }

    public class Surungenler:Hayvanlar
    {
        public void SurunerekHareket()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }
    }

}