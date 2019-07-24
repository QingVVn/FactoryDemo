using System;

namespace FactoryDemo.ApplicationDemo.Builder
{
    public class MichelinWheel : IWheel
    {
        public string BuildWheel()
        {
            return "Michelin Wheel";
        }
    }
}
