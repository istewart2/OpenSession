using System;
using System.IO;

namespace ErrorHandling
{
    public class ErrorExample
    {
        // errors can happen due to bugs in the code, network problems or hardware failures
        // exception handling lets us handle errors in a structured way
            // stop the program from crashing
            // retry the operation(eg.make another HTTP request)
            // provide a meaningful message to the user
            // log the error

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
