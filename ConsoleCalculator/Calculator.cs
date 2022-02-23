namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            if (operation is null)
            { 
                throw new ArgumentNullException(nameof(operation));
            }

            if (operation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"The value cannot be divided by zero: {ex}");
                    // log the error
                    // re-throw excpetion to be caught further up the chain 
                    // do not use 'throw ex' because you will lose stack trace
                    throw;
                }
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