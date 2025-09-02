using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public static class MathHelper
{
    // Static method to calculate average of integers
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}


class Program
{
    static void Main3()
    {
        int[] values = { 10, 20, 30, 40, 50 };
        double average = MathHelper.CalculateAverage(values);
        Console.WriteLine("Average: " + average);
    }
}

