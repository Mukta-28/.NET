namespace Assignment3._2
{
    using System;

    class Program
    {
        static void Main()
        {
            // Step 1: Accept number of batches
            Console.Write("Enter number of batches: ");
            int batchCount = Convert.ToInt32(Console.ReadLine());

            // Step 2: Create jagged array (array of arrays)
            int[][] allMarks = new int[batchCount][];

            // Step 3: For each batch, accept number of students and their marks
            for (int i = 0; i < batchCount; i++)
            {
                Console.Write($"Enter number of students in batch {i + 1}: ");
                int studentCount = Convert.ToInt32(Console.ReadLine());

                allMarks[i] = new int[studentCount]; // create array for this batch

                for (int j = 0; j < studentCount; j++)
                {
                    Console.Write($"Enter marks of student {j + 1} in batch {i + 1}: ");
                    allMarks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Step 4: Display all marks
            Console.WriteLine("\n----- Displaying All Marks -----");
            for (int i = 0; i < batchCount; i++)
            {
                Console.WriteLine($"Batch {i + 1} marks:");
                for (int j = 0; j < allMarks[i].Length; j++)
                {
                    Console.WriteLine($"Student {j + 1}: {allMarks[i][j]}");
                }
                Console.WriteLine(); // extra line after each batch
            }
        }
    }

}
