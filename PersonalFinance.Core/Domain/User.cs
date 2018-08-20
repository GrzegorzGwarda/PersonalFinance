using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.Core.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        public User(){}

        public User(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            CreatedAt = DateTime.UtcNow;
        }


    }
}
