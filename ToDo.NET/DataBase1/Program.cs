using Microsoft.Data.SqlClient;
using System.Data;
namespace DatabasePractice2
{
    internal class Program
    {
        static void Main()
        {
            //var single = GetSingleEmployee(3);
            //if (single != null)
            //    Console.WriteLine($"{single.EmpNo} {single.Name} {single.Basic} {single.DeptNo}");
            //else
            //    Console.WriteLine("Employee not found");

            var allEmps = GetAllEmployees();
            foreach (var e in allEmps)
                Console.WriteLine($"{e.EmpNo} {e.Name} {e.Basic} {e.DeptNo}");


        }
        static void SelectASingleValue()
        {
            SqlConnection cn = new SqlConnection();
            try {
                 cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Name from Employees where EmpNo = 1";
                //cmd.CommandText = "select count(*) from Employees";
                //cmd.CommandText = "select * from Employees";
                object retval = cmd.ExecuteScalar();
                //returns first row, first col
                Console.WriteLine(retval);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        //static Employee GetSingleEmployee(int EmpNo)
        //{
        //    Employee emp = new Employee();
        //    //read emp details from db
        //    return emp;
        //}
        static Employee GetSingleEmployee(int EmpNo)
        {
            Employee emp = null;

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employees WHERE EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp = new Employee
                    {
                        EmpNo = Convert.ToInt32(dr["EmpNo"]),
                        Name = dr["Name"].ToString(),
                        Basic = Convert.ToDecimal(dr["Basic"]),
                        DeptNo = Convert.ToInt32(dr["DeptNo"])
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }

        static List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = new List<Employee>();

            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee emp = new Employee
                    {
                        EmpNo = Convert.ToInt32(dr["EmpNo"]),
                        Name = dr["Name"].ToString(),
                        Basic = Convert.ToDecimal(dr["Basic"]),
                        DeptNo = Convert.ToInt32(dr["DeptNo"])
                    };
                    lstEmps.Add(emp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return lstEmps;
        }





    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
    }
    
}
