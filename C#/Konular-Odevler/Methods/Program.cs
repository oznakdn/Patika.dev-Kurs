using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
    

