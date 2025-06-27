
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataBasePractice1
{
    internal class Program
    {
        static void Main()
        {
            //Connect();
            // Employee obj = new Employee { EmpNo = 6, Name = " lucky", DeptNo = 20, Basic = 50000 };
            //  Employee obj = new Employee { EmpNo = 6, Name = "The lucky", DeptNo = 20, Basic = 50000 };
            // Employee obj = new Employee { EmpNo = 6, Name = "The lucky", DeptNo = 20, Basic = 50000 };
            //InsertWithParameters(obj);
            //InsertWithSP(obj);
            //UpdateWithParameters(obj);
            // DeleteWithParameters(6);
            //Employee obj = new Employee { EmpNo = 5, Name = "The lucky tiger", DeptNo = 20, Basic = 50000 };
            // UpdateWithSP(obj);
            DeleteWithSP(5);
            
           
        }
        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                cn.Open();
                Console.WriteLine("Db Connection successfully conect");
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
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }
        }
        static void InsertWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                cn.Open();
                Console.WriteLine("Db Connection successfully conect");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("successfully insert");
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
        static void UpdateWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                cn.Open();
                Console.WriteLine("Db Connection successfully conect");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Employees set Name =@Name, Basic = @Basic, DeptNo=@DeptNo where EmpNo=@EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("successfully update");
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
            static void DeleteWithParameters(int empNo)
            {
                SqlConnection cn = new SqlConnection();
                try
                {
                    cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                    cn.Open();
                    Console.WriteLine("Db Connection successfully conect");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from Employees where EmpNo=@EmpNo";

                    cmd.Parameters.AddWithValue("@EmpNo", empNo);
                    //cmd.Parameters.AddWithValue("@Name", obj.Name);
                    //cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                    //cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                    cmd.ExecuteNonQuery();

                    Console.WriteLine("successfully delete");
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
        static void InsertWithSP(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True";

                cn.Open();

                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("success");
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
        static void UpdateWithSP(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True";

                cn.Open();

                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateEmployee";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("successfully updated with sp");
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
        static void DeleteWithSP(int empNo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JKJune25;Integrated Security=True";

                cn.Open();

                // SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteEmployee";

                cmd.Parameters.AddWithValue("@EmpNo", empNo);
                //cmd.Parameters.AddWithValue("@Name", obj.Name);
                //cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                //cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                cmd.ExecuteNonQuery();

                Console.WriteLine("successfully deleted with sp");
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
    }
}
