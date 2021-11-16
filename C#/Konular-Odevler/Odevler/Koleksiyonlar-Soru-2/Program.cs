using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama
             toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            */

            Console.WriteLine("20 adet sayı giriniz!");
            int[] numberList=new int[20];
            for(int i=0;i<20;i++)
            {
                Console.Write($"{i+1}.Sayı=");
                numberList[i]=int.Parse(Console.ReadLine());
            }
            // Küçükten büyüğe sıralayıp ilk üç elemanını bulmak
            Array.Sort(numberList);
            Console.WriteLine("Küçükten büyüğe");
        
            Console.WriteLine(numberList[0]);
            Console.WriteLine(numberList[1]);
            Console.WriteLine(numberList[2]);
            

            // Büyükten küçüğe sıralayıp ilk üç elemanını bulmak
            Array.Reverse(numberList);
            Console.WriteLine("Büyükten küçüğe");
            
            Console.WriteLine(numberList[0]);
            Console.WriteLine(numberList[1]);
            Console.WriteLine(numberList[2]);    
            

            

        }
    }
}
