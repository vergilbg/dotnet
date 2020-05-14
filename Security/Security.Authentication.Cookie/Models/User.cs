using System.Collections.Generic;

namespace Security.Authentication.Cookie.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<User> GetUsers()
        {
            return new List<User>() 
            {
                new User 
                {
                    UserName = "username",
                    Password = "password"
                }
            };
        }
    }
}