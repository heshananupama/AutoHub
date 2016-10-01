using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoHubServices.Models
{
    public class UsersRepository
    {
        private static AutohubEntities dataContext = new AutohubEntities();
        public static List<User> GetAllUsers()
        {
            var query = from User in dataContext.Users
                        select User;
            return query.ToList();
        }
    }
} 