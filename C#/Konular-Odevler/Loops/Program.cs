using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*------Console'dan gelen sayıdaki tek sayılar-----*/
            Console.WriteLine("Bir sayı giriniz");
            int num=int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                //if(i%2==1)
                //Console.WriteLine(i);
            }
           /*----------------------------------------------------*/
           

            /*--------Tersten döngü---------------*/
            for(int j=num;j>=1;j--) 
            Console.WriteLine(j);

           /*----------------------------------------------------*/



            // Örnek 1-1000 arasındaki tek ve çift sayıların toplamını hesaplama
            int tekToplam=0;
            int ciftToplam=0;
            for(int t=1;t<1000;t++)
            {
                if(t%2!=0) tekToplam+=t;
                
                else ciftToplam+=t;
            
            }
            Console.Write($"Tek Sayılar Toplamı={tekToplam}, Çift Sayılar Toplamı={ciftToplam}");
           /*------------------------------------------------------------------------------*/

           /*--------break & continue kullanımı-----*/
            for(int n=1;n<10;n++)
            {
                if(n==5)
                break;
                Console.Write(n);    
            }
                Console.Write("-----");
                
             for(int m=1;m<10;m++)
            {
                if(m==6)
                continue;
                Console.Write(m);    
            }
            

            /*-------------while kullanımı----------------*/
            
            // 1 den başlayarak input'dan gelen sayıya kadar (sayı dahil) ortalama hesaplama
            Console.WriteLine("Bir sayı giriniz");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int sayac=1;
            int toplam=0;
           
            while(sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;   
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar olan harflerin yazdırılması
            char letter='a';
            while(letter<='z')
            {
                Console.Write(letter);
                letter++;
            }

            Console.WriteLine("*******************************");

            /*-----------------Foreach--------------------*/
            string [] arabalar={"Doğan","Kartal","Serçe"};
            foreach(string araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
