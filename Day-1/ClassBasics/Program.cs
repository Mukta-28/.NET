//using System;//crrent file
global using System;
using System.Data;//entire project//alternative to sol expl->prop->enable implicite global using
namespace ClassBasics
{
    internal class Program
    {
        static void Main1()
        {
            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("H W");
            System.Console.WriteLine("A A");
             
        }
        static void Main()
        {

            Class1 obj; //obj is refrence of type Class1

            obj = new Class1();
            //Class1 o2= new Class1();
            obj.Display();
            obj.Display("abc");

            //positional parameters
            Console.WriteLine(obj.Add(10, 20, 30));
            Console.WriteLine(obj.Add(10, 20));
            Console.WriteLine(obj.Add(10));
            Console.WriteLine(obj.Add());

            //named parameters
            Console.WriteLine(obj.Add(a: 10, b: 20, c: 30));
            Console.WriteLine(obj.Add(c: 30, a: 10, b: 20));
            Console.WriteLine(obj.Add(c: 30));
            Console.WriteLine(obj.Add(a: 10, c: 30));

            // Console.WriteLine(obj.Add(10, c:30));
            obj.DoSomething1();


        }
    }

    public class Class1 // by default it inherited from : Object 
    { 
        public void Display() 
        {
            System.Console.WriteLine("Display called");
        }
        //overload
        public void Display(string s)
        {
            System.Console.WriteLine("Display called: "+ s);
        }
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Add(int a, int b,int c)
        //{
        //    return a + b +c;
        //}
        //default values are given from right to left 
        public int Add(int a=0, int b=0 , int c=0)
        {
            return a + b + c;
        }
        
        public void DoSomething1()
        {
            int i=100; // local variable is a variable declare in a function
            //local variable are unassigned
            Console.WriteLine(i);
            DoSomething2();
            Console.WriteLine(i);
            //local function - function defined within another function
            //only available from the outer function
            //implicitly private
            //cannot overload a local function
            void DoSomething2()
            {
                //local function can access local variables declared in the outer functions
                Console.WriteLine(++i);
            }

            static void DoSomething3()
            {
                //local function can access local variables declared in the outer functions
               // Console.WriteLine(++i);//error 
            }

        }
        
    }
}
namespace Payroll
{
   
     public class Employee { }
     public class Manager { }
     public class Department { }


}
namespace Cricket
{
      public class Player { }
      public class Manager { }
}
namespace n1 
{
    namespace n2
    {
       public class Employee { }

    }
}