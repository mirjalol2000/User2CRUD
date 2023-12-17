using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Feedbacks;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback);
        IQueryable<Feedback> SelectAllFeedbacks();
       
    }
}
