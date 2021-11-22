using System;

namespace Tema2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length && i < 4; i++)
            {
                sum = sum + ints[i];
            }

            return sum;
        }

        static void RemoveEmpty(string text, out string result)
        {
            result = text.Replace(" ", "");
        }

        static string Statistics(int nota)
        {
            switch (nota)
            {
                case int n when n < 5 && n > 0:
                    return "very bad grade!";
                case int n when n == 5 || n == 6:
                    return "bad grade!";
                case 7:
                    return "acceptable grade!";
                case 8:
                    return "good grade!";
                case 9:
                    return "very good grade!";
                case 10:
                    return "excellent grade!";
                default:
                    return "invalid notation";
            }
        }

        public static void Main(string[] args)
        {
            string x = "string x";
            string y = "string y";
            Swap(ref x, ref y);
            Console.WriteLine($"String x: {x}\t String y: {y}");
            Console.WriteLine("Sum:");
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 4));
            Console.WriteLine(Sum(1, 2, 3, 4, 5));

            Console.WriteLine("Remove empty space:");
            string test = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", result;
            RemoveEmpty(test, out result);
            Console.WriteLine($"Initial string: {test}");
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("nota 10-> " + Statistics(10));
            Console.WriteLine("nota 1-> " + Statistics(1));
            Console.WriteLine("nota 1-> " + Statistics(0));

            Console.WriteLine("Optional exercise:");
            try
            {
                string lines = System.IO.File.ReadAllText(@".\file.txt");
                Console.WriteLine("\n All text from file: ");
                Console.WriteLine(lines);
                string[] words = lines.Split(" ");
                Console.WriteLine($"Number of words: {words.Length}");
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}