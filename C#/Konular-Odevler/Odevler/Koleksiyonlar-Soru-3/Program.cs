using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
              ve dizinin elemanlarını sıralayan program.
           */

            Console.WriteLine("Bir cümle yazınız.");
            string metin=Console.ReadLine();
            metin.ToLower();
            char [] harfler=new char[metin.Length];
            char [] sesliHarfler=new char[harfler.Length];
            
            for(int i=0;i<metin.Length;i++)
            {
                harfler[i]=metin[i];
            }
            
            for(int i=0;i<harfler.Length;i++)
            {
                if(harfler[i]=='a' || harfler[i]=='e' || harfler[i]=='ı' || harfler[i]=='i' || harfler[i]=='o' || harfler[i]=='ö' || harfler[i]=='u' || harfler[i]=='ü')
                {
                    sesliHarfler[i]=harfler[i];
                }
            }
            Array.Sort(sesliHarfler);
            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }

        
            

           
            

        }
    }
}
