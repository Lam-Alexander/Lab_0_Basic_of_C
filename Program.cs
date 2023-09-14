using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("\n______Task 1______\n");

            //Task1();

            //Console.WriteLine("\n______Task 2______\n");

            //Task2();

            //Console.WriteLine("\n______Task 3______\n");

            //Task3();

            Console.WriteLine("\n______Additional Task______\n");

            AdditionalTask();

        }

        static void Task1()
        {
            Console.WriteLine("Enter a low number: ");
            int low_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your chosen low number is: " + low_number);


            Console.WriteLine("\n Enter a high number: ");
            int high_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your chosen high number is: " + high_number);

            Console.WriteLine($"\nThe difference between: {low_number} and {high_number} is " + (high_number - low_number));
        }


        static void Task2()
        {
            Console.WriteLine("Enter a low number: ");
            int low_number = Convert.ToInt32(Console.ReadLine());

            while (low_number < 0)

            {
                Console.WriteLine("Enter a low number: ");
                low_number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your chosen low number is: " + low_number);

            Console.WriteLine("\nEnter a high number: ");
            int high_number = Convert.ToInt32(Console.ReadLine());

            while (high_number < low_number)
            {
                Console.WriteLine("\n Enter a high number: ");
                high_number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your chosen high number is: " + high_number);
            Console.WriteLine("\nThe difference is: " + (high_number - low_number));
        }


        static void Task3()
        {
            Console.WriteLine("Enter a low number: ");
            int low_number = Convert.ToInt32(Console.ReadLine());

            while (low_number <= 0)
            {
                Console.WriteLine("Enter a low number: ");
                low_number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your chosen low number is: " + low_number);

            Console.WriteLine("\nEnter a high number: ");
            int high_number = Convert.ToInt32(Console.ReadLine());

            while (high_number < low_number)
            {
                Console.WriteLine("\n Enter a high number: ");
                high_number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your chosen high number is: " + high_number);
            Console.WriteLine("\nThe difference is: " + (high_number - low_number));

            // This creates an array that will hold all numbers between high to low
            int[] array = new int[high_number - low_number + 1];

            // This is a for lop that will itterate through the array starting at postion 0 until i is less than the lenght of the array
            for (int i = 0; i < array.Length; i++)
            {
                // This will assign a value to a specific index within the array adding 1 each time due to i
                array[i] = low_number + i;
            }

            string filePath = @"C:\Users\LamAl\Desktop\numbers.txt";

            using (StreamWriter WriteToFile = new StreamWriter(filePath))
            {
                Array.Reverse(array);
                foreach (int num in array)
                {
                    WriteToFile.Write(num + " ");
                }
            }
        }


       static void AdditionalTask()
        {
            Console.WriteLine("Enter a low number: ");
            int low_number = Convert.ToInt32(Console.ReadLine());

            while (low_number <= 0)
            {
                Console.WriteLine("Enter a low number: ");
                low_number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your chosen low number is: " + low_number);

            Console.WriteLine("\nEnter a high number: ");
            int high_number = Convert.ToInt32(Console.ReadLine());

            while (high_number < low_number)
            {
                Console.WriteLine("\n Enter a high number: ");
                high_number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Your chosen high number is: " + high_number);
            Console.WriteLine($"\nThe difference is between {high_number} and {low_number} is: " + (high_number - low_number));

            List<int> list = new List<int> {};

            for (int i = 0; i <= high_number - low_number; i++)
            {
                list.Add(low_number + i);
            }

            string filePath = @"C:\Users\LamAl\Desktop\numbers.txt";

            using (StreamWriter WriteToFile = new StreamWriter(filePath))
            {
                list.Reverse();
                foreach (int num in list)
                {
                    WriteToFile.Write(num + " ");
                }
            }

            using (StreamReader ReadFromFile = new StreamReader(filePath))
            {
                Console.WriteLine($"\nEvery number between {low_number} and {high_number} in order of largest to smallest is ");
                Console.WriteLine(ReadFromFile.ReadToEnd());
            }

            Console.ReadKey();

        }
        

    }
}
