using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Feedbacks;
using User2CRUD.Models.Users;

namespace User2CRUD.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Feedback> Feedbacks { get; set; }

        public async ValueTask<Feedback> InsertFeedbackAsync(Feedback feedback) =>
            await InsertAsync(feedback);


        public IQueryable<Feedback> SelectAllFeedbacks() =>
            SelectAll<Feedback>();

    }
}
