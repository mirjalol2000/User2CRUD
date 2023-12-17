using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Feedbacks;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Foundations.Feedbacks
{
    public interface IFeedbackService
    {
        ValueTask<Feedback> AddFeedbackAsync(Feedback feedback);
       
        IQueryable<Feedback> RetrieveAllFeedbacks();
       
    }
}
