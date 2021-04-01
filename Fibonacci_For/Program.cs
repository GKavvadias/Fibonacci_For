using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, F0 = 0, F1 = 1, F;
            Console.Write("Παρακαλώ δώστε έναν αριθμό: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                F = F0 + F1;
                Console.WriteLine(F);
                F0 = F1;
                F1 = F;
            }
        }
    }
}
