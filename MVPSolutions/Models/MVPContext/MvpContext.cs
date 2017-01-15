using MVPSolutions.Models.MVPModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MVPSolutions.Models.MVPContext
{
    public class MvpContext : DbContext
    {
        public MvpContext() : base("name=MvpStoryTellingStylingEntities")
        {
        }

        public DbSet<Concepts> Concepts { get; set; }

        public DbSet<Stories> Stories { get; set; }

        public DbSet<Pics> Pics { get; set; }

        public DbSet<Credits> Credits { get; set; }

    }
}