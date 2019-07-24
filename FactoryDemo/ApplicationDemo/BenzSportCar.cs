using System;
using FactoryDemo.ApplicationDemo.Builder;

namespace FactoryDemo.ApplicationDemo
{
    public class BenzSportCar : ICar
    {
        private readonly CarDirector _director = new CarDirector();

        public void BuildCar()
        {
            BenzBuilder builder = new BenzBuilder();
            _director.Construct(builder);
            Console.WriteLine("Benz Sport Car");
        }
    }
}
