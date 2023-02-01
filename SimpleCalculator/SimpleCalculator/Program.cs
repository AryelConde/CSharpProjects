
using System.Globalization;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            String input1 = Console.ReadLine();
            float num1 = float.Parse(input1);

            Console.Write("Input the second number: ");
            String input2 = Console.ReadLine();
            float num2 = float.Parse(input2);

            Console.Write("Input the third number: ");
            String input3 = Console.ReadLine();
            float num3 = float.Parse(input3);



            Console.WriteLine("\nThe results are: ");
            float addTotal = num1 + num2 + num3;
            float multTotal = num1 * num2 * num3;
            Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " = " + addTotal);
            Console.WriteLine(num1 + " x " + num2 + " x " + num3 + " = " + multTotal);
        }
    }
}
