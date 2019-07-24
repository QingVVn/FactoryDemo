namespace FactoryDemo.ApplicationDemo
{
    public interface ICarFactory
    {
       ICar GetBenzCar();
       ICar GetTeslaCar();
    }
}
