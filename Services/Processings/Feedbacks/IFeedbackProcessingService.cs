using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Feedbacks;

namespace User2CRUD.Services.Processings.Feedbacks
{
    public interface IFeedbackProcessingService
    {
        ValueTask<Feedback> AddFeedbackAsync(string answer, Guid userId);

        IQueryable<Feedback> RetrieveAllFeedbacks();
    }
}
