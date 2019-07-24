using FactoryDemo.SimpleFactory;

namespace FactoryDemo.FactoryMethod
{
    public class AudiFactory : IFactory
    {
        public Car CreateCar()
        {
            return new TeslaCar();
        }
    }
}
