using System.Threading.Tasks;
using User2CRUD.Models.Users;

namespace User2CRUD.Services.Foundations.Users
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);    
    }
}
