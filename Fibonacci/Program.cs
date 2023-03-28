using FibonacciTest;

namespace FibbonacciTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Console.WriteLine("Digite uma posição");

            string input = Console.ReadLine() ?? "";
            int position = int.Parse(input);

            int result = fibonacci.FibonacciFunc(position);

            Console.WriteLine(result);
        }


    }
}
