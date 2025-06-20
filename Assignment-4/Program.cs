using System.Security.Cryptography.X509Certificates;

namespace Assignment_4._1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("EMployee List");

            List<Employee> list = new List<Employee>();
            string choice;
            do
            {
                Console.WriteLine("Enter Employee detals: ");
                Console.WriteLine();

                Console.WriteLine("Enter EmpNo: ");
                int empNo = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Salary: ");
                decimal basic = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter DeptNo: ");
                short deptNo = Convert.ToInt16(Console.ReadLine());


                list.Add(new Employee(empNo, name, basic, deptNo));
                  Console.WriteLine("Do you want to add more employee?(yes/no): ");

                choice = Console.ReadLine().ToLower();



            }
            while (choice == "yes");

            if (list.Count > 0)
            {
                Employee highest = list[0];
                foreach (Employee emp in list)
                {
                    if (emp.Basic > highest.Basic)
                        highest = emp;
                }

                Console.WriteLine("Employee with highest salary: ");
                highest.Display();
            }
            else
            {
                Console.WriteLine("No Emp entered");
                return;
            
            }

            Console.Write("Enter EmpNo to search: ");
            int searchNo = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            foreach (Employee emp in list)
            {

                if (emp.EmpNo == searchNo)
                {
                    Console.WriteLine("Employee found: ");
                    emp.Display();
                    found = true;
                    break;
                }
                
 
            }
            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }

            Console.Write("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1 && n <= list.Count)
            {
                Console.WriteLine("Details of Employee : " + n);
                list[n - 1].Display();

            }
            else {
                Console.WriteLine("Invalid N");
            }



        }
        static void Main2()
        {
            Employee[] empArr = new Employee[3];

            empArr[0] = new Employee(101, "Mukta", 50000, 10);
            empArr[1] = new Employee(102, "Mukta1", 60000, 20);
            empArr[2] = new Employee(103, "Mukta2", 100000, 30);

            List<Employee> empList = empArr.ToList();

            Console.WriteLine("List of employee: ");
            foreach (Employee emp in empList)
            {
                emp.Display();
            }

        }
        static void Main()
        {
            List<Employee> list = new List<Employee>
          {
            new Employee(101, "Mukta", 60000, 10),
            new Employee(102, "Mukta1", 70000, 20),
            new Employee(103, "Mukta2", 80000, 30),

          };
            Employee[] empArr = list.ToArray();
            Console.WriteLine("Array of Employee:");
            foreach (Employee emp in empArr)
            {
                emp.Display();
            }
        }
    }
    public class Employee
    { 
      public int EmpNo { get; set; }

      public string Name { get; set; }

      public decimal Basic { get; set; }

      public short DeptNo { get; set; }

        public Employee(int empNo, string name, decimal basic, short deptNo)
         {
                EmpNo = empNo;
                Name = name;
                Basic = basic;
                DeptNo = deptNo;

            }
            public void Display()
            {
            Console.WriteLine($"EmpNo: {EmpNo}, Name: {Name}, Salary: {Basic}, DeptNo:{DeptNo}");


            }

       

          
    }
}
