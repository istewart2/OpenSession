using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacter
    {
        // to reduce code duplication of the arrange phase, we can extract common setup into constructor
        // XUnit will still create a new instance before executing each test however

        // it may be time consuming or expensive to do so (eg. to setup inMemoryDbContext)
        // so we can instead create one instance and share it between tests - using a class fixture
        // see: https://xunit.net/docs/shared-context

        private readonly GameEngine.PlayerCharacter _sut;

        public PlayerCharacter()
        {
            _sut = new GameEngine.PlayerCharacter();
        }

        [Fact]
        public void PlayerCharacter_ShouldCalculateFullName()
        {
            _sut.FirstName = "Sarah";
            _sut.LastName = "Smith";

            Assert.Equal("Sarah Smith", _sut.FullName);

            // these aren't very good tests, but are here as example of different asserts
            Assert.StartsWith("Sarah", _sut.FullName);
            Assert.StartsWith("SARAH", _sut.FullName, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.EndsWith("Smith", _sut.FullName);
            Assert.Contains("h S", _sut.FullName);
        }

        [Fact]
        public void PlayerCharacter_ShouldStartAt100Health()
        {
            var result = _sut.Health;

            Assert.Equal(100, result);
        }

        [Fact]
        public void PlayerCharacter_TakingZeroDamage_ShouldHaveNoEffectOnHealth()
        {
            _sut.TakeDamage(0);

            Assert.Equal(100, _sut.Health);
        }

        [Fact]
        public void PlayerCharacter_TakingMinorDamage_ShouldReduceHealthSlightly()
        {
            _sut.TakeDamage(1);

            Assert.Equal(99, _sut.Health);
        }

        [Fact]
        public void PlayerCharacter_TakingMediumDamage_ShouldReduceHealthModerately()
        {
            _sut.TakeDamage(50);

            Assert.Equal(50, _sut.Health);
        }

        [Fact]
        public void PlayerCharacter_TakingLargeDamage_ShouldReduceHealthTo1()
        {
            _sut.TakeDamage(101);

            Assert.Equal(1, _sut.Health);
        }

        [Theory]
        [HealthDamageData]
        public void PlayerCharacter_TakingDamage_ShouldReduceHealth(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, _sut.Health);
        }
    }
}