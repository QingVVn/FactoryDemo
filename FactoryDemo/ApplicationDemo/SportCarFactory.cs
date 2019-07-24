namespace FactoryDemo.ApplicationDemo
{
    public class SportCarFactory : ICarFactory
    {
        public ICar GetBenzCar()
        {
            return new BenzSportCar();
        }

        public ICar GetTeslaCar()
        {
            return new TeslaSportCar();
        }
    }
}
