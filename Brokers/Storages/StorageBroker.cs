using EFxceptions;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = User2CRUD.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
