using User2CRUD.Brokers.Storages;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Foundations.Users
{
    public class UserService : IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public User AddUser(User user)=>
            this.storageBroker.InsertUser(user);
        
    }
}
