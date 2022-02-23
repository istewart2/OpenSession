using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacter
    {
        // by default XUnit will create a new instance of the test class before executing each test
        // to reduce code duplication of the arrange phase, we can extract common setup into constructor
        [Fact]
        public void PlayerCharacter_ShouldCalculateFullName()
        {
            var sut = new GameEngine.PlayerCharacter();
            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Equal("Sarah Smith", sut.FullName);

            // these aren't very good tests, but are here as example of different asserts
            Assert.StartsWith("Sarah", sut.FullName);
            Assert.StartsWith("SARAH", sut.FullName, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Smith", sut.FullName);
            Assert.Contains("h S", sut.FullName);
        }

        [Fact]
        public void PlayerCharacter_ShouldStartAt100Health()
        {
            var sut = new GameEngine.PlayerCharacter();

            var result = sut.Health;

            Assert.Equal(100, result);
        }
    }
}