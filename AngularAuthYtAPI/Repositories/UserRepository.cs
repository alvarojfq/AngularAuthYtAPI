using AngularAuthYtAPI.Models;
namespace AngularAuthYtAPI.Repositories
{
    public class UserRepository
    {
        private readonly EnvironmentConfig env;

        public UserRepository(EnvironmentConfig env) {
            this.env = env;
        }
        public async Task<User> GetUser(User AddUser)
        {

        }
    }
}
