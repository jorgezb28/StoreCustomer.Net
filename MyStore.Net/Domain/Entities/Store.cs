using System.Collections.Generic;

namespace Domain.Entities
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
       public ICollection<Employee> Employees { get; set; }
    }
}
