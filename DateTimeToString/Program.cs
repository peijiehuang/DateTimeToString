namespace DateTimeToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss"));
            Console.ReadKey();
        }
    }
}
