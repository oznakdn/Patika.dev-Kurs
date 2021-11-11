using System;

namespace StringMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            /* String Metotları
            1- Length (karakter sayısı)
            2- ToUpper, ToLower (karakter büyütme,küçültme)
            3- Concat (birleştirme)
            4- Compare, CompareTo (karşılaştırma yapar.)
            5- Contains (değişken içerisinde verilen parametrenin bulunup bulunmadığını gösterir.)
            6- StartsWith, EndsWith (değişken verilen parametre değeriyle başlıyor mu/bitiyor mu?)
            7- IndexOf (verilen parametrenin değişkenin kaç numaralı index'inde olduğunu gösterir.)
            8- Insert (değişkende, parametre olarak verilen index değerine yine parametre olarak verilen string değeri ekler.)
            9- Remove (değişken içerisinde karakter siler.)
            10- PadLeft, PadRight (girilen parametre değeri kadar değişkenin solundan/Sağından boluk verir)
            11- Replace (değişken içindeki değeri parametre olarak verilen değer ile değiştirir.)
            12- Split (değişkeni, verilen parametreye göre ayırarak bir diziye atar.)
            13- Substring (verilen index'den başlayarak sonuna kadar getirir.)
            */

            string degisken="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2="Dersimiz CSharp";


            /********************Length******************/
            Console.WriteLine($"Length : {degisken.Length}");

            /*****************ToUpper - ToLower*************/
            Console.WriteLine($"ToUpper : {degisken.ToUpper()}");
            Console.WriteLine($"ToLower : {degisken.ToLower()}");

            /*******************Concat*****************/
            Console.WriteLine($"Concat: {String.Concat(degisken," Merhaba!")}");

            /****************Compare - CompareTo************/
            Console.WriteLine($"Compare: {String.Compare(degisken,degisken2,true)}"); //birinci değisken ikinci değişkenden büyükse 1, küçükse -1 döner, eşit ise 0 döndürür.true ise büyük küçük harf duyarsızdır.
            Console.WriteLine($"CompareTo: {degisken.CompareTo(degisken2)}"); //birinci değisken ikinci değişkenden büyükse 1, küçükse -1 döner, eşit ise 0 döndürür.

            /****************Contains************/
            Console.WriteLine($"Contains: {degisken.Contains("Dersimiz")}");

            /****************startsWith - EndsWith************/
            Console.WriteLine($"StartsWith: {degisken2.StartsWith("Dersimiz")}");
            Console.WriteLine($"EndsWith: {degisken2.EndsWith("CSharp")}");

            /****************IndexOf************/
            Console.WriteLine($"IndexOf: {degisken.IndexOf('a')}"); // bulamazsa -1 döner.

            /****************Insert************/
            Console.WriteLine($"Insert: {degisken2.Insert(0,"Merhaba, ")}");

            /****************Remove************/
            Console.WriteLine($"Remove: {degisken.Remove(0,5)}"); // 0. index den başlayıp 5 karakter siler

            /****************PadLeft - PadRight************/
            Console.WriteLine($"PadLeft: {degisken2.PadLeft(30,'*')}");
            Console.WriteLine($"PadRight: {degisken2.PadRight(30,'*')+degisken}");

            /****************Replace************/
            Console.WriteLine($"Replace: {degisken.Replace("CSharp","C#")}");

            /****************Split************/
            Console.WriteLine($"Split: {degisken.Split(' ')[2]}"); // Boşluklardan parçala ve bir diziye ata ve 2. index'deki veriyi getirir.

            /****************Substring************/
            Console.WriteLine($"Substring: {degisken2.Substring(5,6)}"); // 5. index'den başlayarak 6 karakter getirir.



            























        }
    }
}
