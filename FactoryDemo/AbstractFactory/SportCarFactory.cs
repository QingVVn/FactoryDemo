using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.AbstractFactory
{
    public class SportCarFactory : ICarFactory
    {
        public IBenzCar getBenzCar()
        {
            return new BenzSportCar();
        }

        public ITeslaCar getTeslaCar()
        {
            return new TeslaSportCar();
        }
    }
}
