namespace ThreadingExamples2
{
    internal class Program
    {
        static void Main2()
        {
            //ThradStart--- return type void and no parameter
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            //t1.Start("passed value");
            //t1.Start(1234);
            //t1.Start(true);

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            t1.Start(list);

            //create array
            //t1.Start(arr);
           // int[] arr = new int[] { }


        }
        //
        static void Func1(object obj)
        {
            List<int> list = (List<int>)obj;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i+ obj);
            }
        }
    }
}

namespace ThreadingExamples3
{
    internal class Program
    {
        static void Main()
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            //t1.Start("passed value");
            //t1.Start(12345);
            //t1.Start(true);

            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);


            //t1.Start(list);

            //create array -arr
            //t1.Start(arr);

            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //t1.Start(arr);

            Class1 objclass = new Class1() { Id = 101, Name = "Mukta" };
            t1.Start(objclass);

        }
        //1. pass a collection /array
        //2. pass obj of class/struct
        //3. dont pass, use anon methods

        static void Func1(object obj)
        {

            //List<int> list = (List<int>)obj;
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = (int[])obj;
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Class1 objclass = (Class1)obj;

            Console.WriteLine(objclass.Name);
            Console.WriteLine(objclass.Id);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("First : " + i + obj);
            }
        }
        class Class1
        { 
          public int Id { get; set; }
          public string Name { get; set; }
        }
    }
}