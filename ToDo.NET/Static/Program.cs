namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 o1 = new Class1();
            Class1.sDisplay();
            //error-> because we cannot instatntiated a static class
           // Class2 o2 = new Class2();


        }
    }
    public class Class1
    {
        public Class1()
        { 
        
        }
        static Class1()
        { 
        }
        public int i;//non static variable
        public static int s_i;//static variable

        public void Display()
        {
            Console.WriteLine("Display");
            Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        public static void sDisplay()
        {
            Console.WriteLine("static display");
            //Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        private int prop1;
        public int Prop1
        {
            set { }
            get 
            {
                return prop1;
            }
        }

        private static int prop2;
        public static int Prop2
        {
            set { }
            get
            {
                return prop2;
            }
        }
    }

    public static class Class2
    {
        static int i;

        //non sttaic variable in static class
        //int j;


        //non static method in static class
       // public void Display1()
       // { 
        
       // }

        public static void sDisplay1()
        { 
        
        }

        //non static variavblein static class
        //public int m;
        public static int m_1;

        //non static property in static class
       // public int M
       // {
       //     set { }
         //   get 
       //     {
           //     return m;
            //}
       // }
        public static int M_I
        {
            set { }

            get
            {
                return m_1;
            }
        
        }

        public class Class3
        { 
        
        }
    
    }

    //so the error is cannont derived from class2 that means a sattic class 
    //cannot be used as a base class
   // public class Class4 : Class2
    //{ 
    
    
    //}

}
