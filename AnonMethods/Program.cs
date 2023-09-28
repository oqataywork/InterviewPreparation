namespace AnonMethods
{

    public delegate int AddDelegate(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            AddDelegate mD = new AddDelegate(delegate (int num1, int num2) { return num1 + num2; });
            Console.WriteLine(mD.Invoke(5, 7));
             // md();
            Console.ReadKey();
        }
    }
}