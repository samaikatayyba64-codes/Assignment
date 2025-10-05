//Read three numbers with double.TryParse; compute an average using double math; display with two decimals.
using System;

class Program
{
    static void Main()
    {

        double[] values = new double[3];

        for (int i = 0; i < values.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter number #{i + 1}: ");
                string? s = Console.ReadLine();

                if (double.TryParse(s, out double n))
                {
                    values[i] = n;
                    break;

                    Console.WriteLine("Invalid number. Try again.");
                }
            }

            double sum = 0;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];

            double avg = sum / values.Length;
            Console.WriteLine($"Average = {avg:F2}");
        }
    }