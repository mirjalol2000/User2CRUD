using System;
using System.Text.Json.Serialization;
using User2CRUD.Models.Users;

namespace User2CRUD.Models.Feedbacks
{
    public class Feedback
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Answer { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
