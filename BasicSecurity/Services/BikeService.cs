using BasicSecurity.Models;
using System.Text.Json;

namespace BasicSecurity.Services
{
    public class BikeService : IBikeService
    {
        private const string _path = @"C:\Users\eliseog\Documents\16R137\BasicSecurity\BasicSecurity\Data\Bikes.json";
        public async Task<List<Bike>> Get()
        {
            string content = await File.ReadAllTextAsync(_path);
            var bikes = JsonSerializer.Deserialize<List<Bike>>(content);
            return bikes;
        }
    }
}
