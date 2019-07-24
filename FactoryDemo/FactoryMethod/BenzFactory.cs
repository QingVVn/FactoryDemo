using FactoryDemo.SimpleFactory;

namespace FactoryDemo.FactoryMethod
{
    public class BenzFactory : IFactory
    {
        public Car CreateCar()
        {
            return new BenzCar();
        }
    }
}
