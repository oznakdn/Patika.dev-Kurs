using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           
           /*Dizi Metotları
           1- Short
           2- Clear
           3- Reverse
           4- IndexOf
           5- Resize
           */






        /*---------Sort-(elemanları küçükten büyüğe sıralar)------------*/
        int [] numberArray={34,23,64,3,45,76};
        Array.Sort(numberArray);
        foreach(int numbers in numberArray)
        Console.WriteLine(numbers);

        Console.WriteLine("****Clear****");

        /*--------Clear (verilen indeksten başlayarak verilen eleman sayısı kadar eleman sıfırlar)-------*/
        Array.Clear(numberArray,2,2); // 2. indeksten itibaren 2 tane eleman sıfırlar.
        foreach(int number in numberArray)
        Console.WriteLine(number);

        Console.WriteLine("****Reverse****");

        /*---------Reverse-(verilen diziyi tersine döndürür)-----*/
        Array.Reverse(numberArray);
        foreach(int num in numberArray)
        Console.WriteLine(num);
        
        Console.WriteLine("****IndexOf****");

        /*---------IndexOf-(verilen değer dizide varsa indeksini verir)-----*/
        int indexArray=Array.IndexOf(numberArray,23);
        Console.WriteLine($"index no: {indexArray}");

        Console.WriteLine("****Resize****");

        /*---------Resize-(diziyi yeniden boyutlandırır)-----*/
        Array.Resize<int>(ref numberArray,9);
        int arrayLength=numberArray.Length;
        Console.WriteLine(arrayLength);

            
           



        }
    }
}
