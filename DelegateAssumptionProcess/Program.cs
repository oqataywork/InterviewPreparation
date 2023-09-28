namespace DelegateAssumptionProcess
{


    public class Program
    {
        public delegate int StrDelegate(string s);
        static void Main(string[] args)
        {
            StrDelegate sD = delegate (string str)
            {
                if (str == null)
                {
                    throw new Exception("Строка отсутствует");
                }
                return str.Length;
            };
            Console.WriteLine(sD("Habibi"));
        }
    }
}