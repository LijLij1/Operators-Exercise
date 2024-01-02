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

            var quotient = a / b;
            var remainder = a % b;
            
            Console.WriteLine($"{a}+{b}={sum}, {a}-{b}={sub}, {a}*{b}={mult}, {a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("Enter the radius of your circle");
            var userInput = Console.ReadLine();

            double radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }
        public static double AreaOfCircle(double radius)
        {
            Console.WriteLine("What is the radius of your circle?");

            var area = Math.PI * Math.Pow(radius, 2);
        }

    }
}
