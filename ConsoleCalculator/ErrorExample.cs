namespace ConsoleCalculator
{
    public static class ErrorExample
    {
        // an exception is any error or unexpected behaviour that's encountered by a program

        // errors can happen due to bugs in the code, network problems or hardware failures

        // exception handling lets us handle errors in a structured way
          // stop the program from crashing
          // retry the operation(eg.make another HTTP request)
          // provide a meaningful message to the user
          // log the error

        // type of the exception class represents the type of issue that occurred
        // all exceptions ultimately inherit from the base System.Exception class
        // see: https://docs.microsoft.com/en-us/dotnet/api/system.exception?view=net-6.0#choosing-standard-exceptions

        // if we run the test we can see that the excpetion class has a message and stack trace property
          // message describes the reason for the exception
          // stack trace shows where the exception was thrown and what led to it

        public static void ReadFromFile()
        {
            try
            {
                // try to do something that might throw an error
                using StreamReader sr = File.OpenText("data.txt");
                Console.WriteLine($"The first line of this file is {sr.ReadLine()}");
            }
            catch (FileNotFoundException ex)
            {
                // catch a specific type of exception
                // only runs if an exception is thrown whilst trying to perform the operation
                Console.WriteLine($"The file was not found: '{ex}'");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"The directory was not found: '{ex}'");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"The file could not be opened: '{ex}'");
            }
            catch (Exception ex)
            {
                // least specific type of exception here, used to catch 'any other' exception
                Console.WriteLine($"The file could not be opened: '{ex}'");
            }
            
            finally
            {
                // always executed when control leaves the try block
                // runs clean up code eg. closing connection to DB / stream
            }
        }
    }
}
