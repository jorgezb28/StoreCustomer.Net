namespace Domain.Entities
{
    public class Employee
    {
        public int  EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
