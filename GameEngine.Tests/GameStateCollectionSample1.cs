using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    [Collection("GameState collection")]
    [Trait("Category", "Collection Sample")]
    public class GameStateCollectionSample1
    {
        private readonly GameStateFixture gameStateFixture;
        private readonly ITestOutputHelper output;

        public GameStateCollectionSample1(GameStateFixture gameStateFixture, ITestOutputHelper output)
        {
            this.gameStateFixture = gameStateFixture;
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            output.WriteLine($"GameState ID={gameStateFixture.State.Id}");
        }

        [Fact]
        public void Test2()
        {
            output.WriteLine($"GameState ID={gameStateFixture.State.Id}");
        }
    }
}
