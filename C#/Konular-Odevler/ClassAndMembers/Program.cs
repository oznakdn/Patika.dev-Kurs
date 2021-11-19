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


            /******************************************************/
            
            Employee employee1=new Employee();
            employee1.Age=25;
            employee1.Name="John";
            employee1.Surname="Flower";
            employee1.EmployeeInformation(employee1.Age,employee1.Name,employee1.Surname);
                 // Or
            employee1.EmployeeInformation(30,"Ali","Koşar");

            /******************************************************/
            Customer customer1=new Customer("Mehmet","Uzun","Mühendis"); // constructor'dan atama
            Customer customer2=new Customer("Seda","Gezer","Öğretmen");
            customer1.CustomerInformation();
            customer2.CustomerInformation();

            /******************************************************/

            Student student1=new Student
            {
                Name="Ahmet",
                Surname="Sevinç",
                StudentNumber=1234,
                StudentClass=2
            };

            student1.UpClass(student1.StudentNumber,student1.StudentClass);
            student1.GetStudentInformation();

            /******************************************************/

            Calisan calisan=new Calisan("Ali","Demir","Muhasebe");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            /******************************************************/
            
            long a=Islem.Topla(200,100);
            long b=Islem.Cikar(10,5);
            Console.WriteLine(a);
            Console.WriteLine(b);

            /******************************************************/

            Dikdortgen dikdortgen=new Dikdortgen();
            dikdortgen.UzunKenar =10;
            dikdortgen.KisaKenar = 5;
            Console.WriteLine("Class Alan: {0}",dikdortgen.AlanHesapla());

            DikdortgenStruct dikdortgenStruct=new DikdortgenStruct();
            dikdortgenStruct.KisaKenar = 100;
            dikdortgenStruct.UzunKenar = 150;
            Console.WriteLine("Struct Alan: {0}",dikdortgenStruct.AlanHesapla());

            // constructor ile struct
            DikdortgenStruct dikdortgen_struct=new DikdortgenStruct(8,10);
            Console.WriteLine(dikdortgen_struct.AlanHesapla());

            /******************************************************/

            Console.WriteLine(Gunler.Cumartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if(sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyiniz");
            }
            else if(sicaklik>=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Dışarıya çıkabilirsiniz");
            }
            


           



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
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get=>calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi=0;

        }

        public Calisan(string isim,string soyisim,string departman)
        {
            this.Isim=isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi++;
        }
    }

    /*Static olarak oluşturulan sınıfların tüm üyeleri de static olmalıdır*/

    static class Islem
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }

    #endregion
    #region Struct (yapı) kavramı
    /*
     * Sınıflara benzeyen yapılardır
     * Kendi field, property ve metotları vardır
     * Constructor'ları vardır ve parametre almaları zorunludur.
     * Class ladrdan en önemli farkı; class'lar referans tipken, struct'lar değer tiplerdir.
     * Performans açısından class'lardan daha hızlıdırlar.
    */
    class Dikdortgen
    {
        public Dikdortgen()
        {
            KisaKenar=5;
            UzunKenar=10;
        }

        public int KisaKenar;
        public int UzunKenar;

        public int AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }

    }

    struct DikdortgenStruct
    {

        public DikdortgenStruct(int kisaKenar,int uzunKenar)
        {
            this.KisaKenar=kisaKenar;
            this.UzunKenar=uzunKenar;
        }
        public int KisaKenar;
        public int UzunKenar;

        public int AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }
    }
    #endregion
    #region Enum
    /*
     * Sıralı verilerle çalışmak için kullanılırlar
     * Birden fazla sabite ihtiyaç duyulduğunda kullanılır. Örneğin medeni durum, cinsiyet, günler vs.
    */
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        CokSicak=35
    }
    #endregion
}
