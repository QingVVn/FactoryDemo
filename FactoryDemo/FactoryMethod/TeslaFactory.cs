using FactoryDemo.SimpleFactory;

namespace FactoryDemo.FactoryMethod
{
    public class TeslaFactory : IFactory
    {
        public Car CreateCar()
        {
            return new TeslaCar();
        }
    }
}
