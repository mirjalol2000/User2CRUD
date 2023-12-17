using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using User2CRUD.Models.Calculations;
using User2CRUD.Models.Feedbacks;

namespace User2CRUD.Models.Users
{
    public class User
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public List<Calculation> Calculations { get; set; }
        [JsonIgnore]
        public List<Feedback> Feedbacks { get; set; }


        
    }
}
