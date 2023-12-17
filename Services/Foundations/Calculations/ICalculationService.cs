using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Calculations;

namespace User2CRUD.Services.Foundations.Calculations
{
    public interface ICalculationService
    {
        ValueTask<Calculation> AddCalculationAsync(Calculation calculation);
        ValueTask<Calculation> RetrieveCalculationByIdAsync(Guid userId);
        IQueryable<Calculation> RetrieveAllCalculations();
        ValueTask<Calculation> ModifyCalculationAsync(Calculation calculation);
        ValueTask<Calculation> RemoveCalculationAsync(Guid userId);
    }
}
