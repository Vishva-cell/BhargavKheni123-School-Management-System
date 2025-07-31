using System.Linq;
using digital.Models;
using System.Data;
namespace digital.Repositories
{
    public class UserRepository : IUserRepository
    {
       private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
        public List<User> GetTeachers()
        {
            return _context.Users.Where(u => u.Role == "Teacher").ToList();
        }
    }
}
