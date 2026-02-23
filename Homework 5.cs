
namespace Homework5;

class Program
{
    //Q1_methdd()
    static int LargestNumber(int num1, int num2)
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

    // Q2_method ()
    static int GetLargestNumber(int num1, int num2, int num3, int num4)
    {
        int largest = LargestNumber(num1, num2);
        largest = LargestNumber(largest, num3);
        largest = LargestNumber(largest, num4);
        return largest;
    }

    // Q3_method ()
    static bool checkAge(int birth_year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        Console.Write("Confirm password: ");
        string confirmPassword = Console.ReadLine();

        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully!");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

    static void Main()
    {
         // Q1_method
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int largest = LargestNumber(num1, num2);
        Console.WriteLine("The largest number is: " + largest);

        // Q2_method
        Console.Write("Enter the first integer: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third integer: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Enter the fourth integer: ");
        int num4 = int.Parse(Console.ReadLine());

        int largestOfFour = GetLargestNumber(num1, num2, num3, num4);
        Console.WriteLine("The largest number is: " + largestOfFour);

        // Q3_method
        createAccount();
    }
}
