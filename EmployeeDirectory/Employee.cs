namespace EmployeeDirectory
{
    internal class Employee
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Salary { get; set; }


        public Employee()
        {
            Employee employee = new Employee();
        }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}