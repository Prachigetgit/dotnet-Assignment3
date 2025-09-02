using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public static class Logger
{
    // Static method to log a message
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}

class Program4
{
    static void Main1()
    {
        // Demonstrating Logger usage
        Logger.LogMessage("Application started.");

        int a = 10, b = 20;
        Logger.LogMessage($"Performing addition: {a} + {b}");

        int sum = a + b;
        Logger.LogMessage($"Result of addition: {sum}");

        Logger.LogMessage("Application ended.");
    }
}
