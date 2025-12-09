namespace LearnDependencyInjection.Services
{
    public class NumberService : INumberService
    {

        public Guid GetNumber()
        {
            return Guid.NewGuid();
        }

        
    }
}
