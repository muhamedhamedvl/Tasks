using System.Text;

namespace Task2
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

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                sb.Append(i);
                if (i != n) sb.Append(", ");
            }

            Console.WriteLine("Output:");
            Console.WriteLine(sb.ToString());
        }
    }
}
