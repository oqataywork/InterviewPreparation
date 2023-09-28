namespace Delegates1
{

    public delegate int AddDelegate(int a, int b);

    class Mathematics
    {
        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            AddDelegate add = new AddDelegate(m.Add);


            int res = add.Invoke(5, 6);

            //you can do how you want
            int altRes = add(7, 2);
            Console.WriteLine(res);
            Console.WriteLine(altRes);
        }
    }
}