using DSRPrac.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DSRPrac.DAL
{
    public class DSRContext:DbContext
    {
       public DbSet<Users> users { get; set; }

    }
}