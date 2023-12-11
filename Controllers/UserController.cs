using Microsoft.AspNetCore.Mvc;
using User2CRUD.Models.Users;
using User2CRUD.Services.Foundations.Users;

namespace User2CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            return this.userService.AddUser(user);
        }
    }
}
