using System.Security.Cryptography.X509Certificates;

namespace Assignment_1
{
    internal class Program
    {
        static void Main()
        {

            Employee employee = new Employee() ;
            employee.EmpNo = 1 ;
            employee.Name = "Mukta" ;
            employee.Basic = 45000 ;
            employee.DeptNo = 10 ;
            employee.GetNetSalary() ;
            Console.WriteLine(employee) ;
            Console.WriteLine("Employee's net salary" + employee.GetNetSalary()) ;


            Employee employee2 = new Employee() { EmpNo = 1, Name = "Mukta", Basic = 45000 } ;
            Console.WriteLine(employee2) ; 
            Employee employee3 = new Employee() { EmpNo = 1, Name = "Mukta"} ;
            Console.WriteLine(employee3) ; 
            Employee employee4 = new Employee() { EmpNo = 1} ;
            Console.WriteLine(employee4) ;
            Employee employee5 = new Employee() ;
            



        }
    }

    
    public class Employee
    {
      private string name ;
      public string Name
        {
            set 
            {
                if (value != null)
                    name = value ;
                else
                    Console.WriteLine("Invalid name") ;
            }
            get
            {
                return name ;
            }
        }

       private int empNo ;
       public int EmpNo
        {
            set 
            {
                if (value > 0)
                    empNo = value ;
                else
                    Console.WriteLine("invalid empNo") ;
            }
            get
            {
                return empNo ;
            }

        }

       private decimal basic ;
       public decimal Basic
        { 
            set
            {
                if (value >= 30000 && value <= 50000 ) 
                {
                    basic = value ;
                }
                else
                    Console.WriteLine("invalid basic");

            }
            get
            {
                return basic ;
            }
        }

       private short deptNo ;
       public short DeptNo
        {
            set 
            {
                if (value > 0)
                    deptNo = value ;
                else
                    Console.WriteLine("invalid DeptNo") ;
            }
            get
            {
                return deptNo;
            }
        }

        public decimal GetNetSalary()
        {
            //Example formula: Basic + HRA (40%) + DA (20%) - PF (10%)

            decimal hra = Basic * 0.40m ;
            decimal da = Basic * 0.20m ;
            decimal pf = Basic * 0.10m ;

            decimal netSalary = Basic + hra + da - pf ;
            return netSalary ;

        }

        public Employee(int empNo=1, string name="NoName", decimal basic= 30000, short deptNo=1)
        {
           this.EmpNo = EmpNo ;//property // set- validations - Dont use 
           // this.empNo = EmpNo;//variable//why we not using this because validation will not be affecting for variable
            this.Name = Name ;
            this.Basic = Basic ;
            this.DeptNo = DeptNo ;
        }
        //public override string ToString()
        //{
        //    return $"EmpNo: {EmpNo}, Name: {Name}, Basic: {Basic}, DeptNo: {DeptNo}, Net Salary: {GetNetSalary():C}";
        //}




    }
}
