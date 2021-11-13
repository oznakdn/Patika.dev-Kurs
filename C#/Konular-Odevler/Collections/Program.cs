using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
                /*******Koleksiyonlar********
                --------- Avantajları-------
                1- Farklı veri tipleriyle çalışılabilmesi
                2- Array'lerin gelişmiş halidir.
                --------- Dezavantajları-------
                1- Her seferinde bir unboxing işlemi yapılması gerekir (veri yapısı object olduğundan)
                2- Array'lere göre daha maliyetli yapılardır.
                --------- Genel Amaçlı koleksiyonlar (Generic collections)-------
                a- List
                b- ArrayList
                c- Dictionary
                d- HashTable
                e- SortedList
                */  

                /****List***
                List<T>class
                System.Collection.Generic
                T=Object

                */
            List<int> numberList=new List<int>();
            numberList.Add(10);
            numberList.Add(20);
            numberList.Add(30);
            numberList.Add(40);

              

            List<string>colorList=new List<string>()
            {
                "black","white","purple","blue","pink"
            };

            

            // List.Foreach ile elemanlara erişmek
            numberList.ForEach(numbers=>Console.WriteLine(numbers));
            colorList.ForEach(colors=>Console.WriteLine(colors));
                
                  
            // Count ile eleman sayısına erişmek
            Console.WriteLine(numberList.Count); // ==> 4
            Console.WriteLine(colorList.Count); // ==> 5

            // Remove ile listeden eleman çıkartmak
            numberList.Remove(10);
            colorList.Remove("black");

            // RemoveAt ile index'e göre eleman çıkartmak
            numberList.RemoveAt(2);
            colorList.RemoveAt(1);

            // Contains ile Liste içerisinde arama
            if(numberList.Contains(20)) Console.WriteLine("Aranan sayı listede mevcut.");
            if(colorList.Contains("purple")) Console.WriteLine("Aranan renk listede mevcut");

            // BinarySearch ile verilen elemanın index'ine erişmek
            Console.WriteLine(colorList.BinarySearch("pink"));
            Console.WriteLine(numberList.BinarySearch(20));

            // Array'i List'e çevirmek
            string[] animalArray={"cat","dog","bird","fish"};
            List<string>animalList=new List<string>(animalArray);
            animalList.ForEach(animal=>Console.WriteLine(animal));

            // Clear ile tüm listeyi temizlemek
            animalList.Clear();

            // Liste içerisinde nesne tutmak için
            Users userFirst=new Users{FirstName="Ali",LastName="Gezgin",Age=30};
            Users userSecond=new Users{FirstName="Bekir",LastName="Selam",Age=35};
            List<Users>UserList=new List<Users>();
            UserList.Add(userFirst);
            UserList.Add(userSecond);

            List<Users>UserListOther=new List<Users>();
            UserListOther.Add(new Users{FirstName="Mehmet",LastName="Konak",Age=32}); // direkt liste içerisinde nesne oluşturmak.

            foreach (Users item in UserList)
            {
                Console.WriteLine($"First Name: {item.FirstName} Last Name: {item.LastName} Age: {item.Age}");
            }
             

        }

        class Users
        {
            string firstname;
            string lastname;
            int age;

            public string FirstName{get{return firstname;} set{firstname=value;}}
            public string LastName{get{return lastname;} set{lastname=value;}}
            public int Age{get{return age;} set{age=value;}}
            
            
        }
    }
}
