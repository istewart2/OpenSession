namespace ConsoleCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // uncomment this to see Exception being thrown
            // ErrorExample.ReadFromFile();

            #region Get User Input

            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine().ToUpper();

            #endregion

            #region Setup Calculator

            var calculator = new Calculator();
            int result = calculator.Calculate(number1, number2, operation);
            DisplayResult(result);

            #endregion

            #region Exit

            Console.WriteLine("\nPress enter to exit.");
            Console.ReadLine();

            #endregion
        }

        private static void DisplayResult(int result) => Console.WriteLine($"Result is: {result}");
    }
}