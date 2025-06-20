using System.Diagnostics;
using System.Xml.Linq;

namespace Assignment_3._1
{

    public interface IDbFunctions
    {
        public void Insert();
        public void Update();
        public void Delete();

    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");
        }
    }
    //    public abstract class Employee : IDbFunctions
    //    {
    //        private static int autoEmpNo = 1;
    //        public readonly int EmpNo;


    //        private string name;
    //        public string Name
    //        {
    //            get
    //            {
    //                return name;
    //            }
    //            set 
    //            {

    //                if (value != "")
    //                    name = value;
    //                else
    //                    Console.WriteLine("Invalid Name");
    //            }
    //        }
    //        private short deptNo;
    //        public short DeptNo
    //        {
    //                get { return deptNo; }
    //                set
    //                {
    //                    if (value > 0)
    //                        deptNo = value;
    //                    else
    //                        Console.WriteLine("Invalid EmpNo");
    //                }
    //            }

    //        public Employee(string name, short deptNo)
    //        {
    //            EmpNo = autoEmpNo++;
    //            this.Name = Name;
    //            this.DeptNo = DeptNo;
    //        }
    //        public abstract decimal Basic { get; set; }

    //        public abstract decimal CalcNetSalary();

    //        public abstract void Insert();
    //        public abstract void Update();
    //        public abstract void Delete();

    //        }

    //    public class Manager : Employee
    //    { 
    //       public string Designation { get; set; }

    //        private decimal basic;
    //        public decimal Basic
    //        {
    //            get { return basic; }
    //            set
    //            {
    //                if (value < 10000 || value > 100000)
    //                    Console.WriteLine("Invalid Basic");
    //                else
    //                    basic = value;

    //            }
    //        }
    //        public Manager(string name, short deptNo, string designation, decimal basic)
    //            : base(name, deptNo)
    //        {
    //            if (designation != "")

    //                Console.WriteLine("invalid designation");

    //            else
    //                Designation = designation;
    //            Basic = basic;


    //        }

    //        public override decimal CalcNetSalary()
    //        {
    //            return basic + 10000;
    //        }

    //        public override void Insert()
    //        {
    //            Console.WriteLine("Insert");

    //        }
    //        public override void Update()
    //        {
    //            Console.WriteLine("Update");

    //        }
    //        public override void Delete()
    //        {
    //            Console.WriteLine("Delete");

    //        }
    //    }
    //    public class GeneralManager : Manager
    //    { 
    //       public string Perks { get; set; }

    //        public GeneralManager(string name, short deptNo, string designation, decimal basic, string perks)
    //       : base(name, deptNo, designation, basic)
    //        {
    //            Perks = perks;
    //        }

    //        public override decimal Basic
    //        {
    //            get { return base.Basic; }
    //            set
    //            {
    //                if (value < 100000 || value > 1000000)
    //                    Console.WriteLine("Invalid Basic");
    //                else
    //                    base.Basic = value;
    //            }
    //        }
    //    }


    //    }



    public abstract class Employee : IDbFunctions
    {
        private static int autoEmpNo = 1;
        public readonly int EmpNo;

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }

        private short deptNo;
        public short DeptNo
        {
            get => deptNo;
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid DeptNo");
            }
        }

        public Employee(string name, short deptNo)
        {
            EmpNo = autoEmpNo++;
            this.Name = name;
            this.DeptNo = deptNo;
        }

        public abstract decimal Basic { get; set; }

        public abstract decimal CalcNetSalary();
        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
    }

    public class Manager : Employee
    {
        public string Designation { get; set; }

        private decimal basic;
        public override decimal Basic
        {
            get => basic;
            set
            {
                if (value < 10000 || value > 100000)
                    Console.WriteLine("Invalid Basic");
                else
                    basic = value;
            }
        }

        public Manager(string name, short deptNo, string designation, decimal basic)
            : base(name, deptNo)
        {
            if (string.IsNullOrWhiteSpace(designation))
                Console.WriteLine("Invalid Designation");
            else
                Designation = designation;

            Basic = basic;
        }

        public override decimal CalcNetSalary() => Basic + 10000;
        public override void Insert() => Console.WriteLine("Insert");
        public override void Update() => Console.WriteLine("Update");
        public override void Delete() => Console.WriteLine("Delete");
    }

    public class GeneralManager : Manager
    {
        public string Perks { get; set; }

        public GeneralManager(string name, short deptNo, string designation, decimal basic, string perks)
            : base(name, deptNo, designation, basic)
        {
            Perks = perks;
        }

        public override decimal Basic
        {
            get => base.Basic;
            set
            {
                if (value < 100000 || value > 1000000)
                    Console.WriteLine("Invalid Basic");
                else
                    base.Basic = value;
            }
        }
        public override decimal CalcNetSalary() => Basic + 20000;

        public override void Insert() => Console.WriteLine("General Manager Inserted");
        public override void Update() => Console.WriteLine("General Manager Updated");
        public override void Delete() => Console.WriteLine("General Manager Deleted");

    }
    public class CEO : Employee
    {
        private decimal basic;
        public override decimal Basic
        {
            get => basic;
            set
            {
                if (value < 200000)
                    Console.WriteLine("Invalid Basic for CEO");
                else
                    basic = value;
            }
        }

        public CEO(string name, short deptNo, decimal basic)
            : base(name, deptNo)
        {
            Basic = basic;
        }

        public sealed override decimal CalcNetSalary() => Basic + 50000;

        public override void Insert() => Console.WriteLine("CEO Inserted");
        public override void Update() => Console.WriteLine("CEO Updated");
        public override void Delete() => Console.WriteLine("CEO Deleted");
    }

}
