using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------Dizilere eleman tanımlamak-------*/
            int [] numbers=new int [3];
            char [] letters=new char[]{'a','b','c','d'};
            string [] colors={"Red","Green","Blue"};

            /*------Dizi eleman sayısını sorgulamak----*/
            int lettersLength=letters.Length;
            Console.WriteLine(lettersLength);

            /*-------Dizilere eleman atamak------------*/
            numbers[0]=10;
            numbers[1]=20;
            Console.WriteLine(numbers[1]);

            /*For ile dizi elemanlarını dönmek*/
            for(int i=0;i<colors.Length;i++)
            {
                Console.WriteLine(colors[i]);
            }

            /*Foreach ile dizi elemanlarını dönmek*/
            foreach(var letter in letters)
            {
                Console.Write(letter);
            }

            // Klavyeden girilen n tane sayının ortalamasını hesaplamak

            Console.WriteLine("Kaç sayı girilecek");
            int n=int.Parse(Console.ReadLine());
            int toplam=0;
            for(int t=1;t<=n;t++)
            {
                int sayilar=int.Parse(Console.ReadLine());
                toplam+=sayilar;
            }
            Console.Write("Ortalama:" + toplam/n +"\n");

            // Dizilerle klavyeden girilen sayıların ortalamasını hesaplamak


            Console.WriteLine("Eleman sayısını giriniz");
            int eleman=int.Parse(Console.ReadLine());
            int [] elemanlar=new int[eleman];
            int toplami=0;
            for(int r=0;r<eleman;r++)
            {
                Console.WriteLine("{0}.sayıyı girinz",r+1);
                elemanlar[r]=int.Parse(Console.ReadLine());      
            }
            foreach(var item in elemanlar)
            {
                toplami+=item;
                //Console.WriteLine(item);
            }
            int ortalamasi=toplami/eleman;
            Console.Write($"Ortalama={ortalamasi}");

            
           



        }
    }
}
