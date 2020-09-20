using System;

namespace OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Постовалов", "Денис");
            Employee employee = new Employee("Лицо", "Рука", "КУПК");
            person.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
    class Person
    {
        private string _firstName;
        private string _lastName;
        public Person(string name, string surname)
        {
            _firstName = name;
            _lastName = surname;
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    class Employee : Person
    {
        private string _company;

        public Employee(string name, string surname, string company) : base(name, surname)
        {
            Company = company;
        }
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
    }

}
