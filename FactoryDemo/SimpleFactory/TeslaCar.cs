using FactoryDemo.SimpleFactory;

namespace FactoryDemo
{
    public class TeslaCar : Car
    {
        public override string Build()
        {
            return "Build Tesla Car";
        }
    }
}
