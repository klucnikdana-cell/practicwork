namespace _22._10._26_classwork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inharnat h = new Inharnat("Human", "H", DateTime.Now);
            Employee e = new Employee("Employee", "E", 100, DateTime.Now);
            h.Show();
            e.Print();

            Inharnat[] h2 =
            {
                e,
                new Employee("Employee2","E2",100,DateTime.Now),
                new Employee("Employee3","E3",100,DateTime.Now),
            };
            //foreach(Inharnat hum in h2)
            //{
            //    hum.Print()
            //} притамане для класу Inharnat (В кінці закоментовано)

            Console.WriteLine("\n______________________");// практична робота починається звідси

            /*Builder b = new Builder("Danylo", "Kluchnyk", 30, "Construction");
            Sailor s = new Sailor("Oleg", "Shevchenko", 35, "Black Sea");
            Pilot p = new Pilot("Andriy", "Kovalenko", 28, "Lufthansa");

            b.Show();
            Console.WriteLine();

            s.Show();
            Console.WriteLine();

            p.Show();*/ //111111111111


            /*Passport p = new Passport("Ivan", "Petrenko", "Ukraine", "AA123456");

            ForeignPassport fp = new ForeignPassport("Oleg","Shevchenko", "Ukraine", "BE654331", "FP987654","Poland");

            p.Print();

            Console.WriteLine();

            fp.Show();*/ //222222222222

            Tiger t = new Tiger("Tiger", "Fast and strong");
            Crocodile c = new Crocodile("Crocodile", "Lives in water");
            Kangaroo k = new Kangaroo("Kangaroo", "Can jump high");

            t.Print();
            Console.WriteLine();

            c.Print();
            Console.WriteLine();

            k.Print();
        }
    }
}
