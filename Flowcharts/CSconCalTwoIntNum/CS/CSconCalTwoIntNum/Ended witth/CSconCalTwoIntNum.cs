using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, m, a;
        string cmd, more;
        bool goodtogo, doitagain;
        
        doitagain = true;
        while (doitagain == true)
        {
            Console.WriteLine("Enter n value");
            n = (int)readValue();
            Console.WriteLine("Enter m value");
            m = (int)readValue();
            goodtogo = false;
            while (goodtogo == false)
            {
                Console.WriteLine("Enter command");
                cmd = Console.ReadLine();
                if (cmd == "add")
                {
                    a = n + m;
                    Console.WriteLine("The answer is: " + a.ToString());
                    goodtogo = true;
                }
                if (cmd == "sub")
                {
                    a = n - m;
                    Console.WriteLine("The answer is: " + a.ToString());
                    goodtogo = true;
                }
                if (cmd == "mul")
                {
                    a = m * n;
                    Console.WriteLine("The answer is: " + a.ToString());
                    goodtogo = true;
                }
                if (goodtogo == false)
                {
                    Console.WriteLine("Bad command");
                }
            }
            
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
    
    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
