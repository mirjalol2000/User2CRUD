using Calculation2CRUD.Brokers.Storages;
using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Calculations;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Foundations.Calculations
{
    public class CalculationService : ICalculationService
    {
        private readonly IStorageBroker storageBroker;

        public CalculationService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }


        public async ValueTask<Calculation> AddCalculationAsync(Calculation calculation) =>
            await this.storageBroker.InsertCalculationAsync(calculation);

        public async ValueTask<Calculation> RetrieveCalculationByIdAsync(Guid calculationId) =>
            await this.storageBroker.SelectCalculationByIdAsync(calculationId);
        
        public IQueryable<Calculation> RetrieveAllCalculations() =>
            this.storageBroker.SelectAllCalculations();


        public async ValueTask<Calculation> ModifyCalculationAsync(Calculation calculation) =>
           await this.storageBroker.UpdateCalculationAsync(calculation);

        public async ValueTask<Calculation> RemoveCalculationAsync(Guid calculationId)
        {
            var calculation = await this.storageBroker.SelectCalculationByIdAsync(calculationId);

            return await this.storageBroker.DeleteCalculationAsync(calculation);
        }
    }
}
