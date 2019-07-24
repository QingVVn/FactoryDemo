using System;
using FactoryDemo.ApplicationDemo;
using FactoryDemo.FactoryMethod;
using FactoryDemo.SimpleFactory;
using IFactory = FactoryDemo.FactoryMethod.IFactory;

namespace FactoryDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("general method");
            TeslaCar tesla = new TeslaCar();
            Console.WriteLine(tesla.Build());
            Console.WriteLine("---------------------------");

            Console.WriteLine("simple factory");
            CarFactory factory = new CarFactory();
            Car audiCar = factory.CreateCar("Audi");
            Console.WriteLine(audiCar.Build());
            Console.WriteLine("---------------------------");

            Console.WriteLine("factory method");
            IFactory carFactory = new BenzFactory();
            Car benZCar = carFactory.CreateCar();
            Console.WriteLine(benZCar.Build());
            Console.WriteLine("---------------------------");

            Console.WriteLine("abstract factory");
            ICarFactory sportCarFactory = new SportCarFactory();
            ICar benzSportCar = sportCarFactory.GetBenzCar();
            ICar teslaSportCar = sportCarFactory.GetTeslaCar();
            benzSportCar.BuildCar();
            teslaSportCar.BuildCar();
            Console.ReadKey();
        }
    }
}
