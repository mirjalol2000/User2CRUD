using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Processings.Users
{
    public interface IUserProcessingService
    {
        User RetrieveUserByName(string name);
        ValueTask<User> AddUserAsync(User user);
        ValueTask<User> RetrieveUserByIdAsync(Guid userId);
        IQueryable<User> RetrieveAllUsers();
        ValueTask<User> ModifyUserAsync(User user);
        ValueTask<User> RemoveUserAsync(Guid userId);
    }
}
