namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            if (operation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                // program doesn't crash if we enter '+' but would be better if we throw an exception
                // we don't want this exception to 'bubble up' to the operating system, so should catch it
                throw new ArgumentOutOfRangeException(nameof(operation), "The operator provided is not supported");
                
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}