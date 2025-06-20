namespace Assignment3._3
{
    using System;

    class Employee
    {
        // Properties
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        // Constructor
        public Employee(int empNo, string name, decimal salary)
        {
            EmpNo = empNo;
            Name = name;
            Salary = salary;
        }

        // Method to display employee details
        public void Display()
        {
            Console.WriteLine($"EmpNo: {EmpNo}, Name: {Name}, Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of employees: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Employee[] empArr = new Employee[count];

            // Accept details for each employee
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter details for employee {i + 1}:");

                Console.Write("Enter EmpNo: ");
                int empNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                empArr[i] = new Employee(empNo, name, salary);
            }

            // Find employee with highest salary
            Employee highestSalaryEmp = empArr[0];
            for (int i = 1; i < empArr.Length; i++)
            {
                if (empArr[i].Salary > highestSalaryEmp.Salary)
                {
                    highestSalaryEmp = empArr[i];
                }
            }

            Console.WriteLine("\nEmployee with the highest salary:");
            highestSalaryEmp.Display();

            // Search for employee by EmpNo
            Console.Write("\nEnter EmpNo to search: ");
            int searchEmpNo = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            foreach (Employee emp in empArr)
            {
                if (emp.EmpNo == searchEmpNo)
                {
                    Console.WriteLine("Employee found:");
                    emp.Display();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee with given EmpNo not found.");
            }
        }
    }

}
