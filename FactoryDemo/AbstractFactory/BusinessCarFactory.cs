using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.AbstractFactory
{
    public class BusinessCarFactory : ICarFactory
    {
        public IBenzCar getBenzCar()
        {
            return new BenzBusinessCar();
        }

        public ITeslaCar getTeslaCar()
        {
            return new TeslaBusinessCar();
        }
    }
}
