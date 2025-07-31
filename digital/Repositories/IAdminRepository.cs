using digital.Models;
using System.Collections.Generic;

namespace digital.Repositories
{
    public interface IAdminRepository
    {
        List<User> GetAdmins();
    }
}
