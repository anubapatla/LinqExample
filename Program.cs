namespace LinqExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public required string EmpName { get; set; }
        public required string Job { get; set; }
        public required string City { get; set; }

    }
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>() {
        new Employee(){EmpID=101,EmpName="Henry",Job="designer",City="boster" },
        new Employee(){EmpID=102,EmpName="anu",Job="manager",City="canada" },
        new Employee(){EmpID=103,EmpName="pravasthi",Job="developer",City="usa" }

        };
            var result = employees.Where(emp => emp.Job == "developer");
            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID + "," + item.EmpName + "," + item.Job + "," + item.City
                    );
               
            }
            Console.ReadKey();

        }

    }
    
}
