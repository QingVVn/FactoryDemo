using FactoryDemo.SimpleFactory;

namespace FactoryDemo.AbstractFactory
{
    public class BenzBusinessCar : IBenzCar
    {
        public string Build()
        {
            return "Benz Business Car";
        }
    }
}
