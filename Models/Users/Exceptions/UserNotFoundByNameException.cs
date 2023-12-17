using Xeptions;

namespace User2CRUD.Models.Users.Exceptions
{
    public class UserNotFoundByNameException : Xeption
    {
        public UserNotFoundByNameException(string userName)
            : base(message : $"User not found with name : {userName}, please register")
        {
                
        }
    }
}
