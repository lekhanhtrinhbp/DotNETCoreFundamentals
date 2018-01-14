using Microsoft.Extensions.Configuration;

namespace DotNETCoreFundamentals
{
    public interface IGreeter
    {
        string GetMesageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private readonly IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMesageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}