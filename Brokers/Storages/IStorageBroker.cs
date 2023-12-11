using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        ValueTask<User> SelectUserByIdAsync(Guid userId);
        IQueryable<User> SelectAllUsers();
        ValueTask<User> UpdateUserAsync(User user);

        ValueTask<User> DeleteUserAsync(User user);
    }
}
