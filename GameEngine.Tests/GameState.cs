using Xunit;

namespace GameEngine.Tests
{
    public class GameState
    {
        [Fact]
        public void DamageAllPlayersWhenEarthquake()
        {
            var sut = new GameEngine.GameState();

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
            var sut = new GameEngine.GameState();

            var player1 = new GameEngine.PlayerCharacter();
            var player2 = new GameEngine.PlayerCharacter();

            sut.Players.Add(player1);
            sut.Players.Add(player2);

            sut.Reset();

            Assert.Empty(sut.Players);
        }
    }
}
