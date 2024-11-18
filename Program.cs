using System.ComponentModel;
using System.Text;

namespace Assignments3_1_1
{
    internal class Program
    {
        // Return even numbers. Write a method that returns a string of even numbers greater than 0 and less than 100.
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnByTwosEvens(100));
            Console.WriteLine(ReturnByModuloEvens(100));
        }

        // Prints Even numbers to the console (Should be faster than using Modulo)
        static string ReturnByTwosEvens(int numAmount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < numAmount; i++)
            {
                sb.Append(i);
                sb.Append(' ');
                i++;
            }
            return sb.ToString();
        }

        // Prints Even numbers using Modulo
        static string ReturnByModuloEvens(int numAmount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < numAmount; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(i);
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }
    }
}
