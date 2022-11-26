using System;

namespace OOP_5_1
{
    public class Printer
    {
        private string value;

        public string Value
        {
            get { return value; }
            set { value.ToString(); }
        }

        public Printer()
        {
            value = "Student";
        }

        public Printer(string value)
        {
            this.value = value;
        }

        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    public class Name : Printer
    {
        private string firstName;
        public const string type1 = "Name";

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value.ToString(); }
        }

        public Name(string firstName) // конструктор
        {
            this.firstName = firstName;
        }

        public override void Print(string firstName)
        {
            Console.WriteLine($"Ім'я: {firstName}");
        }
    }

    public class Surname : Printer
    {
        private string lastName;
        public const string type2 = "Surname";

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Surname(string lastName)
        {
            this.lastName = lastName;
        }

        public override void Print(string lastName)
        {
            Console.WriteLine($"Прізвище: {lastName}");
        }
    }

    public class University : Printer
    {
        private string univer;
        public const string type3 = "University";

        public string Univer
        {
            get { return univer; }
            set { univer = value; }
        }

        public University(string univer)
        {
            this.univer = univer;
        }

        public override void Print(string univer)
        {
            Console.WriteLine($"Університет: {univer}");
        }
    }

    public class Course : Printer
    {
        private string cours;
        public const string type4 = "Course";

        public string Cours
        {
            get { return cours; }
            set { cours = value; }
        }

        public Course(string cours)
        {
            this.cours = cours;
        }

        public override void Print(string cours)
        {
            Console.WriteLine($"Курс: {cours}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Printer printer = new Printer("Student");
            printer.Print("Student");

            Name name = new Name("Andrii");
            name.Print("Andrii");

            Surname surname = new Surname("Boyko");
            surname.Print("Boyko");

            University university = new University("DTEU");
            university.Print("DTEU");

            Course course = new Course("second");
            course.Print("second");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Name.type1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Surname.type2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(University.type3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Course.type4);

            Console.ReadLine();
        }
    }
}