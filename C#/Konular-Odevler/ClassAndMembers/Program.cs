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
                 // Or
            employee1.EmployeeInformation(30,"Ali","Koşar");


            Customer customer1=new Customer("Mehmet","Uzun","Mühendis"); // constructor'dan atama
            Customer customer2=new Customer("Seda","Gezer","Öğretmen");
            customer1.CustomerInformation();
            customer2.CustomerInformation();


            Student student1=new Student
            {
                Name="Ahmet",
                Surname="Sevinç",
                StudentNumber=1234,
                StudentClass=2
            };

            student1.UpClass(student1.StudentNumber,student1.StudentClass);
            student1.GetStudentInformation();

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
    #region Encapsulation and Properties
    class Student
    {

        // fields
        private string name;
        private string surname;
        private int studentnumber;
        private int studentclass;


        // properties
        public string Name { get{return name;} set{name=value;}}
        public string Surname { get{return surname;} set{surname=value;}}
        public int StudentNumber
        { 
            get{return studentnumber;} 
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Please, enter a number greater than 0");
                    studentnumber=1;
                }
                else
                {
                    studentnumber=value;
                }
            }
        }
        public int StudentClass 
        { 
            get {return studentclass;}
            set
            {
                if(value<=0)
                {
                   Console.WriteLine("Please, enter a number greater than 0");
                   studentclass=1;
                }
                else
                {
                    studentclass=value;
                }
            } 
        }
        // Method
        public void GetStudentInformation()
        {
           Console.WriteLine($" Name: {Name}, Surname:{Surname}, Number: {StudentNumber}, Class: {StudentClass}");
        }

        public void UpClass(int number,int student_class)
        {  

            this.StudentNumber=number;
            this.StudentClass=student_class;
            StudentClass++;
            //Console.WriteLine($"{StudentNumber} number student passed {StudentClass}");
        }


    }
    
    #endregion
    #region Static Class and its Members

    #endregion
}
