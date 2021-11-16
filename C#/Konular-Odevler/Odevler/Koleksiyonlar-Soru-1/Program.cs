using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
           /*: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)
            1- Negatif ve numeric olmayan girişleri engelleyin.
            2- Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            3- Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
           */


            Console.WriteLine("20 adet sayı giriniz.");
            int n;
            ArrayList tum=new ArrayList();
            ArrayList asalOlan=new ArrayList();
            ArrayList asalOlmayan=new ArrayList();

            // Önce klavyeden 20 sayıyı "tum" adında bir dizide topluyoruz.
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine($"{i}.Sayı");
                n=int.Parse(Console.ReadLine());
                if(n>0)
                {
                    tum.Add(n);
                }
                else
                {
                    Console.WriteLine("pozirif sayı giriniz");
                    break;
                }
            }

            // 1- tum adındaki dizideki elemanlardan asal olanları "asalOlan" listesine, asal olmayanları da "asalOlmayan" listesine ekliyoruz.
            for(int i=0;i<tum.Count;i++)
            {
               if((int)tum[i]%2!=0 && (int)tum[i]%3!=0 && (int)tum[i]%4!=0 && (int)tum[i]%5!=0)asalOlan.Add(tum[i]);
               else asalOlmayan.Add(tum[i]);
            }
            
            // 2- dizi elemanlarını büyükten küçüğe doğru sıralamak
            asalOlan.Sort();
            asalOlan.Reverse();
            Console.WriteLine("Asal");
            foreach(var item in asalOlan) Console.WriteLine(item);
            
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            Console.WriteLine("Asal değil");
            foreach (var item in asalOlmayan) Console.WriteLine(item);

            // 3- dizi eleman sayısı ve ortalaması
            Console.WriteLine("Asal eleman sayısı: "+asalOlan.Count);
            Console.WriteLine("Asal olmayan eleman sayısı: "+asalOlmayan.Count);
            
            int asalToplam=0;
            int asalOrtalama=0;
            for(int i=0;i<asalOlan.Count;i++)
            {
                asalToplam+=(int)asalOlan[i];
            }
            
            asalOrtalama=asalToplam/asalOlan.Count;
            Console.WriteLine("Asal ortalama= "+asalOrtalama);
        

            int asalOlmayanToplam=0;
            int asalOlmayanOrtalama=0;
            for(int i=0;i<asalOlmayan.Count;i++)
            {
                asalOlmayanToplam+=(int)asalOlmayan[i];
            }
            
            asalOlmayanOrtalama=asalOlmayanToplam/asalOlmayan.Count;
            Console.WriteLine("Asal olmayan ortalama= "+asalOlmayanOrtalama);

    


            
          



           
        }
       
    }
    
}
