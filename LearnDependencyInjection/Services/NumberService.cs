namespace LearnDependencyInjection.Services
{
    public class NumberService : INumberService
    {
        private readonly int _number;

        public NumberService()
        {
            _number = Random.Shared.Next(1, 100);
        }

        public int GetNumber()
        {
            return _number;
        }

        
    }
}
