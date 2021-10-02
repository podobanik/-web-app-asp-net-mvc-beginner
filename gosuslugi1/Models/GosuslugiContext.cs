using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gosuslugi1.Models
{
    public class GosuslugiContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public GosuslugiContext() : base("GosuslugiEntity")
        { }
    }
}