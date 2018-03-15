using System.Data.Entity;
using Domain.Entities;
using Domain.Generic;
using Infraestructure.Generic;

namespace Infraestructure.Repositories
{
    public class EmployeeRepository:Repository<Employee>, IEmployeeRepository
    {
        private DbSet<Employee> _employees;

        public EmployeeRepository()
        {
            var context = new MyStoreDbContext();
            _employees = context.Employees;
        }
    }
}
