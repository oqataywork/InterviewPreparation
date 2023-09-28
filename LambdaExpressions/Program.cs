namespace LambdaExpressions
{
    public class Program
    {
        public delegate bool CompareDelegate(string a, string b);
        
        public delegate string StrDelegate (string s, int x);

        static void Main(string[] args)
        {
            CompareDelegate cD = (x, y) => x.Equals(y);
            bool result = cD("hello", "hello");
            Console.WriteLine(result.ToString());


            StrDelegate strDelegate = (string str, int a) => str + Convert.ToString(a);
            Console.WriteLine(strDelegate("abc", 123));


            Console.ReadKey();
        }
    }
}