using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacter
    {
        // need to add project reference in order to reference PlayerCharacter

        [Fact]
        public void PlayerCharacter_ShouldCalculateFullName()
        {
            GameEngine.PlayerCharacter sut = new GameEngine.PlayerCharacter();

            sut.FirstName = "Sarah";
            sut.LastName = "Smith";

            Assert.Equal("Sarah Smith", sut.FullName);

            // these aren't very good tests, but are here as example of different asserts
            Assert.StartsWith("Sarah", sut.FullName);
            Assert.StartsWith("SARAH", sut.FullName, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Smith", sut.FullName);
            Assert.Contains("h S", sut.FullName);
        }
    }
}