namespace FizzBuzz;

public class FizzBuzzClass
{
    public string Run(int divider)
    {
        if(divider % 3 == 0 && divider % 5 == 0)
        {
            return "fizzbuzz";
        }
        else if(divider % 5 == 0)
        {
            return "buzz";
        }
        else if(divider % 3 == 0)
        {
            return "fizz";
        }
        else
        {
            return "Not fizzy or buzzy.";
        }
    }
    public static int NumParse()
    {
        var inputSuccess = int.TryParse(Console.ReadLine(), out int parseSucceed);
        while (!inputSuccess)
        {
            Console.WriteLine("Please enter a number.");
            inputSuccess = int.TryParse(Console.ReadLine(), out parseSucceed);
        }
        return parseSucceed;
    }
}