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

            Program a=new Program();
            a.ToWrite();


            int z=5,t=10;
            MyClass myClass2=new MyClass();
            int arttirTopla=myClass2.ArttırVeTopla(ref z,ref t);
            Console.WriteLine(arttirTopla);

            /***************Out Parametreler**************/
            // sayi değişkenini int'e çevirmeye çalış.Çevirme başarılıysa (true) outsayi'ya atamasını yap.
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

           // Out parametreli metodun çağrılması
           MyClass myClass3=new MyClass();
           myClass3.Topla(4,5,out int toplamSonucu);
           Console.WriteLine(toplamSonucu);

           // Overloading metodun çağrılması
           MyClass myClass4=new MyClass();
           int returnResult=myClass4.Cikart(100,50);  // yada
           int voidResult=myClass4.Cikart(100,50);
           

            
        }

        private void ToWrite()
        {
            Console.WriteLine("Aynı sınıf içinden ulaşmak");
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
            public int Cikart(int number1,int number2)
            {
               return number1-number2;
            }

            public void Cikart(int mynumber1, int mynumer2)
            {
                    mynumber1-mynumer2;
            }

    }

}
    

