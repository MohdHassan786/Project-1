using System.IO;
 using System;


namespace Project_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\HASSAN\\Documents\\student_data.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Display the student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Student data file not found!");
            }

            Console.ReadLine();
        }
    }
}
    
