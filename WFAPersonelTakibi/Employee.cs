using System;

namespace WFAPersonelTakibi
{
    public enum Gender
    {
        Male, Female, Random
    }
    public class Employee
    {
        public Employee()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageUrl { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
    }

    public class Department
    {
        public Department()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}


