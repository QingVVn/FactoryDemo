using FactoryDemo.SimpleFactory;

namespace FactoryDemo.AbstractFactory
{
    public interface ICarFactory
    {
       IBenzCar getBenzCar();
       ITeslaCar getTeslaCar();
    }
}
