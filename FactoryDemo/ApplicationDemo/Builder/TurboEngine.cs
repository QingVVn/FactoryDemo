using System;

namespace FactoryDemo.ApplicationDemo.Builder
{
    public class TurboEngine : IEngine
    {
        public string BuildEngine()
        {
            return "Turbo Engine";
        }
    }
}
