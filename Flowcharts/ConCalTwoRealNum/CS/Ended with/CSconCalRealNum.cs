using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double num1, num2, ans;
        string more;
        bool doitagain;
        
        doitagain = true;
        while (doitagain == true)
        {
            Console.WriteLine("Enter Num1 value");
            num1 = readValue();
            Console.WriteLine("Enter Num2 value");
            num2 = readValue();
            ans = CalCommand(num1, num2);
            Console.WriteLine("The answer is " + ans);
            Console.WriteLine("Do you want to Calculate again? (yes or no)");
            more = Console.ReadLine();
            if (more == "yes")
            {
                doitagain = true;
            }
            else
            {
                doitagain = false;
            }
        }
        Console.WriteLine("The program is done");
    }
    
    public static double CalCommand(double n, double m)
    {
        double a = 0;
        string cmd;
        bool goodtogo;
        
        goodtogo = false;
        while (goodtogo == false)
        {
            Console.WriteLine("Enter command");
            cmd = Console.ReadLine();
            if (cmd == "add")
            {
                a = n + m;
                goodtogo = true;
            }
            if (cmd == "sub")
            {
                a = n - m;
                goodtogo = true;
            }
            if (cmd == "mul")
            {
                a = n * m;
                goodtogo = true;
            }
            if (cmd == "div")
            {
                a = n / m;
                goodtogo = true;
            }
            if (goodtogo == false)
            {
                Console.WriteLine("Bad command");
            }
        }
        
        return a;
    }
    
    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
