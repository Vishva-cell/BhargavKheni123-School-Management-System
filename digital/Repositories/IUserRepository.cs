using digital.Models;

namespace digital.Repositories
{
    public interface IUserRepository
    {
        User GetUserByEmailAndPassword(string email, string password);
        List<User> GetTeachers();
    }
}
