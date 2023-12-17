using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Calculations;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Calculation> Calculations { get; set; }

        public async ValueTask<Calculation> InsertUserAsync(Calculation calculation) =>
            await InsertUserAsync(calculation);


        public IQueryable<Calculation> SelectAllCalculations() =>
            SelectAll<Calculation>();
         
        public async ValueTask<Calculation> SelectCalculationByIdAsync(Guid calculationId) =>
            await SelectAsync<Calculation>(calculationId);

        public async ValueTask<Calculation> UpdateCalculationAsync(Calculation calculation) =>
            await UpdateAsync(calculation);


        public async ValueTask<Calculation> DeleteCalculationAsync(Calculation calculation) =>
            await DeleteAsync(calculation);

    }
}
