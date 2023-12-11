using System.Threading.Tasks;
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

        public async ValueTask<User> AddUserAsync(User user)=>
            await this.storageBroker.InsertUserAsync(user);
        
    }
}
