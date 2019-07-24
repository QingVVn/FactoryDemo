using System;

namespace FactoryDemo.ApplicationDemo.Builder
{
    public class BenzBuilder : ICarBuilder
    {
        public void BuildWheel()
        {
            Console.WriteLine(new MichelinWheel().BuildWheel());
        }

        public void BuildEngine()
        {
            Console.WriteLine(new NaturalEngine().BuildEngine());
        }
    }
}
