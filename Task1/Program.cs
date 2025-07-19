using System.Diagnostics;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. n must be a positive integer.");
                return;
            }

            // Sum using for loop
            Stopwatch swFor = Stopwatch.StartNew();

            long sumFor = 0;
            for (int i = 1; i <= n; i++)
            {
                sumFor += i;
            }

            swFor.Stop();
            Console.WriteLine($"Sum using for loop = {sumFor}");
            Console.WriteLine($"Time taken (for loop) = {swFor.Elapsed.TotalMilliseconds} ms");

            // Sum using formula
            Stopwatch swFormula = Stopwatch.StartNew();

            long sumFormula = (long)n * (n + 1) / 2;

            swFormula.Stop();
            Console.WriteLine($"\nSum using formula = {sumFormula}");
            Console.WriteLine($"Time taken (formula) = {swFormula.Elapsed.TotalMilliseconds} ms");
        }
    }
}
