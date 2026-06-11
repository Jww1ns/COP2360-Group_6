using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: "); 
        string input1 = Console.ReadLine(); 

        Console.WriteLine("Please enter the second number: "); 
        string input2 = Console.ReadLine();

        DivideStrings(input1, input2);
    }

    static void DivideStrings(string str1, string str2)
    {
        try
        {
            int num1 = Convert.ToInt32(str1);
            int num2 = Convert.ToInt32(str2);

            int answer = num1 / num2;

            Console.WriteLine($"The answer is: {answer}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: the second input was zero, and you cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: one or more of the inputs aren't integers, and so the division cannot be completed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: one or more of the inputs is too large or small to be stored as an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: an unexpected error occurred.");
        }
    }
}
