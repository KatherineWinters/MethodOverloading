using System;

namespace Method_Overloading_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintItems(3);
            PrintItems(4, 5);
            PrintItems(6.3, 6.4);
            PrintItems(5.2m);
            PrintItems("true");
            PrintItems("friends");
            PrintItems(56.4f);
            PrintItems(804);
        }

        public static void PrintItems(int items)
        {
            Console.WriteLine(items);
        }

        public static void PrintItems(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public static void PrintItems(params double[] items)
        {
            foreach (double item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintItems(params decimal[] items)
        {
            foreach (decimal item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintItems(params bool[] items)
        {
            foreach (bool item in items)
            { 
                Console.WriteLine(item); 
            }
        }
        
        public static void PrintItems(params string[] items)
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void  PrintItems(params char[] items)
            {
            foreach (char item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintItems(params float[] items)
        {
            foreach (float item in items)
            {
                Console.WriteLine(item);
            }
        }
        
        public static void PrintItems(params long[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
       
    }
}
