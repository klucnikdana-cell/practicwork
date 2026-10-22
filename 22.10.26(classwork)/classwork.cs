using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _22._10._26_classwork_
{
    /*internal class Human
    {
        protected string firstname;
        protected string lastname;
        protected int age;

        public Human(string fname,string lname,int ag)
        {
            firstname = fname;
            lastname = lname;
            age = ag;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {firstname}\nLastname: {lastname}\nAge: {age}");
        }

    }
    internal class Builder : Human
    {
        string _work;

        public Builder(string fname,string lname,int ag,string work) : base( fname,lname,ag)
        {

        }
        public void Show()
        {
            Print();
            Console.WriteLine($"Work: {_work}");
        }
    }
    internal class Sailor : Human
    {
        string _ship;

        public Sailor(string fname, string lname, int ag, string ship) : base(fname, lname, ag)
        {
            _ship = ship;
        }

        public void Show()
        {
            Print();
            Console.WriteLine($"Ship: {_ship}");
        }
    }

    internal class Pilot : Human
    {
        string _airline;

        public Pilot(string fname, string lname, int ag, string airline) : base(fname, lname, ag)
        {
            _airline = airline;
        }

        public void Show()
        {
            Print();
            Console.WriteLine($"Ship: {_airline}");
        }
    }*/ //11111111111111111

    /*internal class Passport
    {
        protected string firstname;
        protected string lastname;
        protected string country;
        protected string passportNumber;

        public Passport(string fname, string lname, string cntry, string number)
        {
            firstname = fname;
            lastname = lname;
            country = cntry;
            passportNumber = number;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {firstname}\nLastname: {lastname}\nCountry: {country}\nPassportNumber: {passportNumber}");
        }
    }
    internal class ForeignPassport : Passport
    {
        string _foreignNumber;
        string _visa;

        public ForeignPassport(string fname, string lname, string cntry, string number,string foreignNumber,string visa) : base(fname,lname,cntry,number)
        {
            _foreignNumber = foreignNumber;
            _visa = visa;
        }
        public void Show()
        {
            Console.WriteLine($"Foreign passport number: {_foreignNumber}\nVisa: {_visa}");
        }
    }*/ //2222222222222222

    internal class Animal
    {
        protected string name;
        protected string characteristic;

        public Animal(string n, string c)
        {
            name = n;
            characteristic = c;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}\nCharacteristic: {characteristic}");
        }
    }

    internal class Tiger : Animal
    {
        public Tiger(string n, string c) : base(n, c)
        {
        }
    }

    internal class Crocodile : Animal
    {
        public Crocodile(string n, string c) : base(n, c)
        {
        }
    }

    internal class Kangaroo : Animal
    {
        public Kangaroo(string n, string c) : base(n, c)
        {
        }
    }
}
