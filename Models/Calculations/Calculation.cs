using System;
using System.Text.Json.Serialization;
using User2CRUD.Models.Users;

namespace User2CRUD.Models.Calculations
{
    public class Calculation
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public Function Function { get; set; }
        public string UserName { get; set; }

        [JsonIgnore]
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }

    }
}
