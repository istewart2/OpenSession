using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    [Collection("GameState collection")]
    // let's you group tests into groups which can be run independently
    // run both classes together to check that the same instance is being used
    [Trait("Category", "Collection Sample")]
    public class GameStateCollectionSample2
    {
        private readonly GameStateFixture gameStateFixture;
        private readonly ITestOutputHelper output;

        public GameStateCollectionSample2(GameStateFixture gameStateFixture, ITestOutputHelper output)
        {
            this.gameStateFixture = gameStateFixture;
            this.output = output;
        }

        [Fact]
        public void Test3()
        {
            output.WriteLine($"GameState ID={gameStateFixture.State.Id}");
        }

        [Fact]
        public void Test4()
        {
            output.WriteLine($"GameState ID={gameStateFixture.State.Id}");
        }
    }
}
