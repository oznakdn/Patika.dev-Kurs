using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            


            /**********************************(1)*****************************************
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının 
            girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        
            
            Console.WriteLine("Girilecek sayı adedi");
            int n=Convert.ToInt32(Console.ReadLine());
            int [] dizi=new int [n];
            int [] yeniDizi=new int[n];

            // Döngü kullanıcıdan n kadar değer alır ve bu değerleri dizi'ye atar.
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"{i+1}. Sayı:");
                dizi[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Girilen Sayılar:");

            // Dizideki elemanları kontrol amaçlı gösterir
            foreach(int item in dizi)
            {
                Console.WriteLine(item);
            }

            // Döngüde dizi boyutu kadar, çift olan sayıları yeniDizi'ye atar.
            for(int i=0;i<dizi.Length;i++)
            {
                if(dizi[i]%2==0)
                {
                    yeniDizi[i]=dizi[i];
                }
            }
            Console.WriteLine("Çift Sayılar:");

            // Dizide sıfırdan farklı olan elemanları döndürür.
            foreach(int item2 in yeniDizi)
            {
                  if(item2!=0)
                  {
                      Console.WriteLine(item2);
                  }
            }
            
            ***************************************************************************/


            /************************************(2)************************************
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş
            olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            Console.WriteLine("Pozitif iki sayı giriniz");
            Console.WriteLine("İlk Sayı: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayı: ");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} adet sayı giriniz");

            int [] myArray=new int[n];

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"{i+1}.Sayı: ");
                myArray[i]=Convert.ToInt32(Console.ReadLine());    
            }

            Console.WriteLine("m'e eşit yada tam bölünenler:");
            foreach(int item in myArray)
            {
                if(item==m || item%m==0)
                {
                    Console.WriteLine(item);
                }
            }

            ***************************************************************************/

            /***********************************(3)*************************************
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini 
            yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
             Console.WriteLine("Pozitif bir sayı giriniz");
             int n=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"{n} adet kelime giriniz");
             string [] strArray=new string[n];
             for(int i=0;i<n;i++)
             {
                 Console.WriteLine($"{i+1}.Kelime= ");
                 strArray[i]=Console.ReadLine();
             }

             // Tersten yazdırmak için
            Console.WriteLine("Kelimelerin sondan başa yazdırılması: ");
            for(int i=strArray.Length-1;i>=0;i--)
            {
                Console.WriteLine(strArray[i]);
            }
            ***************************************************************************/

            /*************************************(4)********************************
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            */

            Console.WriteLine("Bir cümle yazınız");
            string cumle=Console.ReadLine();
            string [] myArray=cumle.Split(" ");
            foreach(string item in myArray)
            {
                Console.WriteLine($"Kelimeler: {item}");
            }

            // Kelime sayısı
            int kelimeAdedi=myArray.Length;
            Console.WriteLine($"Kelime Adedi: {kelimeAdedi}");

            // Harf adedi
            char [] myChar=cumle.ToCharArray();
            Console.WriteLine($"Harf Sayısı: {myChar.Length}");
           
            

           
           
            



          
            



        
           

        }
    }
}
