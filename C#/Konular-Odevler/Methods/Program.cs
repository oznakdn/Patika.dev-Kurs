using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /***********Metotların çağrılması**************/

            MyClass myClass=new MyClass();
            myClass.Sum(10,23);

            MyClass myClass1=new MyClass();
            int myResult=myClass1.SumSecond(20,12);
            Console.WriteLine(myResult);

            int z=5,t=10;
            MyClass myClass2=new MyClass();
            int arttirTopla=myClass2.ArttırVeTopla(ref z,ref t);
            Console.WriteLine(arttirTopla);

            /***************Out Parametreler**************/
            // sayi değişkenini int'e çevirmeye çalış.Çevirme başarılıysa (true) outsayi'ya atamasını yap.
            /*
            string sayi="999";
            bool Sonuc=int.TryParse(sayi,out int outsayi);
            if(!Sonuc)
            {
                Console.WriteLine("Başarısız"+" "+outsayi.GetType());
            }
            else
            {
                Console.WriteLine("Başarılı"+" "+outsayi.GetType());
            }
            */

           // Out parametreli metodun çağrılması
           MyClass myClass3=new MyClass();
           myClass3.Topla(4,5,out int toplamSonucu);
           Console.WriteLine(toplamSonucu);

           // Overloading metodun çağrılması
           MyClass myClass4=new MyClass();
           myClass4.Yazdir("Overloading 1. metot.");
          
           
           // Recursive metodun çağrılması
           MyClass myClass5=new();
           Console.WriteLine(myClass5.Expo(3,4));


           // Extension metodun çağrılması
           string ifade="patika c# dersleri";
           bool result=ifade.CheckSpaces();
           //

           Console.WriteLine(result); // sonuç true döner.
           if(result)
           {
               Console.WriteLine(ifade.RemoweWhiteSpaces());
           }
           //
           Console.WriteLine(ifade.MakeUpperCase());

           //
           int [] myArray={3,9,5,1};
           myArray.SortArray();
           myArray.WriteDisplay();

           //

           string metin="Merhaba";
           Console.WriteLine(metin.GetFirstCharacter());
           

           
            
        }

    }

    class MyClass
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }

        public int SumSecond(int x,int y)
        {
            int result=x+y;
            return result;
        }
            
            // Ref kullanıldığında ilgili değişkenin kopyaları ile çalışmak yerine orjinal değişkenler üzerinde çalışır.
            // Bellekteki adresleri işaretlenmiş olunur.Referanslar üzerinde değişiklik yapılmış olunur.
        public int ArttırVeTopla(ref int num1, ref int num2)
        {
            num1++;
            num2++;
            return num1+num2;
        }

        /****************Out Parametreli Metot****************/
        public void Topla(int sayi1,int sayi2,out int toplam)
        {
            toplam=sayi1+sayi2;
        }

        /***********Matod Overloading*************/
        public void Yazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public void Yazdir()
        {
            Console.WriteLine("Overloading 2. metod.");
        }


        /**************Recursive Metotlar (kendi kendini çağıran)*************/
        public int Expo(int sayim,int ussu)
        {
            if(ussu<2)
            return sayim;
            return Expo(sayim,ussu-1)*sayim;
        }
        

    }

    /**************Extension Metotlar*************
    * Static class içerisinde static olarak tanımlanmalıdırlar
    * Metot parametresinin önüne "this" keyword'ü getirilmelidir.
    */
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoweWhiteSpaces(this string param)
        {
            string [] dizi=param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;      
        }

        public static void WriteDisplay(this int [] param)
        {
            foreach(int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }



}
    

