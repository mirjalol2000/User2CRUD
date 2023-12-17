using Microsoft.AspNetCore.Mvc;
using System.Linq;
using User2CRUD.Models.Feedbacks;
using User2CRUD.Services.Processings.Feedbacks;

namespace User2CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackProcessingService feedbackProcessingService;

        public FeedbackController(IFeedbackProcessingService feedbackProcessingService)
        {
            this.feedbackProcessingService = feedbackProcessingService;
        }

        [HttpGet]
        public ActionResult<IQueryable<Feedback>> Getfeedbacks()
        {
            var feedbacks = this.feedbackProcessingService.RetrieveAllFeedbacks();

            return Ok(feedbacks);
        }
    }
}
