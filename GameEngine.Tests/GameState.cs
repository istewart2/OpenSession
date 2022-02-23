using Xunit;

namespace GameEngine.Tests
{
    public class GameState : IClassFixture<GameStateFixture>
    {
        private readonly GameStateFixture gameStateFixture;

        // use ctor to create constuctor, use helper to create and assign 
        // creates a new instance when the first test runs and disposes of it
        // after all tests have executed (for a single test class)
        // need to be careful that the actions performed on the shared instance don’t have side effects and break other tests
        // tests should be able to execute in any order without impacting each other

        public GameState(GameStateFixture gameStateFixture)
        {
            this.gameStateFixture = gameStateFixture;
        }

        [Fact]
        public void DamageAllPlayersWhenEarthquake()
        {
            var sut = gameStateFixture.State;

            var player1 = new GameEngine.PlayerCharacter();
            var player2 = new GameEngine.PlayerCharacter();

            sut.Players.Add(player1);
            sut.Players.Add(player2);

            var expectedHealthAfterEarthquake = player1.Health - GameEngine.GameState.EarthquakeDamage;

            sut.Earthquake();

            Assert.Equal(expectedHealthAfterEarthquake, player1.Health);
            Assert.Equal(expectedHealthAfterEarthquake, player2.Health);
        }

        [Fact]
        public void Reset()
        {
            var sut = gameStateFixture.State;

            var player1 = new GameEngine.PlayerCharacter();
            var player2 = new GameEngine.PlayerCharacter();

            sut.Players.Add(player1);
            sut.Players.Add(player2);

            sut.Reset();

            Assert.Empty(sut.Players);
        }
    }
}
