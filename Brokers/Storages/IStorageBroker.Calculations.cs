using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Calculations;

namespace Calculation2CRUD.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Calculation> InsertCalculationAsync(Calculation calculation);
        IQueryable<Calculation> SelectAllCalculations();
        ValueTask<Calculation> SelectCalculationByIdAsync(Guid calculationId);
        ValueTask<Calculation> UpdateCalculationAsync(Calculation calculation);
        ValueTask<Calculation> DeleteCalculationAsync(Calculation calculation);
    }
}
