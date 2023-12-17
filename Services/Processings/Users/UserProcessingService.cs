using System;
using System.Linq;
using System.Threading.Tasks;
using User2CRUD.Models.Users;
using User2CRUD.Models.Users.Exceptions;
using User2CRUD.Services.Foundations.Users;

namespace User2CRUD.Services.Processings.Users
{
    public class UserProcessingService : IUserProcessingService
    {
        private readonly IUserService userService;

        public UserProcessingService(IUserService userService)
        {
            this.userService = userService;
        }

        public User RetrieveUserByName(string userName)
        {
            var maybeUser  = this.userService.RetrieveAllUsers()
                .FirstOrDefault(u=> u.FirstName == userName);
            if(maybeUser == null)
                throw new UserNotFoundByNameException(userName);
            else
            {
                return maybeUser;
            }
            
        }

        public async ValueTask<User> AddUserAsync(User user) =>
            await this.userService.AddUserAsync(user);

        public IQueryable<User> RetrieveAllUsers() =>
            this.userService.RetrieveAllUsers();

        public async ValueTask<User> ModifyUserAsync(User user) =>
           await this.userService.ModifyUserAsync(user);

        public async ValueTask<User> RemoveUserAsync(Guid userId) =>
           await this.userService.RemoveUserAsync(userId);
       

        public async ValueTask<User> RetrieveUserByIdAsync(Guid userId) =>
            await this.userService.RetrieveUserByIdAsync(userId);
    }
}
