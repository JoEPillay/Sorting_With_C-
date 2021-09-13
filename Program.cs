using System;
using System.Collections.Generic;

namespace Sorting_With_C_
{
    public static class Program
    {
        public static string[] input = new string[6];
        static void Main(string[] args)
        {
            intro();

        }

        private static void intro()
        {
            Console.WriteLine("Welcome\nEnter 6 random numbers");
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.Clear();
            Console.Write("Your Array:");
            foreach (var item in input)
            {
                Console.Write(" " + item);

            }
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.WriteLine("Lets Sort this Array!\nYour options are as follows");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine("3. Selection Sort");
            Console.WriteLine("Enter the number of prefered sort");
            string userinput;
            userinput = Console.ReadLine();
            if (userinput == "3")
            {
                SelectionSort();
            }
            else if (userinput == "2")
            {
                InsertionSort();
            }
            else if (userinput == "1")
            {

            }
        }

        public static void SelectionSort()
        {
            for (var i = 0; i < input.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (int.Parse(input[min]) > int.Parse(input[j]))
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
            Console.Write("Your New Sorted Array:");
            foreach (var item in input)
            {
                Console.Write(" " + item);

            }
            Console.WriteLine(" ");

        }
        public static void InsertionSort()
        {

            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && int.Parse(input[currentIndex - 1]) > int.Parse(item))
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
            Console.Write("Your New Sorted Array:");
            foreach (var item in input)
            {
                Console.Write(" " + item);
                
            }
            Console.WriteLine(" ");

        }
        public static void BubbleSort()
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (int.Parse(input[i]) > int.Parse(input[i + 1]))
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);

             Console.Write("Your New Sorted Array:");
            foreach (var item in input)
            {
                Console.Write(" " + item);

            }
             Console.WriteLine(" ");
            
        }



    }
}
