using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Brokers.Storages;
using User2CRUD.Models.Feedbacks;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Foundations.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IStorageBroker storageBroker;

        public FeedbackService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Feedback> AddFeedbackAsync(Feedback feedback) =>
            await this.storageBroker.InsertFeedbackAsync(feedback);

        public IQueryable<Feedback> RetrieveAllFeedbacks() =>
            this.storageBroker.SelectAllFeedbacks();

       
    }
}
