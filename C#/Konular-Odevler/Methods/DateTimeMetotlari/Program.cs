using System;

namespace DateTimeMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {


            
        /**************************DateTime***********************************/

        Console.WriteLine(DateTime.Now); // Tarih-Saat: 12.11.2021 20:18:43
        Console.WriteLine(DateTime.Now.Date);  // Tarih: 12.11.2021 00:00:00
        Console.WriteLine(DateTime.Now.Day); // Gün: 12
        Console.WriteLine(DateTime.Now.Month); // Ay: 11
        Console.WriteLine(DateTime.Now.Year); // Yıl: 2021
        Console.WriteLine(DateTime.Now.Hour); // Saat: 20
        Console.WriteLine(DateTime.Now.Minute); // Dakika: 18
        Console.WriteLine(DateTime.Now.Second); // Saniye: 43

        Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın hangi günü (string formatta) ==> Friday
        Console.WriteLine(DateTime.Now.DayOfYear); // yılın kaçıncı günü ==> 316
        
        Console.WriteLine(DateTime.Now.ToLongDateString()); // günün uzun tarihi (string)  ==> 12 Kasım 2021 Cuma
        Console.WriteLine(DateTime.Now.ToShortDateString()); // günün kısa tarihi (string) ==> 12.11.2021
        Console.WriteLine(DateTime.Now.ToLongTimeString()); // uzun saat formatı (string) ==> 20:18:43
        Console.WriteLine(DateTime.Now.ToShortTimeString()); // kısa saat formatı (string) ==> 20:18

        Console.WriteLine(DateTime.Now.AddYears(1)); // yıl üzerine ekler ==> Bir yıl sonra: 12.11.2022 20:27:53
        Console.WriteLine(DateTime.Now.AddDays(2)); // gün üzerine ekler. ==> İki gün sonra: 14.11.2021 20:22:20
        Console.WriteLine(DateTime.Now.AddHours(5)); // saat üzerine ekler ==> Beş saat sonra: 13.11.2021 01:26:01



        /**************************Format***********************************/

        Console.WriteLine(DateTime.Now.ToString("dd")); // günün int karşılığı ==> 12
        Console.WriteLine(DateTime.Now.ToString("ddd")); // günün string kısa karşılığı ==> Cum
        Console.WriteLine(DateTime.Now.ToString("dddd")); // günün string uzun karşılığı ==> Cuma

        Console.WriteLine(DateTime.Now.ToString("MM")); // ayın int karışığı ==> 11
        Console.WriteLine(DateTime.Now.ToString("MMM")); // ayın string kısa karşılığı ==> Kas
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // ayın string uzun karşılığı ==> Kasım

        Console.WriteLine(DateTime.Now.ToString("yy")); // yılın kısa karşılığı ==>21
        Console.WriteLine(DateTime.Now.ToString("yyyy")); // yılın uzun karşılığı ==> 2021
      


        




        





            
        }
    }
}
