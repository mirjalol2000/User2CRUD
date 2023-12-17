using System.Threading.Tasks;
using User2CRUD.Models.Calculations;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Processings.Calculations
{
    public interface ICalculationProcessingService
    {
        ValueTask<string> Calculate(Calculation calculation, User user);
    }
}
