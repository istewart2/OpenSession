using AutoFixture;
using Xunit;

namespace AutoFixtureDemo.Tests
{
    public class StringsDemo
    {
        // remember to add Autofixture package reference

        // autofixture github: https://github.com/AutoFixture/AutoFixture
        // "easily create test data for your unit tests"
        // how would we evaluate whether to use a library?

        // num of stars, open issues, recent commits, documentation, community, code quality
        // does it do something that would be complex / time consuming to implement ourselves
        // num of downloads - https://www.nuget.org/profiles/AutoFixture/

        // quick start guide: https://autofixture.github.io/docs/quick-start/

        [Fact]
        public void BasicStrings()
        {
            // arrange
            var sut = new NameJoiner();
            var fixture = new Fixture();

            var firstName = fixture.Create<string>();
            var lastName = fixture.Create<string>();

            // act
            var result = sut.Join(firstName, lastName);

            // assert
            Assert.Equal(firstName + ' ' + lastName, result);
        }
    }
}