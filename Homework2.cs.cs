namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a letter grade: ");
        string grade = Console.ReadLine().ToUpper(); 

        if (grade == "A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (grade == "B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (grade == "C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (grade == "D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (grade == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
    }

    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Input first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please Input  second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please Input third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallest = Math.Min(num1, Math.Min(num2, num3));
    
        Console.WriteLine($"The smallest value is : {smallest}");
    }
}
}
