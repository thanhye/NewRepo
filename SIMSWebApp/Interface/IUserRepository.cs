using Microsoft.EntityFrameworkCore.Metadata;
using SIMSWebApp.DatabaseContext.Entities;

namespace SIMSWebApp.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
        Task<User> GetUserByID(int id);
        Task AddSync(User user);

        Task SaveChangeASync();
    }
}
