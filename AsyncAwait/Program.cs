namespace AsyncAwait
{
    internal class Program
    {
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i < 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);
            Console.WriteLine($"Факториал равен: {result}");
        }

        static async void FactorialAsync()
        {
            Console.Out.WriteLine("Start of FactorialAsync method");
            await Task.Run(() => Factorial());
            Console.WriteLine("End of FactorialAsync method");
        }

        static void Main(string[] args)
        {
            FactorialAsync();
            Console.WriteLine("Enter the number");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен: {n * n}");

            Console.Read();

        }
    }
}