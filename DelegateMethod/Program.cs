namespace DelegateMethod
{

    public delegate string HelloDelegate(string name);
    public delegate DateTime TimeNow();

    class SomeClass
    {
        private DateTime GetTime()
        {
            return DateTime.Now;
        }

        public string SayHello (string s)
        {
            TimeNow timeNow = new TimeNow(GetTime);
            var res = timeNow();
            return $"Hello, {s}.\nCurrent time is: {res}";
            
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            HelloDelegate helloDelegate = new HelloDelegate(someClass.SayHello);
            Console.WriteLine(helloDelegate("Vladimir"));
            Console.ReadKey();
        }
    }
}