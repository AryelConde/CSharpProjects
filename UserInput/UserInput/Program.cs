namespace UserInput
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Please enter the following data: ");
            Console.Write("Name: ");
            String input = Console.ReadLine();
            Console.Write("Student number: ");
            string input2 = Console.ReadLine();
            Console.Write("Email: ");
            String input3 = Console.ReadLine();

            Console.WriteLine("\nYour contact data is: ");
            Console.WriteLine("Your name is: "+input);
            Console.WriteLine("Your student number is: " + input2);
            Console.WriteLine("Your email is: " + input3);
        }
    }
}
