using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<User> Users {  get; set; }

        public async ValueTask<User> InsertUserAsync(User user)=>
            await InsertAsync(user);


        public IQueryable<User> SelectAllUsers() =>
            SelectAll<User>();
        
        public async ValueTask<User> SelectUserByIdAsync(Guid userId)=>
            await SelectAsync<User>(userId);

        public async ValueTask<User> UpdateUserAsync(User user) =>
            await UpdateAsync(user);
        

        public async ValueTask<User> DeleteUserAsync(User user) =>
            await DeleteAsync(user);
        
    }
}
