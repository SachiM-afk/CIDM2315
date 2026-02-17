Homework4;
class Program
{
    static int FindLargest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
        static void Main()
        Console.WriteLine("The largest number is: " + largest);
    }

    static void PrintLeftTriangle(int N)
    {

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
    
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the shape (left or right): ");
        string shape = Console.ReadLine().ToLower(); 

        if (shape == "left")
        {

            Console.WriteLine($"N is = {N}, Shape is = {shape}");

            PrintLeftTriangle(N);
        }
        else
        {
            Console.WriteLine("error.");
        }
    }

