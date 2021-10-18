using Microsoft.EntityFrameworkCore;
using System;
using User.Domain;
using User.Domain.Model;

namespace User1.Data.Context
{
    public class UserContext : DbContext
    {
        public UserContext()
        {

        }
        public UserContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TestUser> Users { get; set; }
    }
}
