using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using User2CRUD.Models.Calculations;
using User2CRUD.Services.Orchestration;

namespace User2CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculationController : Controller
    {
        private readonly ICalculationOrchestrationService calculationOrchestrationService;

        public CalculationController(ICalculationOrchestrationService calculationOrchestrationService)
        {
            this.calculationOrchestrationService = calculationOrchestrationService;
        }

       /* [HttpPost]
        public async ValueTask<ActionResult<string>> GetFeedback (
            string userName, Calculation calculation)
        {
            var feedback = await this.calculationOrchestrationService.ManageAllFunctions(userName,calculation);

            return Ok(feedback);
        }*/
    }
}
