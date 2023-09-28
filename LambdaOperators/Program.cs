namespace LambdaStatements
{



    public delegate int SubDelegate(int a, int  b);


    internal class Program
    {
        static void Main(string[] args)
        {
            int c = new SubDelegate((s, d) =>
            {
                int res = s - d;
                return res;
            }).Invoke(9,6);
            Console.WriteLine(c);
        }
    }
}