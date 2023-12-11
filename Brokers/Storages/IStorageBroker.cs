using System.Threading.Tasks;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
    }
}
