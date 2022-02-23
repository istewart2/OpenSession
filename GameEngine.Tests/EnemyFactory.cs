using System;
using Xunit;

namespace GameEngine.Tests
{
    public class EnemyFactory
    {
        [Fact]
        public void EnemyFactory_ShouldNotAllowNullName()
        {
            GameEngine.EnemyFactory sut = new GameEngine.EnemyFactory();

            Assert.Throws<ArgumentNullException>(() => sut.Create(null));
        }
    }
}
