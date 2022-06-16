using System;
using System.Collections.Generic;
using System.Data.Entity;
using BusinessLogic;
using System.Text;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
