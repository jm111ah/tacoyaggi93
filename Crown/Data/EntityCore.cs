using Crown.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Data
{
    public class EntityCore : DbContext
    {
        public EntityCore(DbContextOptions options) : base(options) { }
        public DbSet<Login> EF_Login { get; set; }
        public DbSet<SignUp> EF_SignUp { get; set; }

    }
}
