using BasicSecurity.Models;

namespace BasicSecurity.Services
{
    public interface IBikeService
    {
        Task<List<Bike>> Get();
    }
}
