using digital.Models;
using System.Collections.Generic;
using System.Linq;

namespace digital.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<User> GetAdmins()
        {
            return _context.Users
                .Where(u => u.Role == "Admin")
                .ToList();
        }
    }
}
