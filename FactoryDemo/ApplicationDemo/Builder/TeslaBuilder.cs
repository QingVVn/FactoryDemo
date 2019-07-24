using System;

namespace FactoryDemo.ApplicationDemo.Builder
{
    public class TeslaBuilder : ICarBuilder
    {
        public void BuildWheel()
        {
            Console.WriteLine(new EagleWheel().BuildWheel());
        }

        public void BuildEngine()
        {
            Console.WriteLine(new TurboEngine().BuildEngine());
        }
    }
}
