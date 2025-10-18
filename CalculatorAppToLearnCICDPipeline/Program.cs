namespace CalculatorAppToLearnCICDPipeline
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 7));
        }
    }
}
