using DSRPrac.DAL;
using DSRPrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSRPrac.Manager
{
    public class UsersManager
    {
        DSRContext dSRContext = new DSRContext();
        public Users Add(Users users)
        {
            dSRContext.users.Add(users);
            dSRContext.SaveChanges();
            return users;
        }
    }
}