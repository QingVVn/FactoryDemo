using System;

namespace FactoryDemo.ApplicationDemo.Builder
{
    public class EagleWheel : IWheel
    {
        public string BuildWheel()
        {
            return "Eagle Wheel";
        }
    }
}
