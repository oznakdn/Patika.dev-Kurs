using System;

namespace ClassAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Access modifiers
            * Public = her yerden erişilebilir
            * Private = tanımlandığı sınıf içinden erişilebilir
            * Internal = bulunduğu proje içerisinde erişilebilen
            * Protected = sadece tanımlandığı sınıfta ve/veya o sınıftan kalıtım alan sınıflarda erişilebilir
            */

            Employee employee1=new Employee();
            employee1.Age=25;
            employee1.Name="John";
            employee1.Surname="Flower";
            employee1.EmployeeInformation(employee1.Age,employee1.Name,employee1.Surname);
                 // Ya da
            employee1.EmployeeInformation(30,"Ali","Koşar");


            Customer customer1=new Customer("Mehmet","Uzun","Mühendis"); // constructor'dan atama
            Customer customer2=new Customer("Seda","Gezer","Öğretmen");
            customer1.CustomerInformation();
            customer2.CustomerInformation();

        



        }
    }

    #region Class and Class's members
    class Employee
    {
        // field
        int age;

        // property
        public int Age { get {return age;} set{age=value;}}
        public string Name { get; set; }
        public string Surname { get; set; }

        // Method
        public void EmployeeInformation(int age,string name,string surname)
        {
            Age=age;
            Name=name;
            Surname=surname;
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}");

        }

    }
    #endregion

    
    #region Constructors
    class Customer
    {
        public Customer(string firstname, string lastname, string job)
        {
           this.FirstName=firstname;
           this.LastName=lastname;
           this.Job=job;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }


        public void CustomerInformation()
        {
            Console.WriteLine($"FirstName: {FirstName} , LastName: {LastName} , Job: {Job}");
        }

        
    }
    #endregion
}
