using System.Threading.Tasks;
using User2CRUD.Models.Calculations;

namespace User2CRUD.Services.Orchestration
{
    public interface ICalculationOrchestrationService
    {
        ValueTask<string> ManageAllFunctions(string userName, Calculation calculation);
    }
}
