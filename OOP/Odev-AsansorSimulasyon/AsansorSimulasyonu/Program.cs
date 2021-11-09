using System;

namespace AsansorSimulasyonu
{
    class Program
    {
        static void Main(string[] args)
        {


            //Encapsulation,Inheritance,Polymorphism,Apstraction kullanıldı.


            //Polymorphism
            Yolcu yolcu = new Yolcu();
            Random rdBinen = new Random();
            int binenYolcu = rdBinen.Next(1, 7);
            yolcu.YolcuSayisi = binenYolcu;


            Random rdKat = new Random();
            int kacinciKat = rdKat.Next(1, 13);
            yolcu.KatSayisi = kacinciKat;

            Random rdasansor = new Random();
            int asansorNo = rdasansor.Next(1, 6);
            yolcu.AsansorNumarasi = asansorNo;

            int zaman = yolcu.ZamanHesapla(kacinciKat);



            Console.WriteLine($"Binen yolcu: {yolcu.YolcuSayisi}, Gidilen Kat:{yolcu.KatSayisi}, Binilen Asansör No:{yolcu.AsansorNumarasi}, zaman:{zaman} dk dır.");




        }
    }
    
    public class Bina
    {

        // Encapsulation
        private int katsayisi;
        public int KatSayisi
        {
            get { return katsayisi; }
            set { katsayisi = value; }
        }

        // Abstraction
        public virtual int ZamanHesapla(int katsayisi)
        {
            this.KatSayisi = katsayisi;
            // herbir katın 1 dk sürdüğü varsayılmıştır 
            return katsayisi * 1;
        }

    }
    // İnheritance
    public class Asansor : Bina
    {
        private int asansorNumarasi;
        public int AsansorNumarasi
        {
            get { return asansorNumarasi; }
            set { asansorNumarasi = value; }
        }


    }
    //inheritance
    public class Yolcu : Asansor
    {
        private int yolcuSayisi;
        public int YolcuSayisi
        {
            get { return yolcuSayisi; }
            set { yolcuSayisi = value; }
        }


    }
}
