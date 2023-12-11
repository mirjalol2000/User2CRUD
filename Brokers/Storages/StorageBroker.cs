using EFxceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        public DbSet<User> Users { get; set; }

        public StorageBroker()=>
            this.Database.EnsureCreated();        
        


        public async ValueTask<User> InsertUserAsync(User user)
        {
            await this.Users.AddAsync(user);
            await this.SaveChangesAsync(); 

            return user;    
        }

        public async ValueTask<User> SelectUserByIdAsync(Guid userId)=>
            await this.Users.FirstOrDefaultAsync(u => u.Id == userId);

        public IQueryable<User> SelectAllUsers()=>
         this.Users.AsQueryable();

        public async ValueTask<User> UpdateUserAsync(User updatedUser)
        {
            var user = this.Users.Find(updatedUser.Id);
            this.Entry(user).CurrentValues.SetValues(updatedUser);

            await this.SaveChangesAsync();

            return updatedUser;
        }

        public async ValueTask<User> DeleteUserAsync(User user)
        {
            this.Users.Remove(user);
            await this.SaveChangesAsync();

            return user;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = User2CRUD.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
