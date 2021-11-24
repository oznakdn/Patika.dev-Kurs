using System;

namespace AbstractClass
{
    public abstract class Otomobil
    {
        public int KacTekerli()
        {
            return 4;
        }

        public virtual string Renk()
        {
            return "Beyaz";
        }

        public abstract string Marka();
       
    }
}