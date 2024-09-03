namespace MethodChainingAdvanced
{
    internal class Program
    {

        static void Main()
        {
            var number = 4;
            var result = MathOperations.Double(MathOperations.Square(MathOperations.Increment(number)));

            var resultAsExtension = number.Increment().Square().Double();

            Console.WriteLine(result);
            Console.WriteLine(resultAsExtension);
        }
    }
    static class MathOperations
    {
        public static int Double(this int x) { return x * 2; }
        public static int Square(this int x) { return x * x; }
        public static int Increment(this int x) { return x + 1; }
    }
}
