namespace FactoryDemo.SimpleFactory
{
    public class CarFactory
    {
        public Car CreateCar(string carType)
        {
            Car car;
            if (carType.Equals("Benz"))
            {
                car = new BenzCar();
            }
            else if(carType.Equals("Audi"))
            {
                car = new AudiCar();
            }
            else
            {
                car = new TeslaCar();
            }

            return car;
        }
    }
}
