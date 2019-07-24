using System;
using FactoryDemo.ApplicationDemo.Builder;

namespace FactoryDemo.ApplicationDemo
{
    public class TeslaSportCar : ICar
    {
        private readonly CarDirector _director = new CarDirector();

        public void BuildCar()
        {
            TeslaBuilder builder = new TeslaBuilder();
            _director.Construct(builder);
            Console.WriteLine("Tesla Sport Car");
        }
    }
}
