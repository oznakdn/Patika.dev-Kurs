using System;

namespace HayvanatBahcesiProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvanlar hayvanlar = new At();
            hayvanlar.getFeedSchedule();
            hayvanlar.getDosage();

            
        }
    }
    class Hayvanlar
    {
        public string Turadi { get; set; }
        public int Yas { get; set; }
        public int Agirlik { get; set; }

       
     
        public virtual void getDosage()
        {
            Console.WriteLine("dozaj=100cc");
        }

        public virtual void getFeedSchedule()
        {
            Console.WriteLine("Günde 2 defa et ile besleyiniz");
        }


    }


    class Atlar:Hayvanlar
    {
        public override void getFeedSchedule()
        {
            Console.WriteLine("Günde 3 defa ot ve arpa ile beslenecek ");
        }

        public override void getDosage()
        {
            Console.WriteLine("ortalama dozage=200cc");
        }
    }
    class Kedigiller:Hayvanlar
    {

    }
    class Kemirgenler : Hayvanlar
    {
        public override void getFeedSchedule()
        {
            Console.WriteLine("Günde 6 kez et ile beslenecekler");
        }

        public override void getDosage()
        {
            Console.WriteLine("uygulanacak dozaj=20cc");
        }
    }


    class At:Atlar
    {
        
        
    }
    class Zebra:Atlar
    {
        

    }
    class Esek:Atlar
    {
        
    }


}
