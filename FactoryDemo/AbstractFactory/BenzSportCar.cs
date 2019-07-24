using FactoryDemo.SimpleFactory;

namespace FactoryDemo.AbstractFactory
{
    public class BenzSportCar : IBenzCar
    {
        public string Build()
        {
            return "Benz Sport Car";
        }
    }
}
