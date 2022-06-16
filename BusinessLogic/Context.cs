using System;
using System.Collections.Generic;
using System.Data.Entity;
using BusinessLogic;
using System.Text;

namespace BusinessLogic
{
    public class Context : DbContext
    {
        public DbSet<Producer> Producers { get; set; }
    }
}
