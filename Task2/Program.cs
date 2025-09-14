using System.Numerics;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(100, -205.5, 99990, 60, 1987);
            Vehicle plane = new Plane(18624, 9874, 130000000, 900, 2016, 10000, 481);
            Vehicle ship = new Ship(4200, 0, 2500000000, 20, 2008, "Артур", 7632);

            car.Print();
            Console.WriteLine("\n");
            plane.Print();
            Console.WriteLine("\n");
            ship.Print();
            Console.WriteLine("\n");
        }
    }
}

class Vehicle
{
    protected double x;
    protected double y;
    protected double price;
    protected double speed;
    protected int year;

    public Vehicle(double x = 0, double y = 0, double price = 0, double speed = 0, int year = 0)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public virtual void Print()
    {
        Console.WriteLine($"Координаты x: {x} y: {y}\n");
        Console.WriteLine($"Цена: {price}\n");
        Console.WriteLine($"Скорость: {speed}\n");
        Console.WriteLine($"Год выпуска: {year}\n");
    }
}
class Plane : Vehicle 
{
        double height;
        int count_of_passangers;

        public Plane(double x = 0, double y = 0, double price = 0, double speed = 0, int year = 0, double height = 0, int count_of_passangers = 0) : base(x, y, price, speed, year)
        {
            this.height = height;
            this.count_of_passangers = count_of_passangers;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Высота: {height}\n");
            Console.WriteLine($"Количество пассажиров: {count_of_passangers}\n");
        }
    }

class Car : Vehicle 
{
    public Car(double x = 0, double y = 0, double price = 0, double speed = 0, int year = 0) : base(x, y, price, speed, year) { }
}
class Ship: Vehicle
{
        string port;//Порт прописки
        int count_of_passangers;

        public Ship(double x = 0, double y = 0, double price = 0, double speed = 0, int year = 0, string port = "Undefined", int count_of_passangers = 0) : base(x, y, price, speed, year)
        {
            this.port = port;
            this.count_of_passangers = count_of_passangers;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Потр прописки: {port}\n");
            Console.WriteLine($"Количество пассажиров: {count_of_passangers}\n");
        }
}
