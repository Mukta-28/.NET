﻿namespace Linqexamples
{


    internal class Program
    {

        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        static void Main1()
        {
            ////var retval = from single_object in collection select some_data
            //var emps = from emp in lstEmp select emp;
            ////IEnumerable<Employee> emps = from emp in lstEmp select emp;

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item);
            //}

            AddRecs();

            var emps = from emp in lstEmp select emp;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }

        }
        static void Main2()
        {
            

            AddRecs();

            var emps = from emp in lstEmp select emp.Name;
           // var emps = from emp in lstEmp select emp.EmpNo;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }

        }
        static void Main3()
        {


            AddRecs();

            var emps = from emp in lstEmp select new {emp.Name, emp.EmpNo};
            
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }

        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;
            //var emps = from emp in lstEmp
            //           where emp.Basic > 10000 && emp.Basic < 12000
            //           select emp;

            //var emps = from emp in lstEmp
            //           where emp.Name.StartsWith("V")
            //           select emp;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main5()
        {
            AddRecs();

            var emps = from emp in lstEmp
                           //where emp.Basic > 10000
                       orderby emp.Name
                       select emp;
            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.DeptNo ascending, emp.Name descending
            //           select emp;


            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();
        }
        static void Main()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       join dept in lstDept
                       on emp.DeptNo equals dept.DeptNo
                       select new { emp, dept };
            foreach (var item in emps)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);
            }
            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //           on emp.DeptNo equals dept.DeptNo
            //           select new { emp.Name, dept.DeptName };

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.DeptName);
            //}
        }



    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
}
namespace Linqexamples2
{


    internal class Program
    {

        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();

        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }
        static Employee GetAllEmps(Employee emp)
        {
            return emp;
        }
        static void Main1()
        {
            ////var retval = from single_object in collection select some_data
            //var emps = from emp in lstEmp select emp;
            ////IEnumerable<Employee> emps = from emp in lstEmp select emp;

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item);
            //}

            AddRecs();

            // var emps = from emp in lstEmp select emp;
            var emps = lstEmp.Select(GetAllEmps);
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }

        }
        static string GetAllEmpNames(Employee emp)
        {
            return emp.Name;
        }
        static void Main2()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp.Name;
            //var emps = from emp in lstEmp select emp.EmpNo;
            var emps = lstEmp.Select(GetAllEmpNames);
            var emps2 = lstEmp.Select(delegate (Employee emp)
            {
                return emp.Name;
            });
            var emps3 = lstEmp.Select(emp => emp.Name);

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }

        static void Main3()
        {
            AddRecs();
            var emps = from emp in lstEmp select new { emp.Name, emp.EmpNo };
            var emps2 = lstEmp.Select(delegate (Employee emp)
            {
                return new { emp.Name, emp.EmpNo };
            });
            var emps3 = lstEmp.Select(emp => new { emp.Name, emp.EmpNo });
            foreach (var item in emps)
            {
                Console.WriteLine(item.Name);
            }
        }
        static bool IsBasicGreaterThan10000(Employee emp)
        {
            //if (emp.Basic > 10000)
            //    return true;
            //else
            //    return false;
            return emp.Basic > 10000;
        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;

            var emps2 = lstEmp.Where(IsBasicGreaterThan10000);
            var emps3 = lstEmp.Where(delegate (Employee emp)
            {
                return emp.Basic > 10000;
            });

            var emps4 = lstEmp.Where(emp => emp.Basic > 10000);

            foreach (var item in emps2)
            {
                Console.WriteLine(item);
            }
        }
        static void Main5()
        {
            AddRecs();

            var emps = from emp in lstEmp
                           //where emp.Basic > 10000
                       orderby emp.Name
                       select emp;
            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.DeptNo ascending, emp.Name descending
            //           select emp;


            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();
        }
        static void Main6()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       join dept in lstDept
                       on emp.DeptNo equals dept.DeptNo
                       select new { emp, dept };
            foreach (var item in emps)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);
            }
            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //           on emp.DeptNo equals dept.DeptNo
            //           select new { emp.Name, dept.DeptName };

            //foreach (var item in emps)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.DeptName);
            //}
        }



    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
            return s;
        }
    }
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }
}

