using EFxceptions;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {

        public StorageBroker() =>
            this.Database.EnsureCreated();

        public async ValueTask<T> InsertAsync<T> (T @object)
        {
            var broker = new StorageBroker();
            broker.Entry(@object).State = EntityState.Added;
            await this.SaveChangesAsync();

            return @object;
        }

        public IQueryable<T> SelectAll<T>() where T : class
        {
            var broker = new StorageBroker();

            return broker.Set<T>();
        }

        public async ValueTask<T> SelectAsync<T>(params object[] objectId) where T : class
        {
            var broker = new StorageBroker();

            return await broker.FindAsync<T>(objectId);
        }

        public async ValueTask<T> UpdateAsync<T>(T @object)
        {
            var broker = new StorageBroker();
            broker.Entry(@object).State = EntityState.Modified;
            await this.SaveChangesAsync();

            return (@object);
        }

        public async ValueTask<T> DeleteAsync<T>(T @object)
        {
            var broker = new StorageBroker();
            broker.Entry("@object").State = EntityState.Deleted;
            await this.SaveChangesAsync();  

            return @object;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source = User2CRUD.db";
            optionsBuilder.UseSqlite(connectionString);
        }

        
    }
}
