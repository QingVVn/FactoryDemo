namespace FactoryDemo.AbstractFactory
{
    public class TeslaBusinessCar : ITeslaCar
    {
        public string Build()
        {
            return "Tesla Business Car";
        }
    }
}
