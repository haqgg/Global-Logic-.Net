using System;

namespace курсы
{
    public class Shape
    {
        public int LengthOne { get; set; }
        public int LengthSecond { get; set; }
        public int LengthThree { get; set; }
        public int WidthOne { get; set; }
        public int WidthSecond { get; set; }
        public int Height { get; set; }
        public double Area { get; set; }
        public string Name { get; set; }

        public Shape(int lengthOne, int lengthSecond, int lengthThree, string name, double area)
        {
            LengthOne = lengthOne;
            LengthSecond = lengthSecond;
            LengthThree = lengthThree;
            Name = name;
            Area = area;
        }

        public Shape(int lengthOne, string name, double area)
        {
            LengthOne = lengthOne;
            Name = name;
            Area = area;
        }

        public Shape(int lengthOne, string name, double area, int height)
        {
            LengthOne = lengthOne;
            Name = name;
            Area = area;
            Height = height;
        }

        public Shape(int lengthOne, int lengthSecond, int widthOne, int widthSecond, int height, string name, double area)
        {
            LengthOne = lengthOne;
            LengthSecond = lengthSecond;
            WidthOne = widthOne;
            WidthSecond = widthSecond;
            Height = height;
            Name = name;
            Area = area;
        }

        public void Print()
        {
            Console.WriteLine("Name of figure: " + Name);
            Console.WriteLine("S of figure: " + Area);
        }
    }

    public class Triangle : Shape
    {
        public Triangle(int lengthOne, int lengthSecond, int lengthThree, string name, double area) : base(lengthOne, lengthSecond,
            lengthThree, name, area)
        {
            var halfPerimetr = (lengthOne + lengthSecond + lengthThree) / 2f;
            area = Math.Sqrt(halfPerimetr * (halfPerimetr - lengthOne) * (halfPerimetr - lengthSecond) *
                             (halfPerimetr - lengthThree));
            this.Area = area;
            Print();
        }
    }

    public class Square : Shape
    {
        public Square(int lengthOne, string name, double area) : base(lengthOne, name, area)
        {
            area = Math.Pow(lengthOne, 2);
            this.Area = area;
            Print();
        }
    }

    public class Rhombus : Shape
    {
        public Rhombus(int lengthOne, string name, double area, int height) : base(lengthOne, name, area, height)
        {
            area = lengthOne * height;
            this.Area = area;
            Print();
        }
    }

    public class Trapeze : Shape
    {
        public Trapeze(int lengthOne, int lengthSecond, int widthOne, int widthSecond, int height, string name, double area) : base(
            lengthOne, lengthSecond, widthOne, widthSecond, height, name, area)
        {
            area = ((lengthOne + lengthSecond) / 2) * height;
            this.Area = area;
            Print();
        }
    }

    public class Employee
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private char Gender { get; set; }
        private int Age { get; set; }
        private string Prof { get; set; }
        private int Salary { get; set; }

        protected Employee(string name, string surname, char gender, string prof)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Prof = prof;
        }

        protected void Print()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Sex: {0}", Gender);
            Console.WriteLine("Job: {0}", Prof);
        }
    }
    public class Designer : Employee
    {
        public Designer(string name, string surname, char gender, string prof) : base(name, surname, gender, prof)
        {
            Print();
        }
    }
    public class Architect : Employee
    {
        public Architect(string name, string surname, char gender, string prof) : base(name, surname, gender, prof) {
            Print();
        }
    }

    public class Artist : Employee
    {
        public Artist(string name, string surname, char gender, string prof) : base(name, surname, gender, prof)
        {
            Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(5, 10, 14, "Треугольник", 0.0);
            Console.WriteLine();
            Square sq = new Square(7, "Квадрат", 0.0);
            Console.WriteLine();
            Rhombus rh = new Rhombus(11, "Ромб", 0.0, 4);
            Console.WriteLine();
            Trapeze tra = new Trapeze(10, 8, 6, 7, 5, "Трапеция", 0.0);
            Console.WriteLine();
            Designer de = new Designer("Ricardo", "Milos", 'M', "Designer");
            Console.WriteLine();
            Architect ar = new Architect("Frank", "Ocaen", 'M', "Architect");
            Console.WriteLine();
            Artist art = new Artist("Bruh", "Moment", 'M', "Artist");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
