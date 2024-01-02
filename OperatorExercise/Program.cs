namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;

            var sub = a - b;

            var mult = a * b;

            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}+{b}={sum}, {a}-{b}={sub}, {a}*{b}={mult}, {a}/{b} is {quotient} remainder {remainder}");
        }
    }
}
