public delegate void MyDelegate();

class SomeClass
{
    public static void Method()
    {
        Console.WriteLine("Hello!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDelegate myDelegate = new MyDelegate(SomeClass.Method);
        myDelegate.Invoke();
        myDelegate();
        Console.ReadKey();
    }
}

