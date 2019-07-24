namespace FactoryDemo.AbstractFactory
{
    public class TeslaSportCar : ITeslaCar
    {
        public string Build()
        {
            return "Tesla Sport Car";
        }
    }
}
