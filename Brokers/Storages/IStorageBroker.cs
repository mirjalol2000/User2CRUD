using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public interface IStorageBroker
    {
        User InsertUser(User user);
    }
}
