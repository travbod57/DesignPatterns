namespace Adapter
{
    /// <summary>
    /// This is the TARGET
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name, string designation, decimal salary)
        {
            Id = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id: { Id }, Name: { Name }, Designation: { Designation }, Salary: { Salary.ToString("C") }";
        }
    }
}