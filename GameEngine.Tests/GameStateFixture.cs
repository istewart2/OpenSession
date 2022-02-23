using System;

namespace GameEngine.Tests
{
    public class GameStateFixture : IDisposable
    {
        // fixture class has a State property which holds the single instance to be used for all tests
        public GameEngine.GameState State { get; private set; }

        public GameStateFixture()
        {
            State = new GameEngine.GameState();
        }

        public void Dispose()
        {
            // Cleanup
        }
    }
}
