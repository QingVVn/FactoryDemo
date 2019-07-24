namespace FactoryDemo.ApplicationDemo
{
    public class BusinessCarFactory : ICarFactory
    {
        public ICar GetBenzCar()
        {
            return new BenzBusinessCar();
        }

        public ICar GetTeslaCar()
        {
            return new TeslaBusinessCar();
        }
    }
}
