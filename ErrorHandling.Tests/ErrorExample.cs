using Xunit;

namespace ErrorHandling.Tests
{
    public class ErrorExample
    {
        [Fact]
        public void Test1()
        {
            // not testing anything here, just running the method
            ErrorHandling.ErrorExample.ReadFromFile();
        }
    }
}