using AutoFixture;
using System;
using System.Collections.Generic;
using System.Net.Mail;
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

        [Fact]
        public void NotATest_JustRandomStuff()
        {
            var fixture = new Fixture();
            var testInt = fixture.Create<int>();
            var testDecimal = fixture.Create<decimal>();
            var testDateTime = fixture.Create<DateTime>();
            var testGuid = fixture.Create<Guid>();
            var testEnum = fixture.Create<NameJoiner.FormalTitle>();
            var testEmail = fixture.Create<MailAddress>();
        }

        [Fact]
        public void NotATest_CreatingMultipleValues()
        {
            var fixture = new Fixture();

            IEnumerable<int> numbers = fixture.CreateMany<int>(12);

            List<string> testListOfStrings = new List<string>();
            fixture.AddManyTo(testListOfStrings, 10);

            // autofixture claims to improve test readability, make it easier to maintain tests
            // and make developers more productive when writing tests

            // can simplify the arrange phase of arrange, act, assert
            // lets you focus on what�s being tested, rather than how to setup the test scenario

            // uses anonymous test data - required for test to run, but values are unimportant

        }
    }
}