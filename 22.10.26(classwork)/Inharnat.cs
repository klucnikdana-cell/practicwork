using System;
using System.Collections.Generic;
using System.Text;

namespace _22._10._26_classwork_
{
    internal class Inharnat
    {
        private int _id;
        string _firstname;
        string _lastname;
        DateTime _birthDate;
        public Inharnat( string firstname, string lastname, DateTime birthDate)
        {
            _id = 0;
            _firstname = firstname;
            _lastname = lastname;
            _birthDate = birthDate;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {_firstname}\nLastname: {_lastname}\nBirthDane: {_birthDate}");
        }
    }

    internal sealed class Employee : Inharnat //sealed - забороняє успадковуватися цьому скласу
    {
        double _salary;
        public Employee(string fname,string lname,double salary,DateTime date) : base(fname,lname,date)
        {
            _salary = salary;
        }
        public void Print()
        {
            Show();
            Console.WriteLine($"Salary: {_salary}");
        }
    }
}

/*internal class Human
{
    private int _id;
    protected string firstname;
    protected string lastname;

}

internal class Employee : Human
{
    double _salary;
    public Employee(string fname, string lname, double salary)
    {
        firstname = fname;
        lastname = lname;
        _salary = salary;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {firstname}\nLastname: {lastname}\nSalary: {_salary}");
    }
}*/ //приклад вчителя,але це тут трохи по іншому буде працювати
