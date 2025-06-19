namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 12346m, 10);
            Employee o2 = new Employee("Amol", 12346m);
            Employee o3 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);


            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);


            Console.WriteLine("Hello, World!");
        }
    }

    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private short deptNo;
        private static int counter;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }
        public int EmpNo
        {
            get { return empNo; }


        }
        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 10000 && value <= 100000)
                    basic = value;
                else
                    Console.WriteLine("Invalid Basic");

            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }
        public decimal GetNetSalary()
        {
            return Basic * 2;
        }

        public Employee( string Name = "Default", decimal Basic = 10000, short DeptNo = 1)
        {
            empNo = ++counter;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

    
    }
}
