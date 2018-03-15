using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infraestructure.Generic
{
    public class MyStoreDbContext:DbContext
    {
        public MyStoreDbContext() : base("name=MyStoreContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
