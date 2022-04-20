using BasicSecurity.Models;

namespace BasicSecurity.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> users = new List<User>()
        {
            new User(){Email="test1@test.com", Password="123"},
            new User(){Email="test2@test.com", Password="123"},
            new User(){Email="test3@test.com", Password="123"},
            new User(){Email="test4@test.com", Password="123"}
        };

        public bool IsUser(string email, string password) => users.Any(x => x.Email == email && x.Password == password);
    }
}
