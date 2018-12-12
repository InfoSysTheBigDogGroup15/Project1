using Project1.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project1.DAL
{
    public class StrawContext : DbContext 
    {
        public StrawContext() : base("StrawContext")
        {

        }

        public DbSet<Inventories> Inventory { get; set; }
        public DbSet<Straws> Straw { get; set; }
        public DbSet<Users> User { get; set; }
    }
}