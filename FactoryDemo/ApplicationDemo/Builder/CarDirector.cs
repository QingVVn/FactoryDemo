namespace FactoryDemo.ApplicationDemo.Builder
{
    public class CarDirector
    {
        public void Construct(ICarBuilder builder)
        {
            builder.BuildWheel();
            builder.BuildEngine();
        }
    }
}
