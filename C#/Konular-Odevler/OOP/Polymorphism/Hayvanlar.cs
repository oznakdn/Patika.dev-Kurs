using System;

namespace Polymorphism
{
    public class Hayvanlar:Canlilar
    {

    }

    public class Kopek:Hayvanlar
    {
        public override void Beslenme()
        {
            base.Beslenme();
        }
    }
    public class Koyun:Hayvanlar
    {
        public override void Beslenme()
        {
            Console.WriteLine("Ot ile beslenirler");
        }
    
    }
}